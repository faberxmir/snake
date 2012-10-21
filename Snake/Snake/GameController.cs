using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake {

    class GameController {

        private GameDataLogic gdl;

        public GameController(int scrnWidth, int scrnHeight) {
            gdl = new GameDataLogic(scrnWidth, scrnHeight);
        }

        private void VerticalMovement(int posY){
            gdl.moveSnakeVertical(posY);
        }

        private void HorizontalMovement(int posX){
            gdl.moveSnakeHorizontal(posX);
        }
    }
}
