const team = {
  _players: [
    {
    firstName: 'Hector',
    lastName: 'Camacho',
    age: 11
    },
    {
    firstName: 'Caesar',
    lastName: 'Vialpando',
    age: 11
    },
    {
    firstName: 'Roberto',
    lastName: 'Duran',
    age: 11
    }
  ],
  _games: [
    {
    opponent: 'Broncos',
    teamPoints: 42,
    opponentPoints: 27
    },
    {
    opponent: 'Steelers',
    teamPoints: 142,
    opponentPoints: 17
    },
    {
    opponent: 'Chargers',
    teamPoints: 32,
    opponentPoints: 27
    },
  ],
  get players(){
    return this._players;
  },
  get games(){
    return this._games;
  },
  addPlayer (firstName, lastName, age) {
    const player = {
      firstName,
      lastName,
      age
    };
    this._players.push(player);
  },
  addGame(opponent, teamPoints, opponentPoints){
    const game = {
      opponent,
      teamPoints,
      opponentPoints
    };
    this._games.push(game);
  }
};

team.addPlayer('Steph', 'Curry', 28);
team.addPlayer('Lisa', 'Leslie', 44);
team.addPlayer('Bugs', 'Bunny', 76);

team.addGame('Dolphins', 64, 28);
team.addGame('Browns', 64, 44);
team.addGame('Bears', 56, 76);

console.log(team.players);
console.log(team.games);




