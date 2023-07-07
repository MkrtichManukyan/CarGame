using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarGame
{
    internal class Car
    {
        int carCordinat = 10;
        int Height = 20;
        int Width = 20;
        int gameShans = 3;
        int endGame = 0;

        public void Road()
        {
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, 1); 
                Console.Write("-");
            }

            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, (Height + 2));
                Console.Write("-");
            }

            for (int i = 1; i <= (Height + 1); i++)
            {
                if (i == carCordinat)
                {
                    Console.SetCursorPosition(i, (15));
                    Console.WriteLine("car");
                }
                Console.SetCursorPosition(1, i); 
                Console.Write("-");
            }

            for (int i = 1; i <= (Height+ 1); i++)
            {
                Console.SetCursorPosition((Width+2), i);
                Console.Write("-");
            }
        }

    public void Input()
        {
            bool isPlaying = true;
            Console.WriteLine("Barigalust Car Game!");
            Console.WriteLine("Sexmeq Q durs galu hamar");
            Road();

            while (isPlaying)
            {

                if (endGame >= 60)
                {
                    isPlaying = false;
                    Console.Clear();
                    Console.WriteLine("duq haxteciq))");
                    break;
                }
                else
                {
                    endGame++;
                    Console.WriteLine(endGame);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                ConsoleKey key = keyInfo.Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        carCordinat--;
                        if (carCordinat < 2)
                        {
                            carCordinat = 10;
                            gameShans--;
                            Console.WriteLine("duq durs ekaq dashtic duq uneq {0} porc", gameShans);
                            Road();

                            if (gameShans == 0)
                            {
                                isPlaying = false;
                                Console.Clear();
                                Console.WriteLine("duq partveciq((");
                            }
                        }
                        else
                        {
                            Road();
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        carCordinat++;
                        if (carCordinat > 19)
                        {
                            carCordinat = 10;
                            gameShans--;
                            Console.WriteLine("duq durs ekaq dashtic duq uneq {0} porc", gameShans);
                            Road();

                            if (gameShans == 0)
                            {
                                isPlaying = false;
                                Console.Clear();
                                Console.WriteLine("duq partveciq((");
                            }
                        }
                        else
                        {
                            Road();
                        }
                        break;

                    case ConsoleKey.Q:
                        Console.Clear();
                        Console.WriteLine("Xax@ dadarecvec...");
                        isPlaying = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("duq sexmel eq anvaver kojak");
                        Road();
                        break;
                }
            }
        }
    }
}