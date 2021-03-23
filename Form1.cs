using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            pathBox.Text = paths.GetFile();
            
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            getPDF pdfs = new getPDF();
            
            pdfs.markPDF(pathBox.Text, wtrBox.Text, nameBox.Text,Convert.ToInt32(sizeBox.SelectedItem));
      
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            helpForm form3 = new helpForm();
            form3.Show();
        }
    }

    
}
