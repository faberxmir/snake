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

            return move(newMove);
        }
        public GameInfoDTO moveSnakeVertical(int posYmodifier)
        {
            Coord newMove = snake.getHead();
            newMove.posY += posYmodifier;

            return move(newMove);
        }

        private GameInfoDTO move(Coord newMove)
        {
            GameInfoDTO gameInfo = new GameInfoDTO(snake, apple);
            if (!crashing(newMove))
            {
                checkAppleHit(newMove);
                gameInfo.setSnake(snake);//TODO: Snake is set twice, surely this can be done with more grace
            }
            else
            {
                gameInfo.setGameOver(true);
            }
            return gameInfo;
        }
        private void checkAppleHit(Coord newCoord)
        {
            if (apple.posX == newCoord.posX && apple.posX == newCoord.posX)
            {
                snake.grow();
                setApplePos();
            }
        }

        private void setApplePos()
        {
            Random random = new Random();
            int newAppleY = random.Next(0, screenHeight);
            int newAppleX = random.Next(0, screenWidth);
            apple.posY = newAppleY;
            apple.posX = newAppleX;
        }

        private Boolean crashing(Coord newMove)
        {
            int x = newMove.posX;
            int y = newMove.posY;

            if (0 < y && 0 < x &&
                y < screenWidth && x < screenHeight && 
                !snakeHitSelf(newMove))
            {
                return false;
            }
            return true;
        }

        private Boolean snakeHitSelf(Coord newMove)
        {
            return snake.hasCoord(newMove);
        }
    }
}
