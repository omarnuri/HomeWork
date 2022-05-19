using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViktorinaProjectUser
{
    internal class Application
    {
        public static void Start()
        {

            RegistrationAndSignin registrationAndSignin = new();
            Scroll MainMenu = new();
            int choice = 0;
            MainMenu.ScrollElem.Add("Регистрация");
            MainMenu.ScrollElem.Add("Вход");
            choice = MainMenu.Start(MainMenu.ScrollElem);
            Scroll UserMainMenu = new();
            UserMainMenu.ScrollElem.Add("Играть");
            UserMainMenu.ScrollElem.Add("Настройки");
            Scroll Games = new();
            foreach (var item in GameModes.Games)
            {
                Games.ScrollElem.Add(item);
            }

            switch (choice)
            {
                case 0:
                    registrationAndSignin.Registration();
                    Thread.Sleep(1000);
                    choice = MainMenu.Start(MainMenu.ScrollElem);
                    break;
                case 1:
                    registrationAndSignin.Signin();
                    Thread.Sleep(1000);
                    choice = MainMenu.Start(UserMainMenu.ScrollElem);
                    break;

                default:
                    break;

            }

            switch (choice)
            {
                case 0:
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("");
                    break;

                default:
                    break;

            }

            switch (choice)
            {
                case 0:
                    Games.Start(Games.ScrollElem);
                    break;
                case 1:
                    Console.WriteLine("");
                    break;

                default:
                    break;

            }


        }
    }
}
