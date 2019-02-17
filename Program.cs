using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


// width 50 height = 40


namespace Snake_V0._3
{
    class Snake
    {
        public int HeadX;
        public int HeadY;

    }
    class Program
    {
        static List<Snake> Parts = new List<Snake>();

        static bool IsEndGame;
        static bool IsEaten = true;
        static int FoodX, FoodY;
        static int HeadX, HeadY, TempX, TempY;
        static int FoodTempX, FoodTempY;
        static int Points;
        static string Direction;


        static void Main(string[] args)
        {
            ShowMenu();
        }
        static void ShowMenu()
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(50,40);
            Console.WriteLine("##################################################");
            Console.WriteLine("#                                                #");
            Console.WriteLine("#            Snake by Kacper Gendosz             #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("#                      Menu                      #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("#                  1. New Game                   #");
            Console.WriteLine("#                  0. Exit                       #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("##################################################");
            ConsoleKey choice = ConsoleKey.Enter;
            while (!IsEndGame)
            {
                if (Console.KeyAvailable)
                {
                    choice = Console.ReadKey(true).Key;
                    switch (choice)
                    {

                        case ConsoleKey.D1:
                            NewGame();
                            break;
                        case ConsoleKey.D0:
                            Console.WriteLine("Good Bye");
                            Thread.Sleep(500);
                            break;
                        default:
                            continue;
                    }
                    break;
                }
               
            }


        }
        static void PrintBorder()
        {
            Console.Clear();
            for (int i = 0; i < 50; i++)
            {
                Console.Write("#");
            }
            for (int i = 1; i < 30; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("#");
                Console.SetCursorPosition(49, i);
                Console.Write("#");
            }
            Console.WriteLine();
            for (int i = 0; i < 50; i++)
            {
                Console.Write("#");
            }
            Console.SetCursorPosition(25, 15);
        }
        static void NewGame()
        {
            Parts.Clear();
            IsEaten = true;
            IsEndGame = false;
            PrintBorder();
            Movement();
        }
        static void Movement()
        {
            ConsoleKey direction = Console.ReadKey(true).Key;
            ConsoleKey tempDir = direction;
            HeadX = Console.CursorLeft;
            HeadY = Console.CursorTop;

            Points = 0;
            Snake TempSnake = new Snake();
            TempSnake.HeadX = HeadX;
            TempSnake.HeadY = HeadY;
            Parts.Add(TempSnake);
            Parts.Add(TempSnake);

            Direction = " ";

            while (!IsEndGame)
            {
                TempX = HeadX;
                TempY = HeadY;

                Food();

                if (Colisions())
                {
                    ShowMenu();
                    return;
                }
               

                if (Console.KeyAvailable)
                {
                    direction = Console.ReadKey(true).Key;
                }
                switch (direction)
                {
                    
                    case ConsoleKey.Escape:
                        ShowMenu();
                        return;
                    case ConsoleKey.LeftArrow:
                        if (Direction!="right")
                        {
                            Direction = "left";
                            HeadX--;
                        }
                        else
                        {
                            direction = ConsoleKey.RightArrow;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Direction != "down")
                        {
                            Direction = "up";
                            HeadY--;
                        }
                        else
                        {
                            direction = ConsoleKey.DownArrow;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Direction != "left")
                        {
                            Direction = "right";
                            HeadX++;
                        }
                        else
                        {
                            direction = ConsoleKey.LeftArrow;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Direction != "up")
                        {
                            Direction = "down";
                            HeadY++;
                        }
                        else
                        {
                            direction = ConsoleKey.UpArrow;
                        }
                        break;
                    case ConsoleKey.P:
                        
                        break;
                    default:
                        direction = tempDir;
                        continue;
                }
                Parts[Parts.Count - 1].HeadX = HeadX;
                Parts[Parts.Count - 1].HeadY = HeadY;
                
                
                    for (int i = 0; i < Parts.Count - 1; i++)
                    {
                        Parts[i].HeadX = Parts[i + 1].HeadX;
                        Parts[i].HeadY = Parts[i + 1].HeadY;
                    }
                
                print();
                Thread.Sleep(100);

            }
            

        }
       
        static void Food()
        {
            if (IsEaten==true)
            {
                Random Rand = new Random();
                FoodX = Rand.Next(1, 49);
                FoodY = Rand.Next(1, 30);
                FoodTempX = Console.CursorLeft;
                FoodTempY = Console.CursorTop;
                Console.SetCursorPosition(FoodX,FoodY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(FoodTempX, FoodTempY);
                IsEaten = false;
            }


        }
        static bool Colisions()
        {
            //with food 
            if (HeadX==FoodX&&HeadY==FoodY)
            {
                Snake NewHead = new Snake();
                NewHead.HeadX = HeadX;
                NewHead.HeadY = HeadY;
                Parts.Add(NewHead);
                Points++;
                IsEaten = true;
                return false;
               
            }
            //with border 
            if (HeadX == 0||HeadX==49||HeadY==0||HeadY==30)
            {

                return true;
                
            }
            //with body
            //for (int i = 1; i < Parts.Count-2 ; i++)
            //{
            //    if (HeadX==Parts[i].HeadX||HeadY==Parts[i].HeadY)
            //    {
            //        return true;
            //    }
            //}
            return false;
        }



        //------------------------
        static void print()
        {
            for (int i = Parts.Count-1; i >0; i--)
            {
                Console.SetCursorPosition(Parts[i].HeadX,Parts[i].HeadY);
                Console.Write("O");
                Console.SetCursorPosition(Parts[i].HeadX, Parts[i].HeadY);
            }
            if (Points==0)
            {
                Console.SetCursorPosition(TempX, TempY);
                Console.Write(" ");
            }
            else
            {
                Console.SetCursorPosition(Parts[0].HeadX, Parts[0].HeadY);
                Console.Write(" ");

            }
        }    // to change
        //------------------------
    }
}
