using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class Student : Person
    {
        #region Fields
        protected DateTime startDate;
        protected short earnedECTS;


        #endregion


        #region Constructor
        public Student(string username, string password) : base(username, password)
        {
        }
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
        #endregion
    }
}
