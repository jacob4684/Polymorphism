using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class AdministrativeEmployee : Employee
    {
        #region Fields
        protected byte payLevel;
        protected double yearlyRisePercent;




        #endregion
        public AdministrativeEmployee(string username, string password, string firstname, string lastnames, object ssn, decimal christmasBonus, decimal baseSalary, byte payLevel, double yearlyRisePercent) : base(username, password, firstname, lastnames, ssn, christmasBonus, baseSalary)
        {
            PayLevel = payLevel;
            YearlyRisePercent = yearlyRisePercent;
        }

        #region Constructor

        #endregion


        #region Properties

        public byte PayLevel
        {
            get { return payLevel; }
            set { payLevel = value; }
        }
        public double YearlyRisePercent
        {
            get { return yearlyRisePercent; }
            set { yearlyRisePercent = value; }
        }
        #endregion


        #region Methods
        public override decimal GetYearlySalary()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
