using System;
using System.Windows.Forms;
using WaterPDF;

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

            //foreach (var count in paths.GetPages(pathBox.Text))
            //{
            //    pageCount.Items.Add(count);
            //}

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

        private void waterClear_Click(object sender, EventArgs e)
        {

        }

        private void filenameClear_Click(object sender, EventArgs e)
        {

        }

        private void wtrBox_TextChanged(object sender, EventArgs e)
        {

            if (wtrBox.TextLength < 40)
            {
                // Create the ToolTip and associate with the Form container.
                ToolTip tool = new ToolTip();

                // Set up the delays for the ToolTip.
                tool.AutoPopDelay = 8000;
                tool.InitialDelay = 1000;
                tool.ReshowDelay = 5000;
                // Force the ToolTip text to be displayed whether or not the form is active.
                tool.ShowAlways = true;

                // Set up the ToolTip text for the Button and Checkbox.
                tool.SetToolTip(this.wtrBox, "Recommended font sizes : 32 - 40");
            }
            else if (wtrBox.TextLength > 41 & wtrBox.TextLength < 70)
            {
                ToolTip tool = new ToolTip();

                // Set up the delays for the ToolTip.
                tool.AutoPopDelay = 8000;
                tool.InitialDelay = 1000;
                tool.ReshowDelay = 5000;
                // Force the ToolTip text to be displayed whether or not the form is active.
                tool.ShowAlways = true;

                // Set up the ToolTip text for the Button and Checkbox.
                tool.SetToolTip(this.wtrBox, "Recommended font sizes : 20 - 30");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            pullPath paths = new pullPath();
            destBox.Text = paths.SaveFile();
        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
