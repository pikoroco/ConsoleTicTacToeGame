using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTicTacToeGame.Models
{
    public class Bot
    {
        private Dictionary<string, string> actualGameState;
        private SortedDictionary<string, string> actualUserCoordinates;
        private SortedDictionary<string, string> actualBotCoordinates;
        private Dictionary<string, string[]> wins;

        public Bot()
        {
            this.wins = new Dictionary<string, string[]>
            {
                {"1", new string[] {"1","2","3"}},
                {"2", new string[] {"1","4","7"}},
                {"3", new string[] {"1","5","9"}},
                {"4", new string[] {"2","5","8"}},
                {"5", new string[] {"3","5","7"}},
                {"6", new string[] {"3","6","9"}},
                {"7", new string[] {"4","5","6"}},
                {"8", new string[] {"7","8","9"}},
            };
        }

        public void BotResponse()
        {
            this.actualUserCoordinates = new SortedDictionary<string, string>();
            this.actualBotCoordinates = new SortedDictionary<string, string>();
            this.actualGameState = Table.UsedPositons;
            foreach (var usedCoordiante in this.actualGameState)
            {
                if (usedCoordiante.Value == Table.SelectedSymbol)
                {
                    this.actualUserCoordinates.Add(usedCoordiante.Key, usedCoordiante.Value);
                }
                else
                {
                    this.actualBotCoordinates.Add(usedCoordiante.Key, usedCoordiante.Value);
                }
            }

            CheckPositionIsFree(this.actualUserCoordinates, this.actualBotCoordinates);
        }

        public static bool WinSomeone()
        {
            return true;
        }

        private bool CheckPositionIsFree(SortedDictionary<string, string> sortedUserCoordinates, SortedDictionary<string, string> sortedBotCoordinates)
        {
            Console.WriteLine(sortedUserCoordinates);
            foreach (var win in this.wins)
            {
                Console.WriteLine("____");
                Console.WriteLine(win.Key);
                Console.WriteLine(win.Value.Contains("2"));
                Console.WriteLine("----");
                //if (sortedusercoordinates.containskey())
                //{
                //    return true;
                //}
            }
            return false;
        }
    }
}