using System;

namespace WondersOfTheWorld
{
    internal class program
    {
        static void Main()
        {
            ConsoleKeyInfo input = default(ConsoleKeyInfo);
            while (input.Key != ConsoleKey.Q)
            {
                Console.Write("Введите чудо света которое хотите увидеть(1-7)(q = выход)");
                input = Console.ReadKey();
                Console.Clear();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Wonders.Wonder won = new Wonders.Wonder_1();
                        won.Print();
                        break;
                    case ConsoleKey.D2:
                        Wonders.Wonder won1 = new Wonders.Wonder_2();
                        won1.Print();
                        break;
                    case ConsoleKey.D3:
                        Wonders.Wonder won2 = new Wonders.Wonder_3();
                        won2.Print();
                        break;
                    case ConsoleKey.D4:
                        Wonders.Wonder won3 = new Wonders.Wonder_4();
                        won3.Print();
                        break;
                    case ConsoleKey.D5:
                        Wonders.Wonder won4 = new Wonders.Wonder_5();
                        won4.Print();
                        break;
                    case ConsoleKey.D6:
                        Wonders.Wonder won5 = new Wonders.Wonder_6();
                        won5.Print();
                        break;
                    case ConsoleKey.D7:
                        Wonders.Wonder won6 = new Wonders.Wonder_7();
                        won6.Print();
                        break;
                    case ConsoleKey.D8:
                        Wonders.Wonder won7 = new Wonders.Wonder_8();
                        won7.Print();
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("Пока!");
                        break;
                    default:
                        Console.WriteLine("Таких чудес пока не существует :)");
                        break;
                }
            }
           
        }
    }
}