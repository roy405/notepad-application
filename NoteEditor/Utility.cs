using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Windows.Forms.VisualStyles;

namespace NoteEditor
{
    //An utility class for frequently used methods
    internal class Utility


    {
        static List<string> usernameList = new List<string>();
        static List<string> passwordList = new List<string>();
        static List<string> userTypeList = new List<string>();
        static List<string> firstNameList = new List<string>();
        static List<string> lastNameList = new List<string>();
        static List<string> dobList = new List<string>();
        static string[] users;

        static string username, password, utype, fName, lName, dob;


        //Method for dynamic file access. Accesses the default path and modifies the path to point to the directory of all stored files.  
        public string pathFinder(string replace)
        {
            string defaultDirectory = Directory.GetCurrentDirectory();
            string directory = defaultDirectory.Replace("NoteEditor\\bin\\Debug", replace);
            return directory;

        }

        //Method that calls the pathFinder method to get the login credentials from file and separates
        //the stores the data into 6 different lists based on the date type (username, password, etc)
        public void storeUserList()
        {
            string authFilePath = pathFinder("login.txt");
            
            users = System.IO.File.ReadAllLines(authFilePath);
            for (int i = 0; i < users.Length; i++)
            {
                //initialize a new list for storing indices of each line of the comma
                List<int> indices = new List<int>();

                String line = users[i];
                char ch = ',';

                int index = line.IndexOf(ch);

                // finding the indices of the comma of each line in the file
                while (index != -1)
                {
                    indices.Add(index);
                    index = line.IndexOf(ch, index + 1);
                }

                //define the firstIndex and lastIndex for shifting postion.
                int firstIndex = 0;
                int lastIndex = indices.ElementAt(0);
                // len is the range of the substring we are going to store.
                int len = lastIndex - firstIndex + 1;


                // adding username to our username list
                username = line.Substring(firstIndex, len - 1);
                usernameList.Add(username);

                // shift the indexes 
                firstIndex = lastIndex + 1;
                lastIndex = indices.ElementAt(1);
                len = lastIndex - firstIndex + 1;

                // adding password to the password list
                password = line.Substring(firstIndex, len - 1);
                passwordList.Add(password);

                // shift the index after password is added
                firstIndex = lastIndex + 1;
                lastIndex = indices.ElementAt(2);
                len = lastIndex - firstIndex + 1;

                //adding type to the type list
                utype = line.Substring(firstIndex, len - 1);
                userTypeList.Add(utype);

                //shift the index after type is added
                firstIndex = lastIndex + 1;
                lastIndex = indices.ElementAt(3);
                len = lastIndex - firstIndex + 1;

                //adding fullname to the list
                fName = line.Substring(firstIndex, len - 1);
                firstNameList.Add(fName);

                //shifiting index position
                firstIndex = lastIndex + 1;
                lastIndex = indices.ElementAt(4);
                len = lastIndex - firstIndex + 1;

                // add lastName to the list
                lName = line.Substring(firstIndex, len - 1);
                lastNameList.Add(lName);

                //shift index position
                firstIndex = lastIndex + 1;


                //add Dob to the list 
                // position start from the index after comma, no need to specify last index.
                dob = line.Substring(firstIndex + 1);
                dobList.Add(dob);


            }

        }

        //Getter method for username list
        public List<string> getUserNameList()
        {
            return usernameList;
        }

        //Getter method for password list
        public List<string> getPasswordList()
        {
            return passwordList;
        }

        //Getter method for usertype list
        public List<string> getUserTypeList()
        {
            return userTypeList;
        }

        //Getter method for First Name List
        public List<string> getFirstNameList()
        {
            return firstNameList;
        }
        //Getter method for Last Name List
        public List<string> getLastNameList()
        {
            return lastNameList;
        }
        //Getter method for Date of Birth List
        public List<string> getDOBList()
        {
            return dobList;
        }


    }
}
