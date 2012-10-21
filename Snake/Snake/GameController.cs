using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake {

    class GameController {

        private GameDataLogic gdl;

        public GameController() 
        {
        }

        public void VerticalMovement(int posY)
        {
            gdl.moveSnakeVertical(posY);
        }

        public  void HorizontalMovement(int posX)
        {
            gdl.moveSnakeHorizontal(posX);
        }

        public GameInfoDTO transferScreenSize(int scrnWidth, int scrnHeight)
        {
            gdl = new GameDataLogic(scrnWidth, scrnHeight);
            return gdl.init();

        }

    }
}
