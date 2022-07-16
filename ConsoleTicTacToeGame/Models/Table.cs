using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace ConsoleTicTacToeGame.Models
{
    public class Table
    {
        private static string _selectedSymbol;
        private static string _aiSymbol;
        private readonly Bot _bot;
        private readonly Dictionary<string, string> _mappedPositons = new Dictionary<string, string>();
        private static Dictionary<string, string> _usedPositons = new Dictionary<string, string>();

        public static string AiSymbol
        {
            get => _aiSymbol;
            set => _aiSymbol = value;
        }

        public static string SelectedSymbol
        {
            get => _selectedSymbol;
            set => _selectedSymbol = value;
        }
        
        public static Dictionary<string, string> UsedPositons
        {
            get => _usedPositons;
            set => _usedPositons = value;
        }

        public Table(string selectedSymbol)
        {
            _selectedSymbol = selectedSymbol;
            _aiSymbol = "O";
            if (_selectedSymbol == "O")
                _aiSymbol = "X";
            PositionMapper();
            _bot = new Bot();

        }

        public void ShowActualTable()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"|        {_mappedPositons["1"]}        |        {_mappedPositons["2"]}        |        {_mappedPositons["3"]}        |");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"|        {_mappedPositons["4"]}        |        {_mappedPositons["5"]}        |        {_mappedPositons["6"]}        |");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"|        {_mappedPositons["7"]}        |        {_mappedPositons["8"]}        |        {_mappedPositons["9"]}        |");
            Console.WriteLine("-------------------------------------------------------");
        }

        private void PositionMapper()
        {
            _mappedPositons.Add("1", "1");
            _mappedPositons.Add("2", "2");
            _mappedPositons.Add("3", "3");
            _mappedPositons.Add("4", "4");
            _mappedPositons.Add("5", "5");
            _mappedPositons.Add("6", "6");
            _mappedPositons.Add("7", "7");
            _mappedPositons.Add("8", "8");
            _mappedPositons.Add("9", "9");
        }

        public void SetCoordinates(string coordinate)
        {
            if (CheckCoordinateUsed(coordinate))
            {
                Console.WriteLine("This coordinate isn't free!");
                return;
            }
            if (!_mappedPositons.ContainsKey(coordinate))
            {
                Console.WriteLine("Not found this coordinate!");
                return;
            }
            if (!(_mappedPositons).TryGetValue(coordinate, out var position))
            {
                Console.WriteLine("Not found value!");
                return;
            }
            _usedPositons.Add(position, _selectedSymbol);
            _mappedPositons[position] = _selectedSymbol;
            _bot.BotResponse();
        }
    
        private bool CheckCoordinateUsed(string key)
        {
            return _usedPositons.ContainsKey(key);
        }
    }
}