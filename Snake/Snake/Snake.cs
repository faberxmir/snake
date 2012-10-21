using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake:List<Coord>
    {
        
        public Coord tail, head, newHead;
        Random random;
        List<Coord> snake;
        GameDataLogic gdl;

        // Konstruktør
        public Snake()
        {
            setupSnake(coord);
        }


        public List<Coord> bodyPostition()
        {
            return 0;
        }

        void grow(int x, int y)
        { 
            
        }

        public Coord updatePosition(Coord)
        {
            return 0;
        }

        public void getBodyPosition()
        {
        
        }

        public bool hasCoord()
        {
            return false;
        }

        public Coord setupSnake(Coord coord)
        {

            // Initialiserer
            random = new Random();
            coord = new Coord(10,10);
            
            snake = new List<Coord>();

            // Legger til slangen
            snake.Add(coord);
            snake.Add(coord);
            snake.Add(coord);
            snake.Add(coord);

            tail = new Coord(snake.First());
            head = new Coord(snake.Last());
            newHead = new Coord(head);

            if (!gg)
            {
                snake.Add(newHead);
            }
        }
    }
}
