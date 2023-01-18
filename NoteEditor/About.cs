using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteEditor
{
    //About page code
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //Disabled richtextbox to not let it be editable
        private void About_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
        }


        private void aboutPageBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }  
    }
}
