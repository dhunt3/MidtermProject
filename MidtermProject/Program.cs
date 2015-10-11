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

            Customer customer1 = new Customer("Doro Hunt", "2165268656", "CoraLiNe", new DateTime(2015, 09, 20));
            Customer customer2 = new Customer("Shalamar Brown", "3305426570", "avengers", new DateTime(2015, 10, 3));
            Customer customer3 = new Customer("Orlando Cruz", "2164215714", "Kill bill", new DateTime(2015, 10, 5));
            Customer customer4 = new Customer("Johnny Smith", "4406517985", "Halloweentown", new DateTime(2015, 09, 10));
            
            Console.WriteLine("Please enter your first and last name: ");
            string custName = Console.ReadLine();
            Console.WriteLine("Please enter your phone number: ");
            string phoneNum = Console.ReadLine();
            Console.WriteLine("Which movie would you like to check out?");
            string movieOption = Console.ReadLine();
            Customer customer5 = new Customer(custName, phoneNum, movieOption, DateTime.Now);
            
            List<Customer> customerList = new List<Customer>();
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);
            customerList.Add(customer5);
            
            StringBuilder builder = new StringBuilder();
            StreamWriter writer = new StreamWriter("..\\..\\OverDueAccounts.txt");
            
            List<string> movies = new List<string>() {"Avengers", "Pitch Perfect 2", "Cinderella", "Kill Bill", "The Matrix", 
            "Big Hero 6", "SpongeBob", "Identity Theft", "Coraline", "Bridesmaids"};

            Console.WriteLine("List of movies:");
            foreach (string item in movies)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            foreach (Customer obj in customerList)
            {
                string movieSelection = obj.MovieSelection;
                // Doro added this to help with ignoring of case
                if (movies.Contains(movieSelection, StringComparer.CurrentCultureIgnoreCase))       //checks to see if CoraLiNe is in movies (ignoring case)
                {

                    obj.MovieSelectionMethod(movies, movieSelection);
                    DateTime checkOutDate = obj.CheckOut;     // created this DateTime object to hold the checkout date 
                    // from customer1 so that I can call the ReturnDay method.
                    DateTime returnDay = obj.ReturnDate(checkOutDate);    // Will return the return date and place it in
                    // DateTime object called returnDay
                    obj.CustInfo(builder);
                    builder.Append("Return date: " + customer1.ReturnDate(checkOutDate));
                    builder.AppendLine();

                    if (obj.IsLate(checkOutDate, returnDay) == true)
                    {
                        obj.PrintLate(builder, returnDay);
                    }
                    else
                    {
                        builder.Append("Customer has no overdue information.");
                        builder.AppendLine();
                    }

                }

                else
                {
                    Console.WriteLine("We don't have that movie!" + "\n");     // If we don't have the movie
                    obj.NoMovieRented(builder);      // Prints the NoMovieRented method that only prints custname and phone# + a message
                    builder.AppendLine();
                    Console.WriteLine("\n");
                }
            }

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
