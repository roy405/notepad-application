using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NoteEditor
{
    //User Account class to store user information read from file
    internal class UserAccount
    {
        //User related information which corresponds to the variables on the login file
        private string username { get; set; }
        private string password { get; set; }
        private string firstName { get; set; } 
        private string lastName { get; set; }
        private string dob { get; set; }
        private string userType { get; set; }

        //Empty Contructor
        public UserAccount () { }

        //Parametrisized Constructor 
        public UserAccount(string username, string password, string firstName, string lastName, string dob, string userType)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.userType = userType;
        }

        //All Getter Setters for UserAccount attributes
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
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
                password = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string UserType
        {
            get
            {
                return userType;
            }

            set
            {
                userType = value;
            }
        }


    }
}

