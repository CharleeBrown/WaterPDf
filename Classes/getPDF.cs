using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Windows.Forms;


namespace WatermarkAdd
{
    class getPDF
    {
        // The end goal is to have a user select the path of a PDf in need of watermarks. 
        // Submit the file and press GO. Once they press Go, it grabs the pdf and watermarks it, then saves it in the network folder.

        public void markPDF(string filepath, string watermark, string userfile, int fontSize, string destination)
        {
            string userWatermark = watermark;

            // If the watermark field is empty. 
            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("ERROR: No PDF selected. \n \nSelect a correct file.", "WaterPDF", MessageBoxButtons.OK);// Alert the user
            } 
            // If the path field is empty. 
            else if (string.IsNullOrEmpty(userWatermark))
            {
                MessageBox.Show("ERROR: No Watermark text. \n \nEnter text for the watermark.", "WaterPDF", MessageBoxButtons.OK);  // Alert the user. 

            } 
            // If the new filename is empty. 
            else if (string.IsNullOrWhiteSpace(userfile))
            {
                MessageBox.Show("ERROR: No save filename. \n \nEnter a save filename", "WaterPDF", MessageBoxButtons.OK); // Alert the user. 
            }
            else if (string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("ERROR : No destination. \n \nChoose a save folder.", "WaterPDF", MessageBoxButtons.OK); // Alert the user. 
            }
            else
            {
                // Creates a new file path to save the watermarked PDF.
                string newFileName = destination + @"\" + userfile + ".pdf";

                // Opens the file from the path provided.
                PdfDocument document = PdfReader.Open(filepath);

                // Counts the amount of pages in the PDF. 
                PdfPages pages = document.Pages;

                // foreach page in pdf
                // Paint the pdf and then move onto the next one?


                // Sets the first page as the page to work on. 
                PdfPage page = document.Pages[0];
                string fonts = Convert.ToString(fontSize);

                int.TryParse(fonts, out int result);
               
                // Creating the font variable. 
                XFont font = new XFont("Arial", result, XFontStyle.Regular);
                // Creating the graphics. 
                XGraphics gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Append);

                var size = gfx.MeasureString(watermark, font);

                // Creating the coordinates. 
                gfx.TranslateTransform(page.Width / 2, page.Height / 2);
                gfx.RotateTransform(-Math.Atan(page.Height / page.Width) * 180 / Math.PI);
                gfx.TranslateTransform(-page.Width / 2, -page.Height / 2);

                var format = new XStringFormat();
                format.Alignment = XStringAlignment.Near;
                format.LineAlignment = XLineAlignment.Near;

                // Creating the brush to paint with. 
                XBrush brush = new XSolidBrush(XColor.FromKnownColor(XKnownColor.LightGray));

                gfx.DrawString(watermark, font, brush,
                 new XPoint((page.Width - size.Width) / 2, (page.Height - size.Height) / 2),
                 format);

                gfx.DrawString(watermark, font, brush,
                    new XPoint((page.Width - size.Width) / 2, (page.Height - size.Height) / 2),
                    format);

                // Saves it in the provided location. 
                document.Save(newFileName);
                if (MessageBox.Show("Your PDF has been watered.", "WaterPDF") == DialogResult.OK)
                {
                    // Alerts the user that the file was saved and creates an explorer window of the destination.
                    System.Diagnostics.Process.Start("explorer.exe", destination);
                }
            }
        }
    }
}
