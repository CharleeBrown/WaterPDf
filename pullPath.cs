using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            OpenFileDialog files = new OpenFileDialog();
            files.Filter = "PDF|*.PDF";
            files.Title = "Choose a file to import";

            if (files.ShowDialog() == DialogResult.OK)
            {
                FileInfo infos = new FileInfo(files.FileName);

                mainPath = infos.FullName;
            }


            return mainPath;

        }

        public string SaveFile()
        {
            FolderBrowserDialog  folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                 savePath = folder.SelectedPath;
            }
            return savePath;


        }
    }
}
