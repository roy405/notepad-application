namespace NoteEditor
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSNewFile = new System.Windows.Forms.ToolStripButton();
            this.tSOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tSSave = new System.Windows.Forms.ToolStripButton();
            this.tSSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tSRemoveTabBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBold = new System.Windows.Forms.ToolStripButton();
            this.tSItalics = new System.Windows.Forms.ToolStripButton();
            this.tSUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tSFontCombBox = new System.Windows.Forms.ToolStripComboBox();
            this.tSHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tSCut = new System.Windows.Forms.ToolStripButton();
            this.tSCopy = new System.Windows.Forms.ToolStripButton();
            this.tSPaste = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNewFile,
            this.menuStripOpenFile,
            this.toolStripSeparator2,
            this.menuStripSave,
            this.menuStripSaveAs,
            this.toolStripSeparator3,
            this.menuStripLogout});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuStripNewFile
            // 
            this.menuStripNewFile.Image = global::NoteEditor.Properties.Resources.document;
            this.menuStripNewFile.Name = "menuStripNewFile";
            this.menuStripNewFile.Size = new System.Drawing.Size(182, 22);
            this.menuStripNewFile.Text = "New              Ctrl + N";
            this.menuStripNewFile.ToolTipText = "Add a new tab with a new file.";
            this.menuStripNewFile.Click += new System.EventHandler(this.menuStripNewFile_Click);
            // 
            // menuStripOpenFile
            // 
            this.menuStripOpenFile.Image = global::NoteEditor.Properties.Resources.folder_open_icon;
            this.menuStripOpenFile.Name = "menuStripOpenFile";
            this.menuStripOpenFile.Size = new System.Drawing.Size(182, 22);
            this.menuStripOpenFile.Text = "Open            Ctrl + O";
            this.menuStripOpenFile.ToolTipText = "Open an exisiting file.";
            this.menuStripOpenFile.Click += new System.EventHandler(this.menuStripOpenFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // menuStripSave
            // 
            this.menuStripSave.Image = global::NoteEditor.Properties.Resources.save;
            this.menuStripSave.Name = "menuStripSave";
            this.menuStripSave.Size = new System.Drawing.Size(182, 22);
            this.menuStripSave.Text = "Save              Ctrl + S";
            this.menuStripSave.ToolTipText = "Overite saved file.";
            this.menuStripSave.Click += new System.EventHandler(this.menuStripSave_Click);
            // 
            // menuStripSaveAs
            // 
            this.menuStripSaveAs.Image = global::NoteEditor.Properties.Resources.Save_as_icon;
            this.menuStripSaveAs.Name = "menuStripSaveAs";
            this.menuStripSaveAs.Size = new System.Drawing.Size(182, 22);
            this.menuStripSaveAs.Text = "Save As";
            this.menuStripSaveAs.ToolTipText = "Save file to a specific location.";
            this.menuStripSaveAs.Click += new System.EventHandler(this.menuStripSaveAs_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // menuStripLogout
            // 
            this.menuStripLogout.Name = "menuStripLogout";
            this.menuStripLogout.Size = new System.Drawing.Size(182, 22);
            this.menuStripLogout.Text = "Logout";
            this.menuStripLogout.ToolTipText = "Logout from current session.";
            this.menuStripLogout.Click += new System.EventHandler(this.menuStripLogout_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripCut,
            this.menuStripCopy,
            this.menuStripPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // menuStripCut
            // 
            this.menuStripCut.Image = global::NoteEditor.Properties.Resources.cut;
            this.menuStripCut.Name = "menuStripCut";
            this.menuStripCut.Size = new System.Drawing.Size(176, 22);
            this.menuStripCut.Text = "Cut              Ctrl + X";
            this.menuStripCut.ToolTipText = "Copy the selected text and remove it from it\'s original position.";
            this.menuStripCut.Click += new System.EventHandler(this.menuStripCut_Click);
            // 
            // menuStripCopy
            // 
            this.menuStripCopy.Image = global::NoteEditor.Properties.Resources.copy;
            this.menuStripCopy.Name = "menuStripCopy";
            this.menuStripCopy.Size = new System.Drawing.Size(176, 22);
            this.menuStripCopy.Text = "Copy           Ctrl + C";
            this.menuStripCopy.ToolTipText = "Copy the selected text while keeping it.";
            this.menuStripCopy.Click += new System.EventHandler(this.menuStripCopy_Click);
            // 
            // menuStripPaste
            // 
            this.menuStripPaste.Image = global::NoteEditor.Properties.Resources.paste;
            this.menuStripPaste.Name = "menuStripPaste";
            this.menuStripPaste.Size = new System.Drawing.Size(176, 22);
            this.menuStripPaste.Text = "Paste           Ctrl + V";
            this.menuStripPaste.ToolTipText = "Paste the text copied or cut from clipboard.";
            this.menuStripPaste.Click += new System.EventHandler(this.menuStripPaste_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStripAbout
            // 
            this.menuStripAbout.Name = "menuStripAbout";
            this.menuStripAbout.Size = new System.Drawing.Size(107, 22);
            this.menuStripAbout.Text = "About";
            this.menuStripAbout.ToolTipText = "About the Application : NoteEdit";
            this.menuStripAbout.Click += new System.EventHandler(this.menuStripAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSNewFile,
            this.tSOpenFile,
            this.tSSave,
            this.tSSaveAs,
            this.tSRemoveTabBtn,
            this.toolStripSeparator1,
            this.tSBold,
            this.tSItalics,
            this.tSUnderline,
            this.toolStripSeparator4,
            this.tSFontCombBox,
            this.tSHelp,
            this.toolStripSeparator5,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(998, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSNewFile
            // 
            this.tSNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSNewFile.Image = ((System.Drawing.Image)(resources.GetObject("tSNewFile.Image")));
            this.tSNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSNewFile.Name = "tSNewFile";
            this.tSNewFile.Size = new System.Drawing.Size(23, 22);
            this.tSNewFile.Text = "toolStripButton1";
            this.tSNewFile.ToolTipText = "Add a new tab with a new file.";
            this.tSNewFile.Click += new System.EventHandler(this.tSNewFile_Click);
            // 
            // tSOpenFile
            // 
            this.tSOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tSOpenFile.Image")));
            this.tSOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSOpenFile.Name = "tSOpenFile";
            this.tSOpenFile.Size = new System.Drawing.Size(23, 22);
            this.tSOpenFile.Text = "toolStripButton2";
            this.tSOpenFile.ToolTipText = "Open an exisiting file.";
            this.tSOpenFile.Click += new System.EventHandler(this.tSOpenFile_Click);
            // 
            // tSSave
            // 
            this.tSSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSSave.Image = ((System.Drawing.Image)(resources.GetObject("tSSave.Image")));
            this.tSSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSSave.Name = "tSSave";
            this.tSSave.Size = new System.Drawing.Size(23, 22);
            this.tSSave.Text = "toolStripButton3";
            this.tSSave.ToolTipText = "Overite saved file.";
            this.tSSave.Click += new System.EventHandler(this.tSSave_Click);
            // 
            // tSSaveAs
            // 
            this.tSSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tSSaveAs.Image")));
            this.tSSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSSaveAs.Name = "tSSaveAs";
            this.tSSaveAs.Size = new System.Drawing.Size(23, 22);
            this.tSSaveAs.Text = "toolStripButton4";
            this.tSSaveAs.ToolTipText = "Save file to a specific location.";
            this.tSSaveAs.Click += new System.EventHandler(this.tSSaveAs_Click);
            // 
            // tSRemoveTabBtn
            // 
            this.tSRemoveTabBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSRemoveTabBtn.Image = ((System.Drawing.Image)(resources.GetObject("tSRemoveTabBtn.Image")));
            this.tSRemoveTabBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSRemoveTabBtn.Name = "tSRemoveTabBtn";
            this.tSRemoveTabBtn.Size = new System.Drawing.Size(23, 22);
            this.tSRemoveTabBtn.Text = "toolStripButton1";
            this.tSRemoveTabBtn.Click += new System.EventHandler(this.tSRemoveTabBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSBold
            // 
            this.tSBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBold.Image = ((System.Drawing.Image)(resources.GetObject("tSBold.Image")));
            this.tSBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBold.Name = "tSBold";
            this.tSBold.Size = new System.Drawing.Size(23, 22);
            this.tSBold.Text = "toolStripButton5";
            this.tSBold.ToolTipText = "Make selected text Bold.";
            this.tSBold.Click += new System.EventHandler(this.tSBold_Click);
            // 
            // tSItalics
            // 
            this.tSItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSItalics.Image = ((System.Drawing.Image)(resources.GetObject("tSItalics.Image")));
            this.tSItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSItalics.Name = "tSItalics";
            this.tSItalics.Size = new System.Drawing.Size(23, 22);
            this.tSItalics.Text = "toolStripButton6";
            this.tSItalics.ToolTipText = "Make selected text Italicized.";
            this.tSItalics.Click += new System.EventHandler(this.tSItalics_Click);
            // 
            // tSUnderline
            // 
            this.tSUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tSUnderline.Image")));
            this.tSUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSUnderline.Name = "tSUnderline";
            this.tSUnderline.Size = new System.Drawing.Size(23, 22);
            this.tSUnderline.Text = "toolStripButton7";
            this.tSUnderline.ToolTipText = "Make selected text Underlined.";
            this.tSUnderline.Click += new System.EventHandler(this.tSUnderline_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tSFontCombBox
            // 
            this.tSFontCombBox.Name = "tSFontCombBox";
            this.tSFontCombBox.Size = new System.Drawing.Size(121, 25);
            this.tSFontCombBox.ToolTipText = "Select Font Size";
            this.tSFontCombBox.DropDownClosed += new System.EventHandler(this.tsFontCombBox_DropdownClosed);
            // 
            // tSHelp
            // 
            this.tSHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSHelp.Image = ((System.Drawing.Image)(resources.GetObject("tSHelp.Image")));
            this.tSHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSHelp.Name = "tSHelp";
            this.tSHelp.Size = new System.Drawing.Size(23, 22);
            this.tSHelp.Text = "toolStripButton8";
            this.tSHelp.ToolTipText = "Help FAQ";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel1.Text = "User name:";
            this.toolStripLabel1.ToolTipText = "Currently Logged in User";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCut,
            this.tSCopy,
            this.tSPaste});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 527);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSCut
            // 
            this.tSCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSCut.Image = ((System.Drawing.Image)(resources.GetObject("tSCut.Image")));
            this.tSCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSCut.Name = "tSCut";
            this.tSCut.Size = new System.Drawing.Size(21, 20);
            this.tSCut.Text = "toolStripButton9";
            this.tSCut.ToolTipText = "Copy the selected text and remove it from it\'s original position.";
            this.tSCut.Click += new System.EventHandler(this.tSCut_Click);
            // 
            // tSCopy
            // 
            this.tSCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSCopy.Image = ((System.Drawing.Image)(resources.GetObject("tSCopy.Image")));
            this.tSCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSCopy.Name = "tSCopy";
            this.tSCopy.Size = new System.Drawing.Size(21, 20);
            this.tSCopy.Text = "toolStripButton10";
            this.tSCopy.ToolTipText = "Copy the selected text while keeping it.";
            this.tSCopy.Click += new System.EventHandler(this.tSCopy_Click);
            // 
            // tSPaste
            // 
            this.tSPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSPaste.Image = ((System.Drawing.Image)(resources.GetObject("tSPaste.Image")));
            this.tSPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSPaste.Name = "tSPaste";
            this.tSPaste.Size = new System.Drawing.Size(21, 20);
            this.tSPaste.Text = "toolStripButton11";
            this.tSPaste.ToolTipText = "Paste the text copied or cut from clipboard.";
            this.tSPaste.Click += new System.EventHandler(this.tSPaste_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(27, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 527);
            this.tabControl1.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditor";
            this.Text = "NoteEdit : Text Editor";
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripNewFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripOpenFile;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSNewFile;
        private System.Windows.Forms.ToolStripButton tSOpenFile;
        private System.Windows.Forms.ToolStripButton tSSave;
        private System.Windows.Forms.ToolStripButton tSSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSBold;
        private System.Windows.Forms.ToolStripButton tSItalics;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuStripSave;
        private System.Windows.Forms.ToolStripMenuItem menuStripSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuStripLogout;
        private System.Windows.Forms.ToolStripMenuItem menuStripCut;
        private System.Windows.Forms.ToolStripMenuItem menuStripCopy;
        private System.Windows.Forms.ToolStripMenuItem menuStripPaste;
        private System.Windows.Forms.ToolStripMenuItem menuStripAbout;
        private System.Windows.Forms.ToolStripButton tSUnderline;
        private System.Windows.Forms.ToolStripComboBox tSFontCombBox;
        private System.Windows.Forms.ToolStripButton tSHelp;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tSCut;
        private System.Windows.Forms.ToolStripButton tSCopy;
        private System.Windows.Forms.ToolStripButton tSPaste;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton tSRemoveTabBtn;
    }
}