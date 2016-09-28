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


        #region Constructor
        public AdministrativeEmployee(string username, string password) : base(username, password)
        {
        }

        #endregion


        #region Properties

        public byte PayLevel
        {
            get { return payLevel; }
            set { payLevel = value; }
        }
        public double NumberOfYearlyCourses
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
