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
        private GameInfoDTO gameInfo;

        public GameDataLogic()
        {
        }
        public GameInfoDTO initiate(int snakeSize, int inScrnWidth, int inScrnHeight)
        {
            screenWidth = inScrnWidth;
            screenHeight = inScrnHeight;
            snake = new Snake(snakeSize);
            setApplePos();
            gameInfo = new GameInfoDTO(snake.getSnake(), apple);
            return gameInfo;
        }

        public GameInfoDTO moveSnakeHorizontal(int posXmodifier)
        {
            Coord newMove = snake.getSnakeHead();
            newMove.posX += posXmodifier;

            return move(newMove);
        }

        public GameInfoDTO moveSnakeVertical(int posYmodifier)
        {
            Coord newMove = snake.getSnakeHead();
            newMove.posY += posYmodifier;

            return move(newMove);
        }

        private GameInfoDTO move(Coord newMove)
        {
            if (!crashing(newMove))
            {
                checkAppleHit(newMove);
                snake.moveSnake(newMove);
                gameInfo.setSnake(snake.getSnake());//TODO: Snake is set twice, surely this can be done with more grace
            }
            else
            {
                gameInfo.gameOver = true;
            }
            return gameInfo;
        }
        private void checkAppleHit(Coord newCoord)
        {
            Coord snakeHead = snake.getSnakeHead();

            if (apple.Equals(snakeHead))
            {
                snake.growSnake(newCoord);
                setApplePos();
                gameInfo.setAppleCoord(apple);
            }
        }

        private void setApplePos()
        {
            Random random = new Random();
            do
            {
                int newAppleY = random.Next(0, screenHeight);
                int newAppleX = random.Next(0, screenWidth);
                apple.posY = newAppleY;
                apple.posX = newAppleX;
          
            } while (snake.hasCoord(apple));
        }

        private Boolean crashing(Coord newMove)
        {
            int x = newMove.posX;
            int y = newMove.posY;

            if (0 <= y && 0 <= x &&
                x < screenWidth && y < screenHeight && 
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
