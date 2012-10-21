using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    struct Coord
    {
        public int posX;
        public int posY;

        public Coord(int x, int y)
        {
            posX = x;
            posY = y;
        }

        public Coord(Coord input) 
        { 
            posX = input.posX; 
            posY = input.posY; 
        }
    }
}
