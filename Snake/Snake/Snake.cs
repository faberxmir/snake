using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : List<Coord>
    {
<<<<<<< HEAD
        List<Coord> snake;

        private static readonly int SNAKEHEAD = 0;

=======
        private List<Coord> snake;
        private readonly static int TRAILCOMPENSATOR = 1;
        public int Count { get; set; }
>>>>>>> origin/Faber
        // Konstruktør
        public Snake(int snakeSize)
        {
            setupSnake(snakeSize + TRAILCOMPENSATOR);
        }
        
        // Henter hele posisjonen for slangen
        public Coord getBodyPosition(int i)
        {
            Coord returnCoord = new Coord(-1, -1);
            if (i < snake.Count)
            {
                returnCoord = snake[i];
            }
            return returnCoord;
        }

        public List<Coord> moveSnake(Coord coord)
        {
            for (int i = 0; i < snake.Count -1; ++i)
            {
                snake[i] = snake[i + 1];
            }
            snake[snake.Count - 1] =  coord;
            return snake;
        }

        // Sjekker om slangen har koordinater
        public bool hasCoord(Coord coord)
        {
            foreach (Coord c in snake)
            {
                if (c.Equals(coord))
                {
                    return true;
                }
            }
            return false;
        }

        // Setter opp slangen første gang i hver runde
        public void setupSnake(int initSnakeSize)
        {
            // Initialiserer
            Coord coord = new Coord(10, 10);
            snake = new List<Coord>();

            if (initSnakeSize > 0)
            {
                // Legger til slangen
                for (int i = 0; i < initSnakeSize; ++i)
                {
                    snake.Add(coord);
                }
            }
            Count = snake.Count;
        }

        // Legger til et ledd i slangen etter ett eple er tatt
        public List<Coord> growSnake(Coord nextCoord)
        {
            if (snake != null)
            {
                snake.Insert(0, nextCoord);
            }
            Count = snake.Count;
            return snake;
        }

        // Henter posisjonen til slangekroppen
        public List<Coord> getSnake()
        {
            return snake;
        }

        // Henter posisjonen til slangehodet
        public Coord getSnakeHead()
        {
            return snake[snake.Count - 1];
        }

        public Coord getSnakeTrail()
        {
            return snake[Count - 1];
        }
    }
}
