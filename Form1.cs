using System;
using System.Windows.Forms;
using WaterPDF;
using Microsoft.Office.Interop.Word;
using Syncfusion.DocIO;
using System.IO;

namespace WatermarkAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sizeBox.SelectedIndex = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pullPath paths = new pullPath();
           // PageCounter counter = new PageCounter();
            pathBox.Text = paths.GetFile();
        }
        private void runBtn_Click(object sender, EventArgs e)
        {
            getPDF pdfs = new getPDF();
            multiPagePDF multiPage = new multiPagePDF();
            if (allPageCheck.Checked != true)
            {
                pdfs.markPDF(pathBox.Text, wtrBox.Text, nameBox.Text, Convert.ToInt32(sizeBox.SelectedItem), destBox.Text);
            }
            else
            {
                multiPage.markPDF(pathBox.Text, wtrBox.Text, nameBox.Text, Convert.ToInt32(sizeBox.SelectedItem), destBox.Text);
            }
            pathBox.Clear();
            nameBox.Clear();
            pathBox.Focus();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            pullPath paths = new pullPath();
            destBox.Text = paths.SaveFile();
        }

        private void wtrBox_TextChanged(object sender, EventArgs e)
        {
            if(wtrBox.TextLength >= 140)
            {
                sizeBox.SelectedIndex = 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
