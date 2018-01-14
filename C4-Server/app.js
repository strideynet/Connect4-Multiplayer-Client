const WebSocket = require('ws')
const shortid = require('shortid')
const jwt = require('jsonwebtoken')

const wss = new WebSocket.Server({ port: 80 })

const allPlayers = {}

const SERVER_AGENT = 'C4P Server'
const SERVER_SECRET = 'temporarySecret'

let waitingForMatch = null

wss.on('connection', function (ws) {
  ws.on('message', function (message) {
    messageHandler(ws, message)
  })

  ws.on('error', function (error) {
    if (error.code !== 'ECONNRESET') {
      console.log(error)
    }
  })
})

/*
message datatype:
{
  type: STRING // Message Type
  agent: STRING // Identifies the client
  data: OBJECT // Encoded data for that message
}
*/
const messageHandles = {
  'Registration': function (ws, req) {
    let ply = new Player(ws, req.data.username)

    let jwtContent = {
      username: ply.username,
      id: ply.id
    }

    let token = jwt.sign(jwtContent, SERVER_SECRET)

    let message = {
      agent: SERVER_AGENT,
      type: 'RegistrationReturn',
      data: {jwt: token}
    }

    ws.send(JSON.stringify(message))
  },
  'MatchRequest': function (ws, req) {
    if (waitingForMatch == null) {
      waitingForMatch = req.user
    } else { //If someone is waiting match with them
      let match = new Match([req.user, waitingForMatch])
      waitingForMatch = null
    }
  },
  'ChatMessage': function (ws, req) {

  },
  'PlayPosition': function (ws, req) {
    if (req.user.match && (req.data.column !== null) && (req.data.column < 7)) {
      req.user.playPosition(req.data.column)
    } else {
      return console.error('Invalid message recieved. Data fields incorrect.')
    }
  }
}

function messageHandler (ws, rawMessage) {
  console.log(rawMessage)
  let req = {}

  try {
    req = JSON.parse(rawMessage)
  } catch (e) {
    return console.error('Invalid message recieved. Cannot decode.')
  }

  if (messageHandles[req.type]) {
    if (req.type !== 'Registration') { // All other message types require authentication
      if (req.jwt) {
        let decoded = {}
        try {
          decoded = jwt.verify(req.jwt, SERVER_SECRET)
        } catch (e) {
          return console.error('Issue with JWT')
        }

        if (allPlayers[decoded.id]) {
          req.user = allPlayers[decoded.id]
        } else {
          return console.error('User not found. Maybe session expired or server restarted.')
        }
      } else {
        return console.error('Missing JWT')
      }
    }
    messageHandles[req.type](ws, req)
  } else {
    console.error('Invalid message type. Cannot handle.')
  }
}

class Match {
  constructor (players) {
    this.players = { 1: players[0], 10: players[1] }
    players[0].boardNumber = 1
    players[1].boardNumber = 10

    players[0].match = this
    players[1].match = this

    this.currentPlayer = 1
    this.board = []

    this.live = true

    this.clearBoard()
    this.generateMatchRequestReturn()
  }

  generateMatchRequestReturn () {
    let $this = this
    const arr = [1, 10]
    arr.forEach(function (value) {
      let opponent = 10
      if (value === 10) { opponent = 1 }

      let message = {
        type: 'MatchRequestReturn',
        agent: SERVER_AGENT,
        data: {
          opponent: $this.players[opponent].username,
          localNum: value,
          currentPlayer: $this.currentPlayer
        }
      }

      $this.players[value].ws.send(JSON.stringify(message))
    })
  }

  clearBoard () {
    this.board = [ [ 0, 0, 0, 0, 0, 0 ],
                   [ 0, 0, 0, 0, 0, 0 ],
                   [ 0, 0, 0, 0, 0, 0 ],
                   [ 0, 0, 0, 0, 0, 0 ],
                   [ 0, 0, 0, 0, 0, 0 ],
                   [ 0, 0, 0, 0, 0, 0 ],
                   [ 0, 0, 0, 0, 0, 0 ] ]
  }

