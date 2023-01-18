using System;


class minseok
{
    enum PlayerDirection //열거형도 의미가 있어야됨.
    {
        right = 1,
        left = 2,
        up = 3,
        down = 4,
        none = 0
    }
    // 열거형이라면 연관성이 있으면좋음.
    //실제 물리값이 중요하지 않은경우에는 열거형을 활용할 수 있음.

    static void Main()
    {
        Console.CursorVisible = false;
        Console.Title = "KKYU";
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();


        int playerX = 5;
        int playerY = 5;

        int BoxX = 7;
        int BoxY = 7;



        while (true)
        {
            Console.Clear();
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("@");
            Console.SetCursorPosition(BoxX, BoxY);
            Console.Write("B");

            ConsoleKey key = Console.ReadKey().Key;

            if (key == ConsoleKey.RightArrow)
            {
                playerX = Math.Min(playerX + 1, 15);
            }

           

            if (key == ConsoleKey.LeftArrow)
            {
                playerX = Math.Max(playerX - 1, 0);
            }

          

            if (key == ConsoleKey.UpArrow)
            {
                playerY = Math.Max(playerY - 1, 0);
            }

          

            if (key == ConsoleKey.DownArrow)
            {
                playerY = Math.Min(playerY + 1, 10);
            }


            // ---------------------------------BoX -------------------------------
            //key의 방향으로 하지 않는게 나중에 유지보수 하기가 편할 수 있다. 
            //이동한 후 
            //playerX - 1 == BoxX - 1 && PlayerY == BoxY (오른쪽이동)
            //playerX + 1 == BoxX - 1  =================================> Player Direction PlayDirection = 0==none  ,1,2,3 가각 왼쪽오른쪽위로아래로 
            //필요한 경우 데이터를 추가적으로 만들 수 있어야 한다. 

            PlayerDirection playerDirection = 0;

            if(playerX == BoxX && playerY == BoxY ) 
            {
                switch (playerDirection) //열거형,문자형도  스위치에 가능
                {
                    case PlayerDirection.up: 
                        BoxX = Math.Min(15, BoxX + 1);                   
                        break;

                    case 2: 
                        BoxX = Math.Max(0, BoxX - 1);
                        break;

                    case 3: using System.ComponentModel;

namespace Sokoban
{
    // 열거형
    enum Direction
    {
        None,
        Left,
        Right,
        Up,
        Down
    }

    class Program
    {
        static void Main()
        {
            // 초기 세팅
            Console.ResetColor();                               // 컬러를 초기화한다.
            Console.CursorVisible = false;                      // 커서를 숨긴다.
            Console.Title = "홍성재의 파이어펀치";               // 타이틀을 설정한다.
            Console.BackgroundColor = ConsoleColor.DarkRed;     // 배경색을 설정한다.
            Console.ForegroundColor = ConsoleColor.Yellow;      // 글꼴색을 설정한다.
            Console.Clear();                                    // 출력된 모든 내용을 지운다.

            // 기호 상수 정의
            // 맵의 가로 범위, 세로 범위
            const int MAP_MIN_X = 0;
            const int MAP_MIN_Y = 0;
            const int MAP_MAX_X = 15;
            const int MAP_MAX_Y = 10;

            // 플레이어의 초기 좌표
            const int INITIAL_PLAYER_X = 0;
            const int INITIAL_PLAYER_Y = 0;
            // 플레이어의 기호(string literal)
            const string PLAYER_STRING = "P";

            // 박스의 초기 좌표
            const int INITIAL_BOX_X = 5;
            const int INITIAL_BOX_Y = 5;
            // 박스의 기호(string literal)
            const string BOX_STRING = "B";


            // 플레이어 좌표 설정
            int playerX = INITIAL_PLAYER_X;
            int playerY = INITIAL_PLAYER_Y;
            Direction playerDirection = Direction.None;

            // 박스 좌표 설정
            int boxX = INITIAL_BOX_X;
            int boxY = INITIAL_BOX_Y;

            // 가로 15 세로 10
            // 게임 루프 == 프레임(Frame)
            while (true)
            {
                // 이전 프레임을 지운다.
                Console.Clear();

                // --------------------------------- Render -----------------------------------------
                // 플레이어 출력하기
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(PLAYER_STRING);

                // 박스 출력하기
                Console.SetCursorPosition(boxX, boxY);
                Console.Write(BOX_STRING);

                // --------------------------------- ProcessInput -----------------------------------------
                ConsoleKey key = Console.ReadKey().Key;

                // --------------------------------- Update -----------------------------------------
                // 플레이어 업데이트
                // 왼쪽 화살표 키를 눌렀을 떄
                if (key == ConsoleKey.LeftArrow)
                {
                    // 왼쪽으로 이동
                    playerX = Math.Max(MAP_MIN_X, playerX - 1);
                    playerDirection = Direction.Left;
                }

                // 오른쪽 화살표 키를 눌렀을 때
                if (key == ConsoleKey.RightArrow)
                {
                    playerX = Math.Min(playerX + 1, MAP_MAX_X);
                    playerDirection = Direction.Right;
                }

                // 위쪽 화살표 키를 눌렀을 때
                if (key == ConsoleKey.UpArrow)
                {
                    // 위로 이동
                    playerY = Math.Max(MAP_MIN_Y, playerY - 1);
                    playerDirection = Direction.Up;
                }

                // 아래쪽 화살표 키를 눌렀을 때
                if (key == ConsoleKey.DownArrow)
                {
                    // 아래로 이동
                    playerY = Math.Min(playerY + 1, MAP_MAX_Y);
                    playerDirection = Direction.Down;
                }

                // 박스 업데이트
                // 플레이어가 이동한 후
                if (playerX == boxX && playerY == boxY) // 플레이어가 이동하고나니 박스가 있네?
                {
                    // 박스를 움직여주면 됨.
                    switch (playerDirection)
                    {
                        case Direction.Left:
                            if (boxX == MAP_MIN_X)
                            {
                                playerX = MAP_MIN_X + 1;
                            }
                            else
                            {
                                boxX = boxX - 1;
                            }
                            break;
                        case Direction.Right:
                            if (boxX == MAP_MAX_X)
                            {
                                playerX = MAP_MAX_X - 1;
                            }
                            else
                            {
                                boxX = boxX + 1;
                            }
                            break;
                        case Direction.Up:
                            if (boxY == MAP_MIN_Y)
                            {
                                playerY = MAP_MIN_Y + 1;
                            }
                            else
                            {
                                boxY = boxY - 1;
                            }
                            break;
                        case Direction.Down:
                            if (boxY == MAP_MAX_Y)
                            {
                                playerY = MAP_MAX_Y - 1;
                            }
                            else
                            {
                                boxY = boxY + 1;
                            }
                            break;
                        default: //
                            Console.Clear();
                            Console.WriteLine($"[Error] 플레이어의 이동 방향이 잘못되었습니다. {playerDirection}");

                            return; // 프로그램 종료
                    }
                }
            }
        }
    }
}         break;
                  
                    case 4:
                       
                        BoxY = Math.Min(10, BoxY + 1);
                           
                    case 5:
                    
                        Console.Clear();
                        Console.WriteLine($"Error: it's wrong player move. {"playerDirection") // 디폴트는 예외 상황에서 처리하게됨
                        return;


               
}
            }


            }


            
        }
    }
}
