using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake {

    class GameController {

        private GameDataLogic implementedLogic;

        public GameController() 
        {
            implementedLogic = new GameDataLogic();
        }

        public GameInfoDTO VerticalMovement(int posY)
        {
           return implementedLogic.moveSnakeVertical(posY);
        }

        public GameInfoDTO HorizontalMovement(int posX)
        {
           return implementedLogic.moveSnakeHorizontal(posX);
        }
        public GameInfoDTO initiate(int snakeSize, int screenWidth, int screenHeight)
        {
           GameInfoDTO returnInfo = implementedLogic.initiate(snakeSize, screenWidth, screenHeight);
           return returnInfo;
        }

    }
}
