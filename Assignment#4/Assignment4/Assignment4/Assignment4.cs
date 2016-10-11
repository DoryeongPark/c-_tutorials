using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;


namespace Assignment4
{
    public partial class Assignment4 : MetroForm
    {
        private string currentFile = "";

        private int previousWidth;
        private int previousHeight;
      
        public Assignment4()
        {
            InitializeComponent();
        }

        /* Set form's title and get form's current size */
        private void OnLoad(object sender, EventArgs e) {
            Text = "박도령2010112406실습#6";
            previousWidth = Width;
            previousHeight = Height;
        }

        /* Show OpenFileDialog with text file filter and save seleced file path */
        private void OpenButtonClicked(object sender, EventArgs e)
        {
            tb_main.Clear();

            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "txt files (*.txt)|*.txt";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                LoadFileOnTextBox(fd.FileName);
                lbl_currentfile.Text = currentFile = fd.FileName;
            }   
        }

        /* Write current contents in text box on selected file */
        private void SaveButtonClicked(object sender, EventArgs e)
        {
            if (currentFile.Length != 0)
                File.WriteAllText(currentFile, tb_main.Text);
            else
                MetroMessageBox.Show(this, "You should open file first");

            lbl_currentfile.Text = currentFile = "";
            tb_main.Clear();
        }

        /* Open font dialog and apply selected font and color to fextbox  */
        private void FontButtonClicked(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tb_main.Font = fd.Font;
                tb_main.ForeColor = fd.Color;
            }
        }
            
        /* Open color dialog and apply selected color to textbox background color */ 
        private void BackgroundButtonClicked(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
               tb_main.BackColor = cd.Color;
        }
        
        /* Routine reading text from file and write them on textbox */   
        private void LoadFileOnTextBox(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string oneLine;
            
            while((oneLine = sr.ReadLine()) != null)
                tb_main.AppendText(oneLine + "\r\n");
                                                                                                                                                                                                                      
            sr.Close();
        }

        /* Resize or move component as form's size is changed */
        private void ResizeComponents(object sender, EventArgs e)
        {
            var translationWidth = Width - previousWidth;
            var translationHeight = Height - previousHeight;

            tb_main.Width += translationWidth;
            tb_main.Height += translationHeight;
        }
    }
}
            
