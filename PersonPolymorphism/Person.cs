using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public abstract class Person : User
    {
        #region Fields
        protected string firstname;
        protected string lastnames;      
        protected string ssn;


        #endregion


        #region Constructor
        public Person(string username, string password, string firstname, string lastnames, string ssn) : base(username, password)
        {
            Firstname = firstname;
            Lastnames = lastnames;
            Ssn = ssn;
        }
        #endregion


        #region Properties
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastnames
        {
            get { return lastnames; }
            set { lastnames = value; }
        }
        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }
        #endregion


        #region Methods
        private bool IsSsnValid(out string errorType)
        {
            string pattern = @"^ (? !(000 | 666 | 9))\d{ 3}-(? !00)\d{ 2}-(? !0000)\d{ 4}$";
            bool valid = false;

            if (String.IsNullOrWhiteSpace(ssn))
            {
                errorType = "Something went wrong";
                throw new ArgumentException();
            }
            else if (password.Length < 10)
            {
                
                errorType = "Snn is too short, please try again.";
            }

            else if (Regex.IsMatch(ssn,pattern)) 
            {
                errorType = String.Empty;
                valid = true;
            }
            else
            {
                errorType = "unknow error";
            }

            return valid;
        }
        #endregion


    }
}
