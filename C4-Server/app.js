const WebSocket = require('ws')
const shortid = require('shortid')
const jwt = require('jsonwebtoken')

const wss = new WebSocket.Server({ port: 80 })

const allPlayers = {}

const SERVER_AGENT = "C4P Server"
const SERVER_SECRET = "temporarySecret"

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
    if (req.user.match) {
      
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
    players[0].boardNumber = 0
    players[1].boardNumber = 10

    players[0].match = this
    players[1].match = this

    this.currentPlayer = 1
    this.board = []

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
          localNum: value
        }
      }

      $this.players[value].ws.send(JSON.stringify(message))
    })
  }

  clearBoard () {
    this.board = Array(7).fill(Array(6).fill(0)) // Creates zero-filled 7x6 array
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
}