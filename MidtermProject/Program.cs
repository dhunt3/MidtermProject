using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // We will add our main programs into our individual BRANCH copies of master.

            //this is part of Dorothy's branch off the master copy:

            Customer customer1 = new Customer("Doro Hunt", "2165268656", "CoraLiNe", new DateTime(2015, 09, 20));

            DateTime checkOutDate = customer1.CheckOut;     // created this DateTime object to hold the checkout date 
                                                            // from customer1 so that I can call the ReturnDay method.
            DateTime returnDay = customer1.ReturnDate(checkOutDate);    // Will return the return date and place it in
                                                                        // DateTime object called returnDay
            int amountofDaysLate  = customer1.DaysLate(returnDay);      // Calls the DaysLate method from Customer class and 
                                                                        // returns the number of days late from return date to today.
            //customer1.CustInfo();       // prints customer info

            string movieSelection = customer1.MovieSelection;
            
            List<string> movies = new List<string>() {"Avengers", "Pitch Perfect 2", "Cinderella", "Kill Bill", "The Matrix", 
            "Big Hero 6", "SpongeBob", "Identity Theft", "Coraline", "Bridesmaids"};

            Console.WriteLine("List of movies:");
            foreach (string item in movies)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            // Doro added this to help with ignoring of case
            if (movies.Contains(movieSelection, StringComparer.CurrentCultureIgnoreCase))       //checks to see if CoraLiNe is in movies (ignoring case)
            {
                customer1.CustInfo();   // print custInfo with movie info and date checked out.
                // the selector is going to be the index where CoraLiNe is located in movies (ignoring case)
                int selector = movies.FindIndex(index => index.Equals(movieSelection, StringComparison.CurrentCultureIgnoreCase));
                // will grab the movie that matches the input and place it in the movieSelector string. This is so
                // that the movie can be removed from the list based on how the movie is written in the list, not how it was inputed.
                string movieSelector = movies[selector];
                movies.Remove(movieSelector);
                Console.WriteLine("\n");

            }

            else
            {
                Console.WriteLine("We don't have that movie!" + "\n");     // If we don't have the movie
                customer1.NoMovieRented();      // Prints the NoMovieRented method that only prints custname and phone# + a message
                Console.WriteLine("\n");
            }

            foreach (string item in movies)
            {
                Console.WriteLine(item);
            }


            /*Console.WriteLine("You are: " + amountofDaysLate + " day(s) late");*/
            Console.ReadLine();
        }
    }
}
