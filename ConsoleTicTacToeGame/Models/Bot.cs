using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTicTacToeGame.Models
{
    public class Bot
    {
        private Dictionary<string, string> _actualGameState;
        private Dictionary<string, string> _actualUserCoordinates;
        private Dictionary<string, string> _actualBotCoordinates;
        private Dictionary<string, string[]> _wins;

        public Bot()
        {
            _wins = new Dictionary<string, string[]>
            {
                {"1", new string[] {"1","2","3"}},
                {"2", new string[] {"4","5","6"}},
                {"3", new string[] {"7","8","9"}},
                {"4", new string[] {"1","5","9"}},
                {"5", new string[] {"3","5","7"}},
                {"6", new string[] {"1","4","7"}},
                {"7", new string[] {"2","5","8"}},
                {"8", new string[] {"3","6","9"}}
            };
        }

        public void BotResponse()
        {
            Dictionary<string, string>  _actualUserCoordinates = new Dictionary<string, string>();
            Dictionary<string, string>  _actualBotCoordinates = new Dictionary<string, string>();
            Dictionary<string, string>  _actualGameState = Table.UsedPositons;
            foreach (var usedCoordiante in _actualGameState)
            {
                if (usedCoordiante.Value == Table.SelectedSymbol)
                {
                    _actualUserCoordinates.Add(usedCoordiante.Key, usedCoordiante.Value);
                }
                else
                {
                    _actualBotCoordinates.Add(usedCoordiante.Key, usedCoordiante.Value);
                }
            }
            
            var sortedUserCoordinates = _actualUserCoordinates.OrderBy(x => x.Key);
            var sortedBotCoordinates = _actualBotCoordinates.OrderBy(x => x.Key);
        }

        public static bool WinSomeone()
        {
            return true;
        }
    }
}