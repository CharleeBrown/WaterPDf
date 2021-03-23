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
    }
}
