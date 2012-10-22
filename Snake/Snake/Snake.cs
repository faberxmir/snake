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

        // Konstruktør
        public Snake()
        {
            setupSnake();
        }
        
        // Henter hele posisjonen for slangen
        public List<Coord> getBodyPosition()
        {
            return snake;
        }

        public List<Coord> moveSnake(Coord coord)
        {
            for (int i = 0; i < snake.Count -1; ++i)
            {
                snake = snake[i] + 1;
            }
        }

        // Sjekker om slangen har koordinater
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

        // Setter opp slangen første gang i hver runde
        public void setupSnake()
        {
            // Initialiserer
            Coord coord = new Coord(10, 10);
            snake = new List<Coord>();

            // Legger til slangen
            snake.Add(coord);
            snake.Add(coord);
            snake.Add(coord);
            snake.Add(coord);
        }

        // Legger til et ledd i slangen etter ett eple er tatt
        public List<Coord> growSnake(Coord nextCoord)
        {
            if (snake != null)
            {
                snake.Add(nextCoord);
            }
            return snake;
        }

        // Henter posisjonen til slangekroppen
        public List<Coord> getSnakeBody(Coord coord)
        {
            return snake;
        }

        // Henter posisjonen til slangehodet
        public Coord getSnakeHead()
        {
            return snake.Last();
        }
    }
}
