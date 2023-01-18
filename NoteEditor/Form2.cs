using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteEditor
{
    public partial class Form2 : Form
    {
        //Enum containing user types for combo box
        enum UserType
        {
            None,
            View,
            Edit
        }

    
        //Form2 Constructor
        public Form2()
        {
            InitializeComponent();
        }


        //Method that runs when form 2 is Loaded
        private void Form2_Load(object sender, EventArgs e)
        {

            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            foreach (var item in Enum.GetValues(typeof(UserType)))
            {
                UserTypeComboBox.Items.Add(item);
            }

        }

        //Close Button Method
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void RegisterCancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form1 = new LoginForm();
            form1.Show();
        }

        //Event handler for button click that takes entered user information, validates and registers
        //the user to use the Text Editor.
        private void RegisterSubmitBtn_Click(object sender, EventArgs e)
        {
            Utility util = new Utility();
            string authFilePath = util.pathFinder("login.txt");
            string[] users = System.IO.File.ReadAllLines(authFilePath);
           

            UserAccount user = new UserAccount();
            user.Username = textBox1.Text;
            user.Password = textBox2.Text;
            string confirmPassword = textBox3.Text;
            user.FirstName = textBox4.Text;
            user.LastName = textBox5.Text;
            user.Dob = dateTimePicker1.Text;
            user.UserType = this.UserTypeComboBox.GetItemText(this.UserTypeComboBox.SelectedItem);

            Boolean fnameResultCheck = user.FirstName.Any(char.IsDigit);
            Boolean lnameResultCheck = user.LastName.Any(char.IsDigit);

            //Field data validations
            if (user.Username == "" || user.Password == "" || confirmPassword == "" || user.FirstName == "" || user.LastName == "" || user.Dob == "" || user.UserType == "")
            {
                MessageBox.Show("Blank Field. Please do not allow any Blank Fields");
            }
            else if (user.Password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please enter passwords correctly!");
            }
            else if (fnameResultCheck == true)
            {
                MessageBox.Show("First Name can only be Alphabet Characters");
            }
            else if (lnameResultCheck == true)
            {
                MessageBox.Show("Last Name can only be Alphabet Characters");
            }
            else
            {
                if (users.Length > 0)
                {
                    for (int i = 0; i < users.Length; i++)
                    {
                        if (user.Username == (users[i].Substring(0, users[i].IndexOf(","))))
                        {
                            MessageBox.Show("Username is Taken. Please try a different username");
                            break;
                        }
                        else
                        {
                            if (Array.IndexOf(users, users[i]) == (users.Length - 1))
                            {
                                string toWrite = user.Username + "," +
                                                 user.Password + "," +
                                                 user.UserType + "," +
                                                 user.FirstName + "," +
                                                 user.LastName + "," +
                                                 user.Dob;
                                try
                                {
                                   // File.WriteAllText(authFilePath, "/r/n" + toWrite.TrimStart());
                                    File.AppendAllText(authFilePath, "\r\n" + toWrite.TrimStart());
                                    
                                }
                                catch (IOException)
                                {
                                    Console.WriteLine("Cannot Create Account! Internal Error!");
                                }
                                MessageBox.Show("Registration Successful! \n" +
                                "username: " + user.Username +
                                "password: " + user.Password);

                                Hide();
                                var form1 = new LoginForm();
                                form1.Show();

                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    string toWrite = user.Username + "," +
                                        user.Password + "," +
                                        user.UserType + "," +
                                        user.FirstName + "," +
                                        user.LastName + "," +
                                        user.Dob;
                    try
                    {

                        /*File.AppendAllText(authFilePath, Environment.NewLine + toWrite);*/
                        File.WriteAllText(authFilePath,toWrite.TrimStart());

                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Cannot Create Account! Internal Error!");
                    }
                    MessageBox.Show("Registration Successful! \n" +
                    "username: " + user.Username +
                    "password: " + user.Password);

                    Hide();
                    var form1 = new LoginForm();
                    form1.Show();
            }
            }
        }
    }
}
