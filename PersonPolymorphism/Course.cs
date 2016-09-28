using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
   public class Course
    {
        #region Fields
        protected DateTime startDate;


        protected DateTime endDate;


        protected string title;


        #endregion


        #region Constructor
        #endregion


        #region ?????
        public IEnumerable<Student> Student
        {
            get;
            set;
        }

        public Lecturer Lecturer
        {
            get;
            set;
        }

        #endregion


        #region Properties
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        
        #endregion


        #region Methods
        #endregion
    }
}
