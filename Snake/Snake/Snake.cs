using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : List<Coord>
    {
        List<Coord> snake;

        // Konstruktør
        public Snake()
        {
            setupSnake();
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
            snake.Insert(snake.Count - 1, coord);
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
