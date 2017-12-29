const WebSocket = require('ws')
const shortid = require('shortid')
const jwt = require('jsonwebtoken')

const wss = new WebSocket.Server({ port: 80 })

const allPlayers = {}

const SERVER_AGENT = "C4P Server"

wss.on('connection', function (ws) {
  ws.send(JSON.stringify({ info: 'spag'}))

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

    let token = jwt.sign(jwtContent, 'temporarySecret')

    let message = {
      agent: SERVER_AGENT,
      type: 'RegistrationReturn',
      data: {jwt: token}
    }

    ws.send(JSON.stringify(message))
  },
  'MatchRequest': function (ws, req) {

  },
  'ChatMessage': function (ws, req) {

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

    this.clearBoard()
  }

  clearBoard () {
    this.board = Array(7).fill(Array(6).fill(0)) // Creates zero-filled 7x6 array
  }
}
