using System;
using ConsoleApplication1.Models;

namespace ConsoleApplication1
{
    internal static class Program
    {
        private static bool _run = true;
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to my game.");
                Console.WriteLine("This is a very simple and easy game. The name of this game is Amöba");
                Console.WriteLine("Please select a symbol(X or O(like Origo))");
                string symbol = Console.ReadLine() ?? throw new InvalidOperationException("You don't add symbol!");
                // if (symbol != "X" || symbol != "O")
                //     throw new Exception("Not valid symbol!");
                Table table = new Table(symbol);
                while (_run)
                {
                    // if (!Bot.WinSomeone())
                    // {
                    ShowMenuQuestions();
                    var menuOption = Convert.ToInt16(Console.ReadLine());
                    if (menuOption == 0 || menuOption > 4)
                        throw new Exception("Please select a number of menu!");
                    switch (menuOption)
                    {
                        case 1:
                            table.ShowActualTable();
                            break;
                        case 2:
                            Console.WriteLine("Give me position of number and value");
                            Console.WriteLine("Coordinate: ");
                            string position = Console.ReadLine();
                            table.SetCoordinates(position);
                            break;
                        case 3:
                            ShowSubMenuQuestions();
                            var subMenuOption = Convert.ToInt16(Console.ReadLine());
                            if (subMenuOption == 0 || subMenuOption > 2)
                                throw new Exception("Please select a number of submenu!");
                            switch (subMenuOption)
                            {
                                case 1:
                                    Console.Write("Press enter if you finish to read");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    break;
                            }
                            break;
                        case 4:
                            _run = false;
                            break;
                    }
                    // }
                    // else
                    // {
                    //     Console.WriteLine("Congratulation!");
                    // }
                };
            }
            catch (Exception e)
            {
                if (e is ArgumentException)
                {
                    Console.WriteLine("Just number!" + e);
                }
                else
                {
                    Console.WriteLine(e);
                }
                throw;
            }
        }

        private static void ShowMenuQuestions()
        {
            Console.WriteLine("Please give me the number of menu, what do you want to do!");
            Console.WriteLine("1: Show table");
            Console.WriteLine("2: Add new coordinate");
            Console.WriteLine("3: Information");
            Console.WriteLine("4: Close game");
        }

        private static void ShowSubMenuQuestions()
        {
            Console.WriteLine("Please give me the number of submenu.");
            Console.WriteLine("1: How to work this game?");
            Console.WriteLine("2: Back");
        }
    }
}