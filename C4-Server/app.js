const WebSocket = require('ws')
const shortid = require('shortid')

const wss = new WebSocket.Server({port: 80})

const allPlayers = {}

wss.on('connection', function connection (ws) {
  console.log("yeet")
  ws.on('message', function incoming (message) {
    console.log('wat')
    messageHandler(ws, message)
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

function messageHandler (ws, message) {
  console.log(message)
  let decoded = JSON.parse(message)
}

class Match {
  constructor (players) {
    this.players = {1: players[0], 10: players[1]}
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
