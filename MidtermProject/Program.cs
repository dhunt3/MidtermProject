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
            DateTime checkOutDate = customer1.CheckOut;
            DateTime returnDay = customer1.ReturnDate(checkOutDate);
            int amountofDaysLate  = customer1.DaysLate(returnDay);
            customer1.CustInfo();
            Console.WriteLine("You are: " + amountofDaysLate + " day(s) late");
            Console.ReadLine();
        }
    }
}
