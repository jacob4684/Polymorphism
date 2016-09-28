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
        public Employee(string username, string password) : base(username, password)
        {
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
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
