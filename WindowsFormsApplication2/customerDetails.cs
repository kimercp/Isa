using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAManagment
{
    class customerDetails
    {     
        // customer id number keeps as a string
        private string custid;
        private string title;
        private string firstname;
        private string lastname;
        private DateTime dob;
        private string natins;
        private string email;
        private string pswd;
        private double allowance;
        
        // constructor
        public customerDetails() {}

        // setters
        public void setCustomerID(string custid)
        {
            this.custid = custid;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setFirstName(string firstname)
        {
            this.firstname = firstname;
        }

        public void setLastName(string lastname)
        {
            this.lastname = lastname;
        }

        public void setDob(DateTime dob)
        {
            this.dob = dob;
        }

        public void setNationalInsurance(string natins)
        {
            this.natins = natins;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setPassword(string pswd)
        {
            this.pswd = pswd;
        }

        public void setAllowance(double allowance)
        {
            this.allowance = allowance;
        }

        // getters
        public string getCustomerID()
        {
            return custid;
        }

        public string getTitle()
        {
            return title;
        }

        public string getFirstName()
        {
            return firstname;
        }

        public string getLastName()
        {
            return lastname;
        }

        public DateTime getDob()
        {
            return dob;
        }

        public string getNationalInsurance()
        {
            return natins;
        }

        public string getEmail()
        {
            return email;
        }

        public string getPassword()
        {
            return pswd;
        }

        public double getAllowance()
        {
            return allowance;
        }
   }    
}
