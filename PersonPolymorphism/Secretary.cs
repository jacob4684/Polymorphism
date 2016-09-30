using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class Secretary : AdministrativeEmployee
    {
        #region Constructor
        public Secretary(string username, string password, string firstname, string lastnames, object ssn, decimal christmasBonus, decimal baseSalary, byte payLevel, double yearlyRisePercent) : base(username, password, firstname, lastnames, ssn, christmasBonus, baseSalary, payLevel, yearlyRisePercent)
        {
        }
        #endregion
        #region Methods
        public void Admit(Student student,Course course)
        {
            course.Add(student as IAdmissable);
        }
        public void Admit(Lecturer lecturer, Course course)
        {
            course.Add(lecturer as IAdmissable);
        }
        #endregion
    }
}
