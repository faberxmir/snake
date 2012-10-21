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
        private Snake snake;
        private Coord apple;

        public GameDataLogic(int inScrnWidth, int inScrnHeight)
        {
            screenWidth = inScrnWidth;
            screenHeight = inScrnHeight;
            snake = new Snake();
            apple = setApplePos();
        }

        public GameInfoDTO moveSnakeHorizontal(int posXmodifier)
        {
            Coord newMove = snake.getSnakeHead();
            newMove.posX += posXmodifier;
            if (0 <= newMove.posX && screenWidth >= newMove.posX)
            {
   
            }
            else
            {
                gameInfo.setGameOver(true);
            }

            return gameInfo;
        }
        public GameInfoDTO moveSnakeVertical(int posYmodifier)
        {
            if (0 <= posYmodifier && screenWidth >= posYmodifier)
            {
                Coord newMove = gameInfo.getSnakePart(0);
                newMove.posY += posYmodifier;
                if (0 < newMove.posY && screenWidth > newMove.posY)
                {
                   // GameInfoDTO.snake = GameInfoDTO.snake.grow(newCoord);
                }
            }
            else
            {
                gameInfo.setGameOver(true);
            }
            return gameInfo;
        }
        private void move(Coord newMove)
        {

            if (!snakeHitSelf(newMove))
            {
                checkAppleHit(newMove);
            }
            else
            {
                GameInfoDTO.setGameOver(true);
            }
        }
        private void checkAppleHit(Coord checkCoord)
        {
            Boolean hitApple = false;
            if (gameInfo.getAppleX() == checkCoord.X && gameInfo.getAppleY() == Coord.Y)
            {
                growSnake(checkCoord);
            }
        }

        private Boolean snakeHitSelf(Coord newMove)
        {
            return snake.hasCoord(newMove);
        }

        private void growSnake(Coord newFrontCoord)
        {
            
        }

        private Coord setApplePos()
        {
        }
        private void updateSnakeBody(Coord newMove)
        {
            snake.grow(newMove);
        }

    }
}
