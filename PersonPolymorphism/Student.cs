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
            TimeSpan time = DateTime.Now-startDate;
            return time;
        }
        public short EctsLeftTo(string degree)
        {
            short ectsPointLeftToEarned = 0;
            short bachelor = 180;
            short master = 240;
            if (degree== "Bachelor")
            {
                ectsPointLeftToEarned = (Int16)(earnedECTS - bachelor) ;
            }
            else if (degree=="Master")
            {
                ectsPointLeftToEarned = (Int16)(earnedECTS - master);
            }
            return ectsPointLeftToEarned;

        }

        public void EnrollIn(Course course)
        {
            course.Add(this);
        }
        #endregion
    }
}
