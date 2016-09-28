using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;

namespace Assignment4
{
    public partial class Assignment4 : MetroForm
    {

        string currentFile = "";

        public Assignment4()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }

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

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            if (currentFile.Length != 0)
                File.WriteAllText(currentFile, tb_main.Text);
            else
                MetroMessageBox.Show(this, "You should open file first");

            lbl_currentfile.Text = currentFile = "";

            tb_main.Clear();
        }

        private void FontButtonClicked(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if(fd.ShowDialog() == DialogResult.OK)
                tb_main.Font = fd.Font;
        }
             
        private void BackgroundButtonClicked(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
               tb_main.BackColor = cd.Color;
        }
           
        private void LoadFileOnTextBox(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string oneLine;
            
            while((oneLine = sr.ReadLine()) != null)
                tb_main.AppendText(oneLine + "\r\n");
            
            sr.Close();
        }   
    }
}
            
