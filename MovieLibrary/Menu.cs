using System;
using System.Collections.Generic;
using ConsoleTables;
using MovieLibrary.Data;
using MovieLibrary.Models;

namespace MovieLibrary
{

    public class Menu : IMenu
    {
        private readonly char _exitKey = 'X';
        private readonly List<char> _validChoices = new List<char> { '1', '2' };
        private IContext _context;

        public Menu(IContext context) // default constructor
        {
            _context = context;

            DisplayMenu();
        }

        public bool IsValid { get; set; }

        private void DisplayMenu()
        {
            Console.WriteLine("1. List movies");
            Console.WriteLine("2. Add Movie to list");
        }

        public char GetMainMenuSelection()
        {
            IsValid = true;

            Console.Write($"Select ({string.Join(',', _validChoices)},{_exitKey})> ");
            var key = Console.ReadKey().KeyChar;
            while (!_validChoices.Contains(key))
            {
                if (key == _exitKey || char.ToLower(key) == char.ToLower(_exitKey))
                {
                    IsValid = false;
                    break;
                }

                Console.WriteLine();
                Console.Write("Invalid, Please ");
                Console.Write($"Select ({string.Join(',', _validChoices.ToArray())},{_exitKey})> ");
                key = Console.ReadKey().KeyChar;
            }

            return key;
        }

        public Movie GetMovieDetails(Title title Genres genres)
        {   
            return new Movie { Title = "Pasific Rim", Genres = "Action" };
        }

        public void Process(char userSelection)
        {
            switch (userSelection)
            {
                case '1':                  
                    Console.WriteLine();
                    ConsoleTable.From<Movie>(_context.GetMovies()).Write();
                    break;
                case '2':       
                    var movie = GetMovieDetails();
                    _context.AddMovie(movie);
                    Console.WriteLine($"\nYour movie has been added!\n");
                    break;
            }
        }
    }
}