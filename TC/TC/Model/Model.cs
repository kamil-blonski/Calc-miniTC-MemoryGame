using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace TC.ModelNS
{
    public class Model
    {
        public string [] GetDrives()
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();
            return drives;
        }

        public string ChangePath(string selectedDrive)
        {
            string currentPath = " ";
            currentPath += selectedDrive;
            return selectedDrive;
        }

        public string [] FilesInDirectory (string path)
        {
            string[] arrayOfFiles = Directory.GetFiles(path);
            List<String> listOfFiles = new List<string>();
            foreach (string element in arrayOfFiles)
                listOfFiles.Add(element);
            arrayOfFiles = Directory.GetDirectories(path);
            foreach (string element in arrayOfFiles)
                listOfFiles.Add(element);
            return listOfFiles.ToArray();
        }

    }
}
