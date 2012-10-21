using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Snake {

    class GameView {

        private static readonly int scrnWidth = Console.WindowWidth;
        private static readonly int scrnHeight = Console.WindowHeight;

        private static int deltaTime = 500;

        private static GameController controller;
        private static GameDataLogic gameInfoDTO;

        private enum KEY {UpArrow, RightArrow, DownArrow, LeftArrow, Spacebar}

        static void Main(string[] args) {

        }

        public void checkKeyInput(KEY key) 
        {
            if ( key == KEY.UpArrow  || key == KEY.DownArrow ) {
                int movement = (int) key;
                controller.VerticalMovement(movement);
            }
            if  ( key == KEY.RightArrow || key == KEY.LeftArrow ) {
                int movement = (int) key;
                controller.HorizontalMovement(movement);
            }
            if ( key == KEY.Spacebar ) {
                pause();
            }
        }

        public void initiate() 
        {
            controller = new GameController();
            gameInfoDTO = transferScreenSize(scrnWidth, scrnHeight);
        }

        public void pause() {
               //pause
        }
    }
}
