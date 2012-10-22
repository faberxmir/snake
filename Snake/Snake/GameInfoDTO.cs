using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake {

    class GameInfoDTO {

        public bool gameOver { get; set; }
		private List<Coord> snake;
        private Coord apple;

        public GameInfoDTO() { }

        public GameInfoDTO(List<Coord> inSnake, Coord inApple) 
        {
            gameOver = false;
            snake = inSnake;
            apple = inApple;
        }

		public List<Coord> getSnake()
        {
			return snake;
		}

        public void setSnake(List<Coord> inSnake)
        {
            snake = inSnake;
        }

        public Coord getApple()
        {
            return apple;
        }

        public int getAppleX() 
        {
            return apple.posX;
        }

        public int getAppleY()
        {
            return apple.posY;
        }

        public Coord getSnakeCoord(int listPosition)
        {
            return snake[listPosition];
        }

        public void setAppleCoord(Coord appleCoord) 
        {
            apple.posX = appleCoord.posX;
            apple.posY = appleCoord.posY;
        }

    }
}
