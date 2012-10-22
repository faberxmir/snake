using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Snake {

    class GameView {
        private static GameController gameController;
        private static GameInfoDTO gameInfoDTO;

        private Stopwatch frameTimer;

        private int moveX;
        private int moveY;
        //SETTINGS:
        private static readonly int INITIALSNAKESIZE = 4;
        private static readonly int FRAMERATE = 8;

        private enum KEY
        {
            UPARROW,
            RIGHTARROW,
            DOWNARROW,
            LEFTARROW,
            Spacebar
        }
        public GameView()
        {
            Console.CursorVisible = false;
            initiate();
            rungame();
        }
        private void initiate()
        {
            moveX = 1;
            moveY = 0;
            frameTimer = new Stopwatch();
            gameController = new GameController();
            gameInfoDTO = gameController.initiate(INITIALSNAKESIZE, Console.WindowWidth, Console.WindowHeight);
            frameTimer = new Stopwatch();
        }

        private int rungame()
        {
            while (!gameInfoDTO.gameOver)
            {
                pause(FRAMERATE);
                //Control framerate by pausing a given number of milliseconds
                //get key input
                if (Console.KeyAvailable)
                {
                    inputHandler();
                }
                if (!(moveX == 0))
                {
                    gameInfoDTO = gameController.HorizontalMovement(moveX);
                }
                else
                {
                    gameInfoDTO = gameController.VerticalMovement(moveY);
                }

                drawApple();
                drawSnake();
            }
            return 1;
        }
        private void inputHandler() 
        {
            ConsoleKeyInfo inputKey = Console.ReadKey();
            switch(inputKey.Key)
            {
                case ConsoleKey.UpArrow:
                    moveX = 0;
                    moveY = -1;
                    break;
                case ConsoleKey.DownArrow:
                    moveX = 0;
                    moveY = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    moveY = 0;
                    moveX = -1;
                    break;
                case ConsoleKey.RightArrow:
                    moveY = 0;
                    moveX = 1;
                    break;
                default:
                    break;
            }
        }

        private void drawSnake()
        {
            List<Coord> snake = gameInfoDTO.getSnake();
            int snakeLength = snake.Count;
            
            for (int i = 0; i < snakeLength-1; ++i)
            {
                if (i == 0)
                {
                    drawAt(snake[i].posX, snake[i].posY , " ");
                }
                else
                {
                    drawAt(snake[i].posX, snake[i].posY, "0");
                }
            }
            drawAt(snake[snakeLength - 1].posX, snake[snakeLength - 1].posY, "@");//TODO: NOT a magic number improve grace. There must be a get first method
        }
        private void drawApple()
        {
            drawAt(gameInfoDTO.getAppleX(), gameInfoDTO.getAppleY(), "*");
        }

        private void drawAt(int x, int y, String inCharacter)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(inCharacter);
        }
        private void pause(long frameRate)
        {
            frameTimer.Start();
            long timePerFrame = (long) 1000 / frameRate;
            while (frameTimer.ElapsedMilliseconds < timePerFrame) 
            {
                //Do absolutely nothing
            }
            frameTimer.Reset();
        }
    }
}
