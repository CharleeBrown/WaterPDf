using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.IO;
using System.Windows.Forms;


namespace WaterPDF
{
    class multiPagePDF
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
                if (File.Exists(filepath)){
                    // Creates a new file path to save the watermarked PDF.
                    string newFileName = destination + @"\" + userfile + ".pdf";


                    //PdfPasswordProvider provider;
                    // Opens the file from the path provided.
                    PdfDocument document = PdfReader.Open(filepath, PdfDocumentOpenMode.Modify );

                    // Counts the amount of pages in the PDF. 
                    PdfPages pages = document.Pages;

                    // foreach page in pdf
                    // Paint the pdf and then move onto the next one?
                    foreach (PdfPage pager in pages)
                    {
                        // Creating the font variable. 
                        XFont font = new XFont("Arial", fontSize, XFontStyle.Regular);

                        // Creating the graphics. 
                        XGraphics gfx = XGraphics.FromPdfPage(pager, XGraphicsPdfPageOptions.Append);
                        var size = gfx.MeasureString(watermark, font);

                        // Creating the coordinates. 
                        gfx.TranslateTransform(pager.Width / 2, pager.Height / 2);
                        gfx.RotateTransform(-Math.Atan(pager.Height / pager.Width) * 180 / Math.PI);
                        gfx.TranslateTransform(-pager.Width / 2, -pager.Height / 2);

                        var format = new XStringFormat();
                        format.Alignment = XStringAlignment.Near;
                        format.LineAlignment = XLineAlignment.Near;

                        // Creating the brush to paint with. 
                        XBrush brush = new XSolidBrush(XColor.FromKnownColor(XKnownColor.DimGray));

                        gfx.DrawString(watermark, font, brush,
                         new XPoint((pager.Width - size.Width) / 2, (pager.Height - size.Height) / 2),
                         format);

                        gfx.DrawString(watermark, font, brush,
                            new XPoint((pager.Width - size.Width) / 2, (pager.Height - size.Height) / 2),
                            format);
                    }
                    // Sets the first page as the page to work on. 
                    //  PdfPage page = document.Pages[0];
                    // Saves it in the provided location. 
                    document.Save(newFileName);
                    if (MessageBox.Show("Your PDF has been watered.", "WaterPDF") == DialogResult.OK)
                    {
                        // Alerts the user that the file was saved and creates an explorer window of the destination.
                        System.Diagnostics.Process.Start("explorer.exe", destination);
                    }
                }
                else
                {
                    MessageBox.Show("File Incorrect. Choose new file");
                }
            }
        }
    }
}



