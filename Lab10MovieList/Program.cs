using System;
using System.Collections.Generic;

namespace Lab10MovieList
{
    class Program
    {
        static void Main(string[] args)
        {   //greeting user
            Console.WriteLine("Welcome to MovieLand!");
            //created list of class Moive to store the data for title and category per movie
            List<Movie> filmList = new List<Movie>
            {
                new Movie("Titannic", "drama"),
                new Movie("Predator", "scifi"),
                new Movie("Apollo 11", "drama"),
                new Movie("The Notebook", "drama"),
                new Movie("Saw", "horror"),
                new Movie("Forest Gump", "drama"),
                new Movie("Saving Private Ryan", "horror"),
                new Movie("Get Out", "drama"),
                new Movie("Blade Runner", "scifi"),
                new Movie("Star Wars Christmas Special", "horror"),

            };

            bool userContinue = true;
            while (userContinue)
            {
                Console.WriteLine("Here are the genres: ");

                //printing the list if genres                
                Movie.PrintOutGenreTypes(filmList);

                string genreChoice = selectionCategory("Please choose pick a number for the desired genre");
                Movie.PrintOutFims(filmList, genreChoice);
                userContinue = UserSelection("Do you want to continue? please (y/n)", "y", "n");
            }
            Console.WriteLine("Thank you and don't forget to return your movie or do we do not care!");
        }



        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool UserSelection(string message, string trueChoice, string falseChoice)
        {
            string select = GetUserInput(message);

            if (select == trueChoice)
            {
                return true;
            }
            else if (select == falseChoice)
            {
                return false;
            }
            else
            {
                return UserSelection("Your entry is incorrect! " + message, trueChoice, falseChoice);
            }
        }

        public static string selectionCategory(string message)
        {
            string input = GetUserInput(message);
            if (input == "")
            {
                return selectionCategory("Nothing is nothing please enter something " + message);
            }
            else
            {
                int number = int.Parse(input);
                Console.WriteLine();

                if (number - 1 == 0)
                {
                    return "drama";
                }
                else if (number - 1 == 1)
                {
                    return "scifi";
                }
                else if (number - 1 == 2)
                {
                    return "horror";
                }

                else
                {
                    return selectionCategory("Invalid Entry! " + message);
                }
            }
        }
    }
}
