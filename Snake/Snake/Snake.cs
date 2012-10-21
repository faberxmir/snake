using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : List<Coord>
    {
        List<Coord> snake;

        private static readonly int SNAKEHEAD = 0;

        public Snake()
        { }

        // Konstruktør
        public Snake()
        {
            setupSnake();
        }

        public List<Coord> getBodyPosition(Coord coord)
        {
            int pos = snake.IndexOf(coord);

            return pos;
        }

        public bool hasCoord(Coord coord)
        {
            foreach (Coord i in snake)
            {
                if (i.Equals(coord))
                {
                    return true;
                }
            }
            return false;
        }

        public void setupSnake()
        {
            // Initialiserer
            Coord coord = new Coord(10, 10);
            List<Coord> snake = new List<Coord>();

            // Legger til slangen
            snake.Add(coord);
            snake.Add(coord);
            snake.Add(coord);
            snake.Add(coord);
        }

        public void moveToCoord(Coord nextCoord)
        {
            if (snake != null)
            {
                snake.Add(nextCoord);
            }
        }

        public List<Coord> getSnakeBody(Coord coord)
        {
            int snakeBody = 1;
            return coord;
        }

        public int getSnakeHead()
        {
            int snakeHead = snake.IndexOf(snake.First());
            return snakeHead;
        }
    }
}
