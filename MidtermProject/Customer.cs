﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Customer
    {
        // Add fields we agreed upon. Will be displayed in master copy.
        public string custName;
        public string phoneNum;
        public string movieSelection;
        public DateTime checkOut;


        // Add properties we agreed upon. Will be displayed in master copy.
        public string CustName
        {
            get
            {
                return this.custName;
            }
            set
            {
                this.custName = value;
            }
        }

        public string PhoneNum
        {
            get
            {
                // Doro added this formatting option. This will help catch input that is not convertable to numbers.
                    string number = String.Format("{0:(###)###-####}", ulong.Parse(phoneNum));
                    return number;
                    throw new Exception();  //String.Format("Invalid number")
           
            }
            set
            {
                this.phoneNum = value;
            }
        }

        public string MovieSelection
        {
            get
            {
                return this.movieSelection;
            }
            set
            {
                this.movieSelection = value;
            }
        }

        public DateTime CheckOut
        {
            get
            {
                return this.checkOut;
            }
            set
            {
                this.checkOut = value;
            }
        }

        // Possible Customer Constructor. Created under Dorothy's branch:
        public Customer(string custname, string phonenumber, string movie, DateTime checkoutDate)
        {
            this.CustName = custname;
            this.PhoneNum = phonenumber;
            this.MovieSelection = movie;
            this.CheckOut = checkoutDate;
        }

        // We will add our methods into our BRANCH copies of master.
        public void CustInfo()      // Shalamar's printing method. I added the try-catch blocks.
        {
            Console.WriteLine(CustName);
            try
            {                               // try method will print the phone number with format (###)###-#### 
                                            // so long as the string of phoneNum are convertable numbers (to ulong).
            Console.WriteLine(PhoneNum);
            }
            catch (Exception pn)
            {                               // Will print an error on the screen if the inputed phoneNum does not contain
                                            // all convertable numbers. (ex: (216)526-asdf is incorrect. Cannot convert asdf to numbers
                Console.WriteLine("Error: " + pn.Message);
            }
            Console.WriteLine(MovieSelection);
            Console.WriteLine("Movie checked out: " + CheckOut);
        }
        public DateTime ReturnDate(DateTime checkoutDate)       // method to figure out return date from checkout date
        {
            DateTime returnDate = checkoutDate.AddDays(7);
            return returnDate;
        }

        public int DaysLate(DateTime returnDate)        // method to figure out how late the movie is (in relation to today
                                                        // and it's return date.
        {
            DateTime today = DateTime.Now;
            TimeSpan amountOfDays = today.Subtract(returnDate);
            return Convert.ToInt32(amountOfDays.TotalDays);
        }
    }
}
