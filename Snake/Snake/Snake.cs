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
        
        // Henter hele posisjonen for slangen
        public List<Coord> getBodyPosition()
        {
            return snake;
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

        // Oppdaterer posisjonen til y-aksen
        public void updatePosY(int newPosY)
        {
               
        }

        // Legger til et ledd i slangen etter ett eple er tatt
        public List<Coord> addToCoord(Coord nextCoord)
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
