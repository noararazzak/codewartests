using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsTest
{
    
    class PlayerMovement
    {
        public Tile Position { get; private set; }
        public Direction Direction { get; private set; }

        private List<InputType> inputs = new List<InputType>();
        private List<InputType> currentinputs = new List<InputType>(); 
        private Direction currentDirection;
        private Direction newDirection; 

        public PlayerMovement(int x, int y)
        {
            Position = new Tile(x, y);
        }


        public void Update()
        {
            NewInputs();

            for (int i = 0; i < inputs.Count;  i++)
            {
                Console.WriteLine("List" + i + " - " + inputs[i].direction);
            }
            if (inputs.Count == 0)
            {
                Direction = currentDirection;
                return;
            }
            else
            {
                newDirection = inputs[inputs.Count - 1].direction; 
            }

            if (currentDirection == newDirection)
            {
                switch (newDirection)
                {
                    case Direction.Up:
                        Position = new Tile(Position.X, Position.Y + 1);
                        break;
                    case Direction.Down:
                        Position = new Tile(Position.X, Position.Y - 1);
                        break;
                    case Direction.Left:
                        Position = new Tile(Position.X -1, Position.Y);
                        break;
                    case Direction.Right:
                        Position = new Tile(Position.X +1, Position.Y);
                        break;
                }
                    

            }

            else
            {
                currentDirection = newDirection; 
            }

            Direction = currentDirection;


            currentinputs.Clear(); 
        }

        public void NewInputs()
        {
            if (Input.GetState(Direction.Up))
            {
                if (!inputs.Any(i => i.direction == Direction.Up))
                {

                    currentinputs.Add(new InputType { order = 4, direction = Direction.Up });
                }
            }
            else
            {
                inputs.RemoveAll(x => x.direction == Direction.Up);
            }

            if (Input.GetState(Direction.Down))
            {
                if (!inputs.Any(i => i.direction == Direction.Down))
                {
                    currentinputs.Add(new InputType { order = 3, direction = Direction.Down });
                }
               
            }
            else
            {
                inputs.RemoveAll(x => x.direction == Direction.Down);
            }

            if (Input.GetState(Direction.Left))
            {
                if (!inputs.Any(i => i.direction == Direction.Left))
                {
                    currentinputs.Add(new InputType { order = 2, direction = Direction.Left });
                }
                
            }
            else
            {
                inputs.RemoveAll(x => x.direction == Direction.Left);
            }
            if (Input.GetState(Direction.Right))
            {
                if (!inputs.Any(i => i.direction == Direction.Right))
                {
                    currentinputs.Add(new InputType { order = 1, direction = Direction.Right });
                }
                
            }
            else
            {
                inputs.RemoveAll( x => x.direction == Direction.Right);
            }


            currentinputs = currentinputs.OrderBy(x => x.order).ToList();

            foreach (InputType i in currentinputs)
            {
                inputs.Add(i);
            }
            
        }


    }

    public class InputType
    {
        public int order;
        public Direction direction;
        
    }
}
