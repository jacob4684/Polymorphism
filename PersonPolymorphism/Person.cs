using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class Person : User
    {
        #region Fields
        protected string firstname;
        protected string lastnames;      
        protected object ssn;
        #endregion


        #region Constructor
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
        public object Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }
        #endregion


        #region Methods
        private bool IsSsnValid(out string errorType)
        {
            throw new System.NotImplementedException();
        }
        #endregion


    }
}
