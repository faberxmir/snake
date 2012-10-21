using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class GameDataLogic
    {
        private int screenWidth { get; set; }
        private int screenHeight { get; set; }
        private GameInfoDTO gameInfo;
        private Snake snake;

        public GameDataLogic(int inScrnWidth, int inScrnHeight)
        {
            screenWidth = inScrnWidth;
            screenHeight = inScrnHeight;
            snake = new Snake();
        }

        public GameInfoDTO moveSnakeHorizontal(int posXmodifier)
        {
            if (0 <= newPosX && screenWidth >= newPosX)
            {
                //updateposX
            }
            else
            {
               // gameInfo.setGameOver(true);
            }

            return gameInfo;
        }
        public GameInfoDTO moveSnakeVertical(int posYmodifier)
        {
            if (0 <= posYmodifier && screenWidth >= posYmodifier)
            {
                Coord newCoord = gameInfo.getSnakePart(0);
                newCoord.posY += posYmodifier;
                if (0 < newCoord.posY && screenWidth > newCoord.posY)
                {
                    GameInfoDTO.snake = GameInfoDTO.snake.grow(newCoord);
                }
            }
            else
            {
                // gameInfo.setGameOver(true);
            }
            return gameInfo;
        }

        private void checkAppleHit(Coord checkCoord)
        {
            Boolean hitApple = false;
            if (gameInfo.getAppleX() == checkCoord.X && gameInfo.getAppleY() == Coord.Y)
            {
                growSnake(checkCoord);
            }
        }

        private Boolean snakeHitSelf()
        {
            Boolean hitSelf = false;
            do( ) 
            return hitSelf;
        }

        private void growSnake(Coord newFrontCoord)
        {
            // GameInfoDTO.setSnake(gameInfo.getSnake().grow(checkCoord));
        }

        private void setApplePos()
        {
        }
    }
}
