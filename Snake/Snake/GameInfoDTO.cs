using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake {

    class GameInfoDTO {

        private bool gameOver { get; set; }
		private List<Coord> snake;
        private Coord apple;
        Random random = new Random();

        public GameInfoDTO() { }

        public GameInfoDTO(List<Coord> snake, Coord apple) {
            gameOver = false;
            snake = new List<Coord>();
            apple = new Coord();
        }

		public List<Coord> getSnake(){
			return snake;
		}

        public Coord getApple() {
            return apple;
        }

        public int getAppleX() {
            return apple.X;
        }

        public int getAppleY() {
            return apple.Y;
        }

        public Coord getSnakeCoord(int listPosition) {
            return snake[listPosition];
        }

        public void setAppleCoord(Coord c) {
            apple.X = c.X;
            apple.Y = c.Y;
        }

    }
}
