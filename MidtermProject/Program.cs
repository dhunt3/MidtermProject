using System;
using System.IO;
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
            // practice customers (hard-coded)
            Customer customer1 = new Customer("Doro Hunt", "21652686561234", "CoraLiNe", new DateTime(2015, 09, 20));
            Customer customer2 = new Customer("Shalamar Brown", "330542asdf", "avengers", new DateTime(2015, 10, 3));
            Customer customer3 = new Customer("Orlando Cruz", "2164215714", "Kill bill", new DateTime(2015, 10, 5));
            Customer customer4 = new Customer("Johnny Smith", "4406517985", "Halloweentown", new DateTime(2015, 09, 10));
            
            // user input for our 5th customer
            Console.WriteLine("Please enter your first and last name: ");
            string custName = Console.ReadLine();
            Console.WriteLine("Please enter your phone number: ");
            string phoneNum = Console.ReadLine();
            Console.WriteLine("Which movie would you like to check out?");
            string movieOption = Console.ReadLine();
            Customer customer5 = new Customer(custName, phoneNum, movieOption, DateTime.Now);

            // Created customerList so we can do following code to each individual customer
            List<Customer> customerList = new List<Customer>(); 
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);
            customerList.Add(customer5);
            
            // builder created to hold multiple strings
            StringBuilder builder = new StringBuilder();
            // writer created to write builder info into a txt file for customer summary
            StreamWriter writer = new StreamWriter("..\\..\\OverDueAccounts.txt");
            
            // list of movies
            List<string> movies = new List<string>() {"Avengers", "Pitch Perfect 2", "Cinderella", "Kill Bill", "The Matrix", 
            "Big Hero 6", "SpongeBob", "Identity Theft", "Coraline", "Bridesmaids"};
            
            // prints out the list of movies
            Console.WriteLine("List of movies:");
            foreach (string item in movies)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            // foreach loop will go through the customer list and execute the following code for individual customers in list
            foreach (Customer obj in customerList)
            {
                string movieSelection = obj.MovieSelection; // grabs the input movie selection for customer and assigns it to variable we can use in loop
                // Doro added this to help with ignoring of case
                if (movies.Contains(movieSelection, StringComparer.CurrentCultureIgnoreCase))       //checks to see if movie selection is in movies (ignoring case)
                {
                    // calls a method that will find the movie in the list by the inputed info (ignoring case) and removing it from movie list
                    obj.MovieSelectionMethod(movies, movieSelection);
                    DateTime checkOutDate = obj.CheckOut;     // created this DateTime object to hold the checkout date 
                                                              // from customers in list so that I can call the ReturnDay method.
                    DateTime returnDay = obj.ReturnDate(checkOutDate);    // Will return the return date and place it in
                                                                          // DateTime object called returnDay
                    //obj.CustInfo(builder);  // will call a method that will add the current customer's info to builder
                    //builder.Append("Return date: " + customer1.ReturnDate(checkOutDate));
                    //builder.AppendLine();

                    if (obj.IsLate(checkOutDate, returnDay) == true)    // calls a method that will check if customer is late
                    {
                        // this will help us print only the late accounts to the text file.
                        obj.CustInfo(builder);
                        builder.Append("Return date: " + customer1.ReturnDate(checkOutDate));
                        builder.AppendLine();
                        obj.PrintLate(builder, returnDay);  // if customer is late, add to builder their overdue info (days late and how much they owe)
                    }
                    else
                    {
                        // if customer is not late do this else block
                        //builder.Append("Customer has no overdue information.");
                        //builder.AppendLine();
                        Console.WriteLine("Customer has no overdue information" + "\n");
                    }

                }

                else
                {   // if the movie is not in the movies list do this else block
                    Console.WriteLine("We don't have that movie!" + "\n");     // If we don't have the movie
                    //obj.NoMovieRented(builder);      // Prints the NoMovieRented method that only prints custname and phone# + a message
                    //builder.AppendLine();
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine("List of movies: ");
            foreach (string item in movies)
            {
                Console.WriteLine(item);
            }

            using (writer)
            {
                writer.WriteLine(builder);
            }
            Console.ReadLine();
        }
    }
}
