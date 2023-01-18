using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace NoteEditor
{
    public partial class TextEditor : Form
    {
        //Variables declared keep track of logged in user and path of file.
        public string userFname;
        public string userLname;
        public string userAccessType;
        public string pathOfFile;
        LoginForm form1 = new LoginForm();

        //UI related variable declarations
        public RichTextBox rtb;
        public TabPage myTabPage;
        public static ArrayList multipath = new ArrayList();
        public static ArrayList tabArray = new ArrayList();

        //Form constructor
        public TextEditor()
        {
            InitializeComponent();
        }

        //Method to initiate the form and perform actions that are outlined within during initiation
        private void TextEditor_Load(object sender, EventArgs e)
        {
            var list = Enumerable.Range(8, 13).Cast<object>().ToArray();
            tSFontCombBox.Items.AddRange(list);
            tSFontCombBox.SelectedText = "10";
            tSFontCombBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripLabel1.Text = "User Name: " + userFname + " " + userLname;
            if (userAccessType == "View")
            {
                tSNewFile.Enabled = false;
                menuStripNewFile.Enabled = false;

                tSSave.Enabled = false;
                menuStripSave.Enabled = false;

                tSSaveAs.Enabled = false;
                menuStripSaveAs.Enabled = false;

                tSCut.Enabled = false;
                tSCopy.Enabled = false;
                tSPaste.Enabled = false;

                menuStripCut.Enabled = false;
                menuStripCopy.Enabled = false;
                menuStripPaste.Enabled = false;

                tSBold.Enabled = false;
                tSItalics.Enabled = false;
                tSUnderline.Enabled = false;

                tSFontCombBox.Enabled = false;
            }

           
        }

        //Event to trigger upon Close button click and form closing initiation
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure? You will be taken back to the Login Screen and Loggedout!", "Closing.. Application.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                form1.Show();
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        //Code for horizontal tool strip New File button to create a new Tab and assign a rich text box to it for Text Editing/Viewing
        private void tSNewFile_Click(object sender, EventArgs e)
        {
            rtb = new RichTextBox();
            string tabTitle = "NewFile" + (tabControl1.TabCount + 1).ToString();
            myTabPage = new TabPage(tabTitle);
            myTabPage.Controls.Add(rtb);
            rtb.Dock = DockStyle.Fill;
            tabArray.Add(rtb);
            tabControl1.TabPages.Add(myTabPage);
        }

        //Code for Menu Strip New File button to create a new Tab and assign a rich text box to it for Text Editing/Viewing
        private void menuStripNewFile_Click(object sender, EventArgs e)
        {
            rtb = new RichTextBox();
            string tabTitle = "NewFile" + (tabControl1.TabCount + 1).ToString();
            myTabPage = new TabPage(tabTitle);

            myTabPage.Controls.Add(rtb);
            rtb.Dock = DockStyle.Fill;
            tabArray.Add(rtb);
            tabControl1.TabPages.Add(myTabPage);

        }

        //Code for horizontal tool strip Bold Button to bold selected Text
        private void tSBold_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                RichTextBox rtb = GetRichTextBox();
                Invoke(new MethodInvoker(delegate ()
                {
                    if (rtb.SelectionFont.Bold)
                    {
                        rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style ^ FontStyle.Bold);
                    }
                    else
                    {
                        rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style | FontStyle.Bold);
                    }
                }
                ));
            }
            
        }

        //Code for horizontal tool strip Italics Button to italicize selected Text
        private void tSItalics_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                RichTextBox rtb = GetRichTextBox();
                Invoke(new MethodInvoker(delegate ()
                {
                    if (rtb.SelectionFont.Italic)
                    {
                        rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style ^ FontStyle.Italic);
                    }
                    else
                    {
                        rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style | FontStyle.Italic);
                    }
                }
              ));
            }
        }

        //Code for horizontal tool strip Underline Button to underline selected Text
        private void tSUnderline_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                RichTextBox rtb = GetRichTextBox();
                Invoke(new MethodInvoker(delegate ()
                {
                    if (rtb.SelectionFont.Underline)
                    {
                        rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style ^ FontStyle.Underline);
                    }
                    else
                    {
                        rtb.SelectionFont = new Font(rtb.SelectionFont, rtb.SelectionFont.Style | FontStyle.Underline);
                    }
                }
              ));
            }
        }

        //Code for the horizontal tool strip Copy Button to make a copy of the selected text to the Clipboard
        private void tSCopy_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                if (!GetRichTextBox().SelectedText.Equals(string.Empty))
                {
                    Clipboard.SetText(GetRichTextBox().SelectedText);
                }
                else
                {
                    MessageBox.Show("Please Select Text before Cut/Copy", "Unselected Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        //Code for the menu strip copy Button to make a copy of the selected text to the Clipboard
        private void menuStripCopy_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                if (!GetRichTextBox().SelectedText.Equals(string.Empty))
                {
                    Clipboard.SetText(GetRichTextBox().SelectedText);
                }
                else
                {
                    MessageBox.Show("Please Select Text before Cut/Copy", "Unselected Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        //Code for the horizontal tool strip Cut Button to cut selected text to the Clipboard
        private void tSCut_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                if (!GetRichTextBox().SelectedText.Equals(string.Empty))
                {
                    Clipboard.SetText(GetRichTextBox().SelectedText);
                    GetRichTextBox().SelectedText = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please Select Text before Cut/Copy", "Unselected Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Code for the Menu Strip Cut Button to cut selected text to the Clipboard
        private void menuStripCut_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                if (!GetRichTextBox().SelectedText.Equals(string.Empty))
                {
                    Clipboard.SetText(GetRichTextBox().SelectedText);
                    GetRichTextBox().SelectedText = string.Empty;
                }
                else
                {
                    MessageBox.Show("Please Select Text before Cut/Copy", "Unselected Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
        }

        //Code for the horizontal tool strip Paste Button to paste selected copied/cut text from the Clipboard
        private void tSPaste_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                GetRichTextBox().SelectedText = Clipboard.GetText();
            }
            
        }

        //Code for the Menu Strip Paste Button to paste selected copied/cut text from the Clipboard
        private void menuStripPaste_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                GetRichTextBox().SelectedText = Clipboard.GetText();
            }
            
        }

        //Code for Logout form the Application
        private void menuStripLogout_Click(object sender, EventArgs e)
        {
            userFname = "";
            userLname = "";
            userAccessType = "";

            Hide();
            
            form1.Show(); 
        }

        //Code for Menu Strip Save button to overwrite an already saved file
        private void menuStripSave_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                if (!(multipath.Contains(tabControl1.SelectedTab.Text)))
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "RichTextFormate|*.rtf|Text Files|*.txt|All Files|*.*";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pathOfFile = saveFileDialog1.FileName;
                        tabControl1.SelectedTab.Text = pathOfFile;
                        multipath.Add(pathOfFile);


                        try
                        {
                            StreamWriter sw = new StreamWriter(pathOfFile);
                            sw.Write(GetRichTextBox().Text);
                            sw.Close();
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("Error, file cannot be saved:" + ex.Message);
                        }
                    }
                }
                else
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(tabControl1.SelectedTab.Text);
                        sw.Write(GetRichTextBox().Text);
                        sw.Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error, file cannot be saved:" + ex.Message);
                    }
                }
            }
        }



        //Code for horizontal tool strip Save button to overwrite an already saved file
        private void tSSave_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                if (!(multipath.Contains(tabControl1.SelectedTab.Text)))
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "RichTextFormate|*.rtf|Text Files|*.txt|All Files|*.*";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;
                    
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pathOfFile = saveFileDialog1.FileName;
                        tabControl1.SelectedTab.Text = pathOfFile;
                        multipath.Add(pathOfFile);

                        try
                        {
                            StreamWriter sw = new StreamWriter(pathOfFile);
                            sw.Write(GetRichTextBox().Text);
                            sw.Close();
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("Error, file cannot be saved:" + ex.Message);
                        }
                    }
                }
                else
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(tabControl1.SelectedTab.Text);
                        sw.Write(GetRichTextBox().Text);
                        sw.Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error, file cannot be saved:" + ex.Message);
                    }
                }
            }
        }

        //Code for Menu Strip Save As button to save file at a selected location
        private void menuStripSaveAs_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "RichTextFormate|*.rtf|Text Files|*.txt|All Files|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    pathOfFile = saveFileDialog1.FileName;
                    tabControl1.SelectedTab.Text = pathOfFile;
                    multipath.Add(pathOfFile);

                    try
                    {
                        StreamWriter sw = new StreamWriter(pathOfFile);
                        sw.Write(rtb.Text);
                        sw.Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error, file cannot be saved:" + ex.Message);
                    }
                }

                
            }
        }

        //Code for horizontal tool strip Save As button to save file at a selected location
        private void tSSaveAs_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("Please Open or Create a new Document.");
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "RichTextFormate|*.rtf|Text Files|*.txt|All Files|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pathOfFile = saveFileDialog1.FileName;
                    tabControl1.SelectedTab.Text = pathOfFile;
                    multipath.Add(pathOfFile);

                    try
                    {
                        StreamWriter sw = new StreamWriter(pathOfFile);
                        sw.Write(rtb.Text);
                        sw.Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error, file cannot be saved:" + ex.Message);
                    }
                }

                
            }
        }


        //Code to go to the About Page
        private void menuStripAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new About();
            aboutForm.Show();
        }

        //Code for the Menu Strip Open File Button to open an existing file
        private void menuStripOpenFile_Click(object sender, EventArgs e)
        {
            Stream stream;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog1.OpenFile()) != null)
                {
                    string[] files = openFileDialog1.FileNames;

                    if (userAccessType == "Edit")
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        for (int i = 0; i < files.Length; i++)
                        {
                            multipath.Add(openFileDialog1.FileName);
                            sr = new StreamReader(files[i]);
                            myTabPage = new TabPage(openFileDialog1.FileName);
                            myTabPage.Text = files[i];
                            rtb = new RichTextBox();
                            rtb.Dock = DockStyle.Fill;
                            myTabPage.Controls.Add(rtb);
                            rtb.Text = sr.ReadToEnd();
                            tabControl1.TabPages.Add(myTabPage);
                            sr.Close();
                        }
                    }
                    else 
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        for (int i = 0; i < files.Length; i++)
                        {
                            multipath.Add(openFileDialog1.FileName);
                            sr = new StreamReader(files[i]);
                            myTabPage = new TabPage(openFileDialog1.FileName);
                            myTabPage.Text = files[i];
                            rtb = new RichTextBox();
                            rtb.Dock = DockStyle.Fill;
                            myTabPage.Controls.Add(rtb);
                            rtb.Text = sr.ReadToEnd();
                            rtb.Enabled = false;
                            tabControl1.TabPages.Add(myTabPage);;
                            sr.Close();
                        }
                    }
                }
            }
        }

        //Code for the horizontal Tool Strip Open File Button to open an existing file
        private void tSOpenFile_Click(object sender, EventArgs e)
        {
            Stream stream;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((stream = openFileDialog1.OpenFile()) != null)
                {
                    string[] files = openFileDialog1.FileNames;

                    if (userAccessType == "Edit")
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        for (int i = 0; i < files.Length; i++)
                        {
                            multipath.Add(openFileDialog1.FileName);
                            sr = new StreamReader(files[i]);
                            myTabPage = new TabPage(openFileDialog1.FileName);
                            myTabPage.Text = files[i];
                            rtb = new RichTextBox();
                            rtb.Dock = DockStyle.Fill;
                            myTabPage.Controls.Add(rtb);
                            rtb.Text = sr.ReadToEnd();
                            tabControl1.TabPages.Add(myTabPage);
                            sr.Close();
                        }
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(openFileDialog1.FileName);
                        for (int i = 0; i < files.Length; i++)
                        {
                            multipath.Add(openFileDialog1.FileName);
                            sr = new StreamReader(files[i]);
                            myTabPage = new TabPage(openFileDialog1.FileName);
                            myTabPage.Text = files[i];
                            rtb = new RichTextBox();
                            rtb.Dock = DockStyle.Fill;
                            myTabPage.Controls.Add(rtb);
                            rtb.Text = sr.ReadToEnd();
                            rtb.Enabled = false;
                            tabControl1.TabPages.Add(myTabPage); ;
                            sr.Close();
                        }
                    }
                }
            }
        }

        private void tSRemoveTabBtn_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void tsFontCombBox_DropdownClosed(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.TabPages.Count == 0)
                {
                    MessageBox.Show("Please Open or Create a new Document.");
                }
                else
                {
                    float fontSize = float.Parse(tSFontCombBox.Text);
                    RichTextBox rtb = GetRichTextBox();
                    Invoke(new MethodInvoker(delegate ()
                    {
                        rtb.SelectionFont = new Font(rtb.SelectionFont.FontFamily, fontSize);
                    }
                       ));
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An internal error occured! Please try agin.");
            }
            
        }


        //Function to get the RichTextBox from the Selected Tab
        private RichTextBox GetRichTextBox()
        {
            rtb = null;
            TabPage tabpage = tabControl1.SelectedTab;
            if (tabpage != null)
            {
                rtb = tabpage.Controls[0] as RichTextBox;
            }
            return rtb;
        }


    }
}
