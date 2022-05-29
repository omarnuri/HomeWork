using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViktorinaProjectUser
{
    internal class Scroll
    {
		public List<string> ScrollElem = new();
		public int Start(List<string>ScrollElem)
		{
			char choice = (char)0;
			int down = 4, up = 0;
			for (int i = 0; true;)
			{
				if (choice == 13)
				{
					Console.Clear();
					return i;
				}
				else if (choice == 'w' || choice == 'W' || choice == 's' || choice == 'S' || choice == 0)
				{
					Console.Clear();
					for (int j = 0; j <= down && j < ScrollElem.Count; j++)
					{
						if (i > down)
						{
							down += i - down;
							up = down - 4;
						}
						if (i < up)
						{
							up -= up - i;
							down = up + 4;
						}
						else if (i < up)
						{
							down--;
							up--;
						}
						if (j >= up)
						{
							if (j == i)
							{
								Console.ForegroundColor = ConsoleColor.Black;

								Console.BackgroundColor = ConsoleColor.White;


							}
							Console.WriteLine($"#{j + 1} {ScrollElem[j]}");
							Console.ForegroundColor = ConsoleColor.White;
							Console.BackgroundColor = ConsoleColor.Black;

						}

					}
				}

				choice = (char)1;
				choice = Console.ReadKey(true).KeyChar;
				if (choice == 'q' || choice == 'Q')
				{
					Console.ForegroundColor = ConsoleColor.Red;

					Console.Clear();

					string text = ("Завершение программы!");
                    foreach (var item in text)
                    {
						Thread.Sleep(100);
                        Console.Write(item);
                    }
					Console.ForegroundColor = ConsoleColor.White;
					Environment.Exit(0);
				}
				else if (choice == 'w' || choice == 'W')
				{
					i--;
				}
				else if (choice == 's' || choice == 'S')
				{

					i++;
				}
				if (i == -1)
				{
					i = ScrollElem.Count - 1;
				}
				else if (i == ScrollElem.Count)
				{
					i = 0;
				}
			}

		}//Извините, но я украл этот код из своего предыдущего кода, который я показал на экзамене в c++ и переделал, такой полиморфизм меня устраивает :D
	}
} 