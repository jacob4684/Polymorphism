using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class Student : Person,IAdmissable
    {
        #region Fields
        protected DateTime startDate;
        protected short earnedECTS;




        #endregion
        public Student(string username, string password, string firstname, string lastnames, object ssn, DateTime startDate, short earnedECTS) : base(username, password, firstname, lastnames, ssn)
        {
            StartDate = startDate;
            EarnedECTS = earnedECTS;
        }

        #region Constructor

        #endregion


        #region Properties

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public short EarnedECTS
        {
            get { return earnedECTS; }
            set { earnedECTS = value; }
        }

        #endregion


        #region Methods
        public TimeSpan StudyTimeSoFar()
        {
            throw new System.NotImplementedException();
        }
        public short EctsLeftTo(string degree)
        {
            throw new System.NotImplementedException();
        }

        public void EnrollIn(Course course)
        {
            course.Add(this);
        }
        #endregion
    }
}
