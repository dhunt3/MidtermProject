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

            Customer customer1 = new Customer("Doro Hunt", "2165268656", "Movie Title", new DateTime(2015, 09, 20));

            DateTime checkOutDate = customer1.CheckOut;     // created this DateTime object to hold the checkout date 
                                                            // from customer1 so that I can call the ReturnDay method.
            DateTime returnDay = customer1.ReturnDate(checkOutDate);    // Will return the return date and place it in
                                                                        // DateTime object called returnDay
            int amountofDaysLate  = customer1.DaysLate(returnDay);      // Calls the DaysLate method from Customer class and 
                                                                        // returns the number of days late from return date to today.
            customer1.CustInfo();       // prints customer info

            Console.WriteLine("You are: " + amountofDaysLate + " day(s) late");
            Console.ReadLine();
        }
    }
}
