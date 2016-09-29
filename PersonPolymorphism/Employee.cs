using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class Employee : Person
    {
        #region Fields
        protected decimal baseSalary;
        protected decimal christmasBonus;

        #endregion


        #region Constructor
        public Employee(string username, string password, string firstname, string lastnames, object ssn, decimal christmasBonus, decimal baseSalary) : base(username, password, firstname, lastnames, ssn)
        {
            ChristmasBonus = christmasBonus;
            BaseSalary = baseSalary;
        }
        #endregion


        #region Properties
        public decimal ChristmasBonus
        {
            get { return christmasBonus; }
            set { christmasBonus = value; }
        }
        public decimal BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }
        #endregion


        #region Methods
        
        public virtual decimal GetYearlySalary()
        {
            decimal monthInAYear = 12;
            decimal yearlySalary = baseSalary * monthInAYear + christmasBonus;
            return yearlySalary;
        }
        #endregion
    }
}
