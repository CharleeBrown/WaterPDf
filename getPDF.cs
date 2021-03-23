using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Internal;
using System.Diagnostics;
using PdfSharp.Fonts;
using PdfSharp.Drawing;
using PdfSharp.Charting;
using PdfSharp.SharpZipLib;
using PdfSharp.Pdf.IO;
using System.Windows.Forms;
using System.IO;


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
            if (string.IsNullOrEmpty(userWatermark))
            {
                MessageBox.Show("Enter text for the watermark.", "WaterPDF");  // Alert the user. 

            }
            // If the path field is empty. 
            else if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Select a file.", "WaterPDF");// Alert the user
            }
            // If the new filename is empty. 
            else if (string.IsNullOrWhiteSpace(userfile))
            {
                MessageBox.Show("Enter a filename", "WaterPDF"); // Alert the user. 
            }
            else if (string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Select a save destination"); // Alert the user. 
            }
            else
            {
                // Creates a new file path to save the watermarked PDF.
                string newFileName = destination + @"\" + userfile + ".pdf";
                

                // Opens the file from the path provided.
                PdfDocument document = PdfReader.Open(filepath);

                // Counts the amount of pages in the PDF. 
                int pages = document.Pages.Count;

                // Sets the first page as the page to work on. 
                PdfPage page = document.Pages[0];

                // Creating the font variable. 
                XFont font = new XFont("Arial", fontSize, XFontStyle.Regular);

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
