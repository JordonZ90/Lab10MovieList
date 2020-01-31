using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10MovieList
{
    class Movie
    {
        //fields
        private string name;
        private string category;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        //constructors
        public Movie() { }

        public Movie(string _name, string _category)
        {
            name = _name;
            category = _category;
        }

        //methods

        private static List<string> GetListOfGenreType(List<Movie> genreType)//Get the list of categories 
        {
            List<string> genre = new List<string>();
            foreach (Movie name in genreType)
            {
                if (!genre.Contains(name.category))
                {
                    genre.Add(name.category);
                }
            }
            return genre;
        }
        public static void PrintOutGenreTypes(List<Movie> movieType)
        {
            //Printing out the genres
            List<string> genreType = GetListOfGenreType(movieType);

            for (int i = 0; i < genreType.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {genreType[i]}");
            }
            Console.WriteLine();

        }
        public static List<string> GetListOfMovies(List<Movie> moviesCategory, string selection)
        {
            //Getting the list of movies
            List<string> moviesList = new List<string>();

            foreach (Movie film in moviesCategory)
            {
                if (film.category == selection)
                {
                    moviesList.Add(film.name);
                }
            }
            return moviesList;
        }

        public static void PrintOutFims(List<Movie> filmList, string choice)
        {
            // Printing out the movies
            List<string> printFilms = GetListOfMovies(filmList, choice);
            printFilms.Sort();
            Console.WriteLine($"The list of {choice} movies are: ");
            for (int i = 0; i < printFilms.Count; i++)
            {
                Console.WriteLine($"{printFilms[i]}");
            }

        }

    }
}
