using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using System.IO;
using PdfSharp.Pdf.IO;



namespace WaterPDF
{
    class PageCounter
    {
        // List<int> pageCounts = new List<int>();
        int pages; 
      public int pullPages(string filename)
        {
            //pageCounts.Clear();
            try
            {
                PdfDocument document = PdfReader.Open(filename);
                //PdfPages page = document.Pages;
                Int32 pages = document.PageCount;
                document.Close();
            }
            catch(Exception ex)
            {
                throw ex.InnerException;
            }
            return pages;
        }}}
