using MovieLibrary.Models;

namespace MovieLibrary
{
    public interface IMenu
    {
        bool IsValid { get; set; }

        char GetMainMenuSelection();
        Movie GetMovieDetails();
        void Process(char userSelection);
    }
}