using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class Lecturer : Employee
    {
        #region Fields
        protected decimal courseSalary;
        protected short numberOfYearlyCourses;


        #endregion


        #region Constructor
        public Lecturer(string username, string password) : base(username, password)
        {
        }

        #endregion


        #region Properties

        public decimal CourseSalary
        {
            get { return courseSalary; }
            set { courseSalary = value; }
        }
        public short NumberOfYearlyCourses
        {
            get { return numberOfYearlyCourses; }
            set { numberOfYearlyCourses = value; }
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
