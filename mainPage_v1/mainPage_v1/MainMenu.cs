using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace mainPage_v1
{
    internal class MainMenu
    {
        public void start()
        {
            Title = "Cinema Rotterdam";
            RunMainMenu();





        }
        private void RunMainMenu()
        {
            string prompt = @"
   ___ ___ _  _ ___ __  __   _     ___  ___ _____ _____ ___ ___ ___   _   __  __ 
  / __|_ _| \| | __|  \/  | /_\   | _ \/ _ \_   _|_   _| __| _ \   \ /_\ |  \/  |
 | (__ | || .` | _|| |\/| |/ _ \  |   / (_) || |   | | | _||   / |) / _ \| |\/| |
  \___|___|_|\_|___|_|  |_/_/ \_\ |_|_\\___/ |_|   |_| |___|_|_\___/_/ \_\_|  |_|
                                                                                 

Welcome to the Cinema What would you like to do";
            string[] options = { "Seats", "Movies", "Reviews", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Seats();
                    break;
                case 1:
                    Movies();
                    break;
                case 2:
                    Reviews();
                    break;
                case 3:
                    Exit();
                    break;
                default:
                    break;
            }
        }


        private void Exit()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void Seats()
        {
            string prompt = "select your seat";
            string[] options = { "seat 1", "seat 2", "seat 3","Return to menu" };
            Menu seatMenu = new Menu(prompt, options);
            int selectedIndex = seatMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Clear();
                    WriteLine("You selected seat 1");
                    ReadKey(true);
                    Seats();
                    break;
                case 1:
                    Clear();
                    WriteLine("You selected seat 2");
                    ReadKey(true);
                    Seats();
                    break;
                case 2:
                    Clear();
                    WriteLine("You selected seat 3");
                    ReadKey(true);
                    Seats();
                    break;
                case 3:
                    RunMainMenu();
                    break;
                default:
                    break;
            }
        }


        private void Movies()
        {
            Clear();
            WriteLine("Hello this is Movies");
            ReadKey(true);
            RunMainMenu();
        }
        

        private void Reviews()
        {
            Clear();
            WriteLine("this is Reviews");
            ReadKey(true);
            RunMainMenu();
        }
    
    }

}
