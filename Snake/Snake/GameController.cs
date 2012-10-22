using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake {

    class GameController {

        private GameDataLogic implementedLogic;

        public GameController() 
        {
            implementedLogic = new GameDataLogic(screenWidth, screenHeight)
        }

        public void VerticalMovement(int posY)
        {
            implementedLogic.moveSnakeVertical(posY);
        }

        public  void HorizontalMovement(int posX)
        {
            implementedLogic.moveSnakeHorizontal(posX);
        }
        public GameInfoDTO init(int screenWidth, int screenHeight)
        {
           return implementedLogic.init(screenWidth, screenHeight);
        }
    }
}
