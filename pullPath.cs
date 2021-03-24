using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;




namespace WatermarkAdd
{
    class pullPath
    {
        string savePath;
        string mainPath;
        public string GetFile()
        {
            // Opens the file dialog that only looks for PDFs. 
            OpenFileDialog files = new OpenFileDialog();
            files.Filter = "PDF|*.PDF";
            files.Title = "Choose a file to import";

            // If the file is ok. 
            if (files.ShowDialog() == DialogResult.OK)
            {
                // Pull the filename and put it into the textbox. 
                FileInfo infos = new FileInfo(files.FileName);

                // Set the variable to the file name. 
                mainPath = infos.FullName;
            }

            // Return the filename variable. 
            return mainPath;

        }

        public string SaveFile()
        {
            // Opens the folder browswer dialog. 
            FolderBrowserDialog folder = new FolderBrowserDialog();

            // If the folder is ok. 
            if (folder.ShowDialog() == DialogResult.OK)
            {
                // Set the variable to the folder path. 
                savePath = folder.SelectedPath;
            }
            // return the folder path variable. 
            return savePath;
        }

        public List<Int32> GetPages(string filePath)
        {
            List<Int32> pageCount = new List<Int32>();
            FileInfo infos = new FileInfo(filePath);

            PdfDocument doc = new PdfDocument(infos.FullName);
            var count = doc.Pages.Count;
            for (int i = 0; i < count; i++)
            {
                pageCount.Add(i);
            }
            return pageCount;
        }
    }
}
