using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Internal;
using PdfSharp.Fonts;
using PdfSharp.Drawing;
using PdfSharp.Charting;
using PdfSharp.SharpZipLib;
using PdfSharp.Pdf.IO;
using System.Windows.Forms;


namespace WatermarkAdd
{
    class getPDF
    {

        // The end goal is to have a user select the path of a PDf in need of watermarks. 
        // Submit the file and press GO. Once they press Go, it grabs the pdf and watermarks it, then saves it in the network folder.

        public void markPDF(string filepath, string watermark, string userfile, int fontSize)
        {

            
            string destination = @"J:\Groups\QA\Watermarked PDFs";
            
           // string defaultWatermark = "Extracted, with permission, from the Annual Book of ASTM Standards, copyright ASTM Internatinal, 100 Barr Harbor Drive, West Conshohocken, PA 19428";
            string userWatermark = watermark;

            


            
            if (string.IsNullOrEmpty(userWatermark))
            {
                MessageBox.Show("Enter text for the watermark.", "WaterPDF"); 
            }
            else if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Select a file.", "WaterPDF");
            }
            else if (string.IsNullOrWhiteSpace(userfile))
            {
                MessageBox.Show("Enter a filename", "WaterPDF");
            }
            else
            {
                string newFileName = destination + @"\" + userfile + ".pdf";
                PdfDocument document = PdfReader.Open(filepath);

                int pages = document.Pages.Count;
                PdfPage page = document.Pages[0];
                XFont font = new XFont("Arial", fontSize, XFontStyle.Regular);

                XGraphics gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Append);

                var size = gfx.MeasureString(watermark, font);

                gfx.TranslateTransform(page.Width / 2, page.Height / 2);
                gfx.RotateTransform(-Math.Atan(page.Height / page.Width) * 180 / Math.PI);
                gfx.TranslateTransform(-page.Width / 2, -page.Height / 2);

                var format = new XStringFormat();
                format.Alignment = XStringAlignment.Near;
                format.LineAlignment = XLineAlignment.Near;

                XBrush brush = new XSolidBrush(XColor.FromKnownColor(XKnownColor.Gray));

                gfx.DrawString(watermark, font, brush,
                 new XPoint((page.Width - size.Width) / 2, (page.Height - size.Height) / 2),
                 format);

                //string filename = @"C:\Users\hallocol\Desktop\test2.pdf";
                

                gfx.DrawString(watermark, font, brush,
                    new XPoint((page.Width - size.Width) / 2, (page.Height - size.Height) / 2),
                    format);
                document.Save(newFileName);
                if(MessageBox.Show("Your PDF has been watered.", "WaterPDF") == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("explorer.exe", @"J:\Groups\QA\Watermarked PDFs");
                }
               
            }
           
        }
    }
}
