using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingProject.Copy.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<int, ProgressBar> prgList = new Dictionary<int, ProgressBar>();
        private Dictionary<int, Label> lblList = new Dictionary<int, Label>();

        private void BtnFileSelecttion_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxFrom1.Text) ||
                string.IsNullOrEmpty(textBoxFrom2.Text) ||
                string.IsNullOrEmpty(textBoxFrom3.Text) ||
                string.IsNullOrEmpty(textBoxFrom4.Text) ||
                string.IsNullOrEmpty(textBoxTo1.Text) ||
                string.IsNullOrEmpty(textBoxTo2.Text) ||
                string.IsNullOrEmpty(textBoxTo3.Text) ||
                string.IsNullOrEmpty(textBoxTo4.Text))
            {
                MessageBox.Show("مسیر خواندن و کپی فایل‌ها نمی‌تواند خالی باشد.", "پیغام خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2 form2 = new Form2();

                form2.File1 = textBoxFrom1.Text;
                form2.File2 = textBoxFrom2.Text;
                form2.File3 = textBoxFrom3.Text;
                form2.File4 = textBoxFrom4.Text;

                form2.Folder1 = textBoxTo1.Text;
                form2.Folder2 = textBoxTo2.Text;
                form2.Folder3 = textBoxTo3.Text;
                form2.Folder4 = textBoxTo4.Text;

                form2.ShowDialog(this);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {

            textBoxFrom1.Text = "";
            textBoxFrom2.Text = "";
            textBoxFrom3.Text = "";
            textBoxFrom4.Text = "";

            textBoxTo1.Text = "";
            textBoxTo2.Text = "";
            textBoxTo3.Text = "";
            textBoxTo4.Text = "";

            //textBoxToFolder.Text = "";
            //prgList.Clear();
            //lblList.Clear();
            //for (int i = this.Controls.Count - 1; i > 0; i--)
            //{
            //    if(this.Controls[i] is ProgressBar || this.Controls[i] is Label)
            //    {
            //        this.Controls.Remove(this.Controls[i]);
            //    }
            //}
        }

        private void ButtonFrom1_Click(object sender, EventArgs e)
        {
            if(threadingOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFrom1.Text = threadingOpenFileDialog.FileName;
            }
        }

        private void ButtonFrom2_Click(object sender, EventArgs e)
        {
            if (threadingOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFrom2.Text = threadingOpenFileDialog.FileName;
            }
        }

        private void ButtonFrom3_Click(object sender, EventArgs e)
        {
            if (threadingOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFrom3.Text = threadingOpenFileDialog.FileName;
            }
        }

        private void ButtonFrom4_Click(object sender, EventArgs e)
        {
            if (threadingOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFrom4.Text = threadingOpenFileDialog.FileName;
            }
        }

        private void ButtonTo1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxTo1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ButtonTo2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxTo2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ButtonTo3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxTo3.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ButtonTo4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxTo4.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
