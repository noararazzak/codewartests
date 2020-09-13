using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTest
{
    public static class Input
    {
        public static bool GetState(Direction direction)
        {
            if (Press(direction) == direction)
            {
                return true;
            }

            else if (Release(direction) == direction)
            {
                return false; 
            }

            return false; 
        }

        public static Direction Press(Direction direction)
        {
            return direction;
        }

        public static Direction Release(Direction direction)
        {
            return direction; 
        }

        
    }

    public enum Direction { Up = 8, Down = 2, Left = 4, Right = 6 }

    public struct Tile
    {
        private int xValue;
        private int yValue;
        public int X
        {
            get
            {
                return xValue;
            }
        }
        public int Y
        {
            get
            {
                return yValue;
            }
        }
        public Tile(int x, int y)
        {
            xValue = x;
            yValue = y; 
        }
    }
}
