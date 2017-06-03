const io = require('socket.io')(process.env.PORT || 3000)
console.log('gameserver started')

io.on('connection', socket => {
  console.log('new client connected')
  socket.on('move', data => {
    console.log('client moved!')
  })
})

