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
        protected List<IAdmissable> attendants;


        #endregion


        #region Constructor
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

        public List<IAdmissable> Attendants
        {
            get
            {
                return attendants;
            }

            set
            {
                attendants = value;
            }
        }

        #endregion


        #region Methods
        public void Add(IAdmissable participant)
        {
            if (participant is Lecturer)
            {
                bool hasLeturer = false;
                foreach (IAdmissable person in attendants)
                {
                    if (person is Lecturer)
                    {

                    }
                }
                if (!hasLeturer)
                {
                    attendants.Add(participant);
                }
            }
            else
            {
                //if ()
                //{

                //}
            }
        }
        #endregion
    }
}
