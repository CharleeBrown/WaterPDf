using System;
using System.Windows.Forms;
using WaterPDF;
using Syncfusion.DocIO;

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
            Form2 form = new Form2();
            form.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            pullPath paths = new pullPath();
            destBox.Text = paths.SaveFile();
        }
    }
}
