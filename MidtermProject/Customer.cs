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
                return this.PhoneNum;
            }
            set
            {
                this.PhoneNum = value;
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

        // We will add our methods into our BRANCH copies of master.
    }
}
