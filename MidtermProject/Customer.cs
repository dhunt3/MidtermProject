using System;
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
                return this.phoneNum;
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
        public void CustInfo()
        {
            Console.WriteLine(CustName);
            Console.WriteLine(PhoneNum);
            Console.WriteLine("Movie checked out: " + MovieSelection);
            Console.WriteLine(CheckOut);
        }
        public DateTime ReturnDate(DateTime checkoutDate)
        {
            DateTime returnDate = checkoutDate.AddDays(7);
            return returnDate;
        }

        public int DaysLate(DateTime returnDate)
        {
            DateTime today = DateTime.Now;
            TimeSpan amountOfDays = today.Subtract(returnDate);
            return Convert.ToInt32(amountOfDays.TotalDays);
        }
    }
}
