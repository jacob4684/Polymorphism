using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPolymorphism
{
    public class User
    {
        #region Fields
        protected string username;
        protected string password;

        #endregion


        #region Constructor
        public User(string username, string password)
        {
            try
            {
                Username = username;
                Password = password;
            }
            catch (ArgumentOutOfRangeException) { throw; }
            catch (ArgumentException) { throw; }
        }
        #endregion


        #region Properties
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                
                string error = String.Empty;
                bool validationSuccess = false;

               
                try
                {
                    validationSuccess = IsValidPassword(value, out error);
                }
                catch (Exception)
                {
                    throw;
                }

                
                if (!validationSuccess)
                {
                   
                    throw new ArgumentException();
                }
                else
                {
                    password = value;
                }
            }
        }
        #endregion


        #region Methods
        public static bool IsValidPassword(string password, out string error)
        {
            bool correctlyFormatted = false;
            if (String.IsNullOrWhiteSpace(password))
            {
                error = "Something went wrong";
                throw new ArgumentException();
            }
            else if (password.Length < 8)
            {
                correctlyFormatted = false;
                error = "Password is too short, please try again.";
            }
            else
            {
                error = String.Empty;
                correctlyFormatted = true;
            }
            return correctlyFormatted;
        }
        #endregion
    }
}
