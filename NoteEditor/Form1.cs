using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteEditor
{
    public partial class LoginForm : Form
    {
        //Utility Object Declaration and Instantiation
        Utility util = new Utility();
        

        //Login Form Contructor
        public LoginForm() 
        {
            InitializeComponent();
        }

        //Method run upon when form is about to close
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /* 
         * 
         * Method that runs when form loads
         */

        private void Form1_Load(object sender, EventArgs e) 
        {
            util.storeUserList();
        }

        //Button click event for Login
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //Getting username and password from form fields
            string usernameText = usernameTextField.Text;
            string passwordText = passwordTextField.Text;
            
            //New variable to store index
            int indexStore;

                 //Checking if fields are blank
                if (usernameText == "" || passwordText == "")
                {
                    MessageBox.Show("Blank Field. Please do not allow any Blank Fields", "Blank Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                 else
                {
                    //Checking if the usernamelist extracted from file contains the entered username
                    if (util.getUserNameList().Contains(usernameText))
                    {
                        indexStore = util.getUserNameList().IndexOf(usernameText);
                        //Checking if the passwordList extracted from file contains the entered password
                        if (passwordText == util.getPasswordList().ElementAt(indexStore))
                        {
                            MessageBox.Show("Login Successful!", "Login Status", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Hide();
                            var textEditor = new TextEditor();

                            //Declaring and assigning values to variables to keep track of logged in user information.
                            textEditor.userFname = util.getFirstNameList().ElementAt(indexStore);
                            textEditor.userLname = util.getLastNameList().ElementAt(indexStore);
                            textEditor.userAccessType = util.getUserTypeList().ElementAt(indexStore);

                            textEditor.Show();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password!","Authentication Status",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username", "Authentication Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        }

        //Button click event to hide this form and initiate the Registration form
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var form2 = new Form2();
            form2.Show();
        }
    }
}
