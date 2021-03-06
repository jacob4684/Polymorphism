﻿using System;
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
        public Lecturer(string username, string password, string firstname, string lastnames, object ssn, decimal christmasBonus, decimal baseSalary, short numberOfYearlyCourses, decimal courseSalary) : base(username, password, firstname, lastnames, ssn, christmasBonus, baseSalary)
        {
            NumberOfYearlyCourses = numberOfYearlyCourses;
            CourseSalary = courseSalary;
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
            decimal monthInAYear = 12;
            decimal yearlySalary = baseSalary * monthInAYear + numberOfYearlyCourses*courseSalary + christmasBonus;
            return yearlySalary;
        }
        #endregion
    }
}