  attemptPlay (user, column) {
    if (this.live) {
      let freeRow = this.findFree(column)
      if (freeRow !== -1) {
        this.board[column][freeRow] = user.boardNumber
        this.alternatePlayer()

        let win = this.checkWin()
        if (win === false) {
          this.checkDrop()
          this.sendBoardUpdate()
        } else {
          this.endMatch(this.players[win], 1)
        }
      }
    }
  }

  alternatePlayer () {
    if (this.currentPlayer === 1) {
      this.currentPlayer = 10
    } else {
      this.currentPlayer = 1
    }
  }

  findFree (column) {
    for (let y = 5; y >= 0; y--) {
      if (this.board[column][y] === 0) {
        return y
      }
    }

    return -1
  }

  sendBoardUpdate () {
    let message = JSON.stringify({
      type: 'MatchUpdate',
      agent: SERVER_AGENT,
      data: {
        board: this.board,
        currentPlayer: this.currentPlayer
      }
    })

    this.players[1].ws.send(message)
    this.players[10].ws.send(message)
  }

  checkWin () {
    var Victory = false
    var Total = 0

    for (var BigXLooper = 0; BigXLooper < 4; BigXLooper++) {
      for (var BigYLooper = 0; BigYLooper < 3; BigYLooper++) {
        for (var SmallXLooper = 0; SmallXLooper < 4; SmallXLooper++) { // Verticals
          Total = 0

          for (var SmallYLooper = 0; SmallYLooper < 4; SmallYLooper++) {
            Total += this.board[BigXLooper + SmallXLooper][BigYLooper + SmallYLooper]
          }

          if (Total === 40) { Victory = 10 } else { if (Total === 4) { Victory = 1 } }
        }

        for (var SmallYLooper = 0; SmallYLooper < 4; SmallYLooper++) { // Horizontals
          Total = 0

          for (var SmallXLooper = 0; SmallXLooper < 4; SmallXLooper++) {
            Total += this.board[BigXLooper + SmallXLooper][BigYLooper + SmallYLooper]
          }

          if (Total === 40) { Victory = 10 } else { if (Total === 4) { Victory = 1 } }
        }

        var DiagonalTLBR = this.board[BigXLooper][BigYLooper] + this.board[BigXLooper + 1][BigYLooper + 1] +// Diagonals
        this.board[BigXLooper + 2][BigYLooper + 2] + this.board[BigXLooper + 3][BigYLooper + 3]
        if (DiagonalTLBR === 40) { Victory = 10 } else { if (DiagonalTLBR === 4) { Victory = 1 } }

        var DiagonalBLTR = this.board[BigXLooper + 3][BigYLooper] + this.board[BigXLooper + 2][BigYLooper + 1] +
        this.board[BigXLooper + 3][BigYLooper + 2] + this.board[BigXLooper][BigYLooper + 3]
        if (DiagonalBLTR === 40) { Victory = 10 } else { if (DiagonalBLTR === 4) { Victory = 1 } }
      }
    }

    return Victory
  }

  checkDrop () {

  }

  // Type: 1 - Standard Win 2 - Disconnect by loser
  endMatch (winner, type) {
    let message = {
      agent: SERVER_AGENT,
      type: "MatchEnd",
      data: {
        winner: winner.boardNumber,
        type: type
      }
    }

    this.players[1].ws.send(JSON.stringify(message))
    this.players[10].ws.send(JSON.stringify(message))
    this.live = false
  }
}

class Player {
  constructor (ws, username) {
    this.id = shortid.generate()

    allPlayers[this.id] = this

    this.ws = ws
    this.username = username
    this.boardNumber = 0
    this.match = null
  }

  playPosition (column) {
    this.match.attemptPlay(this, column)
  }
}
