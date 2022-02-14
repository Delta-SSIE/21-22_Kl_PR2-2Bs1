using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WPF_13_NavalBattle
{
    class Player
    {
        private int _mapSize;
        private int _shipCount;

        public Player(int mapSize, int shipCount)
        {
            if (mapSize < 2)
                throw new ArgumentOutOfRangeException();
            _mapSize = mapSize;

            if (shipCount < 1)
                throw new ArgumentOutOfRangeException();
            _shipCount = shipCount;

            if (shipCount >= mapSize * mapSize)
                throw new ArgumentOutOfRangeException("Too many ships");

            CreateSea();
            PlaceShips();
        }



        /// <summary>
        /// Holds the real state of player sea
        /// </summary>
        private TileState[,] _sea;

        public TileState[,] RealSea
        {
            get
            {
                return (TileState[,])(_sea.Clone());
            }
        }
        /// <summary>
        /// Provides sea with masked ship positions for render
        /// </summary>
        public TileState[,] VisibleSea
        {
            get
            {
                TileState[,] sea = (TileState[,])(_sea.Clone());

                for (int x = 0; x < _mapSize; x++)
                {
                    for (int y = 0; y < _mapSize; y++)
                    {
                        if (sea[x, y] == TileState.Ship)
                            sea[x, y] = TileState.Sea;
                    }
                }

                return sea;
            }
        }
        public int Wrecks { get; private set; }
        public bool IsAlive
        {
            get
            {
                return Wrecks < _shipCount;
            }
        }
        private void CreateSea()
        {
            _sea = new TileState[_mapSize, _mapSize]; //automatically sets all values to TileState.Sea (=0)
        }
        private void PlaceShips()
        {
            Random rnd = new Random();

            int placedShips = 0;

            while (placedShips < _shipCount)
            {
                int x = rnd.Next(_mapSize);
                int y = rnd.Next(_mapSize);
                if (_sea[x, y] != TileState.Ship)
                {
                    _sea[x, y] = TileState.Ship;
                    placedShips++;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns>True on hitting a new ship, false otherwise</returns>
        public bool HandleShot(Coordinates target)
        {
            switch (_sea[target.X, target.Y])
            {
                case TileState.Sea:
                    _sea[target.X, target.Y] = TileState.Shot;
                    return false;

                case TileState.Ship:
                    _sea[target.X, target.Y] = TileState.Wreck;
                    Wrecks++;
                    return true;

                default:
                    return false;
            }
        }
        /// <summary>
        /// For computer - find a free tile to shoot
        /// </summary>
        /// <param name="opponentMap"></param>
        /// <returns></returns>
        public Coordinates FindTarget(TileState[,] opponentMap)
        {
            Random rnd = new Random();
            Coordinates target = null;
            do
            {
                int x = rnd.Next(_mapSize);
                int y = rnd.Next(_mapSize);
                if (opponentMap[x,y] == TileState.Sea)
                {
                    target = new Coordinates() { X = x, Y = y };
                }
            }
            while (target == null);
            return target;
        }
    }
}
