using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class Secretary : AdministrativeEmployee
    {

        #region Fields
        #endregion


        #region Constructor
        public Secretary(string username, string password) : base(username, password)
        {
        }
        #endregion


        #region Properties
        #endregion


        #region Methods
        public void AdmitStudentTo(Course course)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
