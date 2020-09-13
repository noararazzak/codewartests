using System;
using System.Collections.Generic;

namespace CodewarsTest
{
    class PlayerMovement_v0
    {
        public Tile Position { get; private set; }
        public Direction Direction { get; private set; }

        private List<Direction> currentlyPressed = new List<Direction>();

        Direction currentDirection;

        public PlayerMovement_v0(int x, int y)
        {
            Position = new Tile(x, y);
        }

        public void Update()
        {
            CheckNewInputs();

            if (currentlyPressed.Count == 0)
            {
                Direction = currentDirection;
                return;
            }

            if (currentDirection == currentlyPressed[0])
            {
                switch (currentlyPressed[0])
                {
                    case Direction.Up:
                        Position = new Tile (Position.X, Position.Y + 1);
                        break;

                    case Direction.Down:
                        Position = new Tile(Position.X, Position.Y - 1);
                        break;

                    case Direction.Left:
                        Position = new Tile(Position.X - 1, Position.Y);
                        break;

                    case Direction.Right:
                        Position = new Tile(Position.X + 1, Position.Y);
                        break;
                }
            }
            else
            {
                currentDirection = currentlyPressed[0];
            }

            Direction = currentDirection;

        }

        public void CheckNewInputs()
        {
            if (Input.GetState(Direction.Right))
            {
                if (!currentlyPressed.Contains(Direction.Right))
                {
                    currentlyPressed.Insert(0, Direction.Right);
                }
            }
            else { currentlyPressed.Remove(Direction.Right); }

            if (Input.GetState(Direction.Left))
            {
                if (!currentlyPressed.Contains(Direction.Left))
                {
                    currentlyPressed.Insert(0, Direction.Left);
                }
            }
            else { currentlyPressed.Remove(Direction.Left); }

            if (Input.GetState(Direction.Down))
            {
                if (!currentlyPressed.Contains(Direction.Down))
                {
                    currentlyPressed.Insert(0, Direction.Down);
                }
            }
            else { currentlyPressed.Remove(Direction.Down); }

            if (Input.GetState(Direction.Up))
            {
                if (!currentlyPressed.Contains(Direction.Up))
                {
                    currentlyPressed.Insert(0, Direction.Up);
                }
            }
            else { currentlyPressed.Remove(Direction.Up); }

        }
    }
}
