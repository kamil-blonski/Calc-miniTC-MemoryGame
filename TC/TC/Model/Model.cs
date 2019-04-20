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

        private List<String> listOfFiles = new List<string>();
        private string currentPath;
        public string [] GetDrives()
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();
            return drives;
        }

        public string ChangeDrive(string selectedDrive)
        {
            currentPath = selectedDrive;
            return selectedDrive;
        }
        public string ChangingFolder(string selectedItem)
        {
            //I don't know how to stop adding a file to the path when exception is thrown in FilesInDirectory method.
            //Trying of repair:
            // 1) bool variable after throwins an exception, doesn't work because FileInDirectores method working first 
            // 2) changing of methods working order, CWIndows.cs file, doesn;t work because of null exception
            // 3) created temporary table and throwing exception earlier
            try
            {
                string[] tmp = Directory.GetDirectories(currentPath + selectedItem);
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("You have no access to this file.", "Error.", MessageBoxButtons.OK);
                return currentPath;
            }

            if (Directory.Exists(currentPath + selectedItem))
            {
                currentPath += selectedItem + "\\";
                return currentPath;
            }
            else
                return currentPath;
        }

        public string ChangeFolderBackDecision()
        {
            string tmp = currentPath;
            tmp = tmp.Remove(tmp.Length-1);
            if (tmp.LastIndexOf("\\") < 0)
                return currentPath;
            tmp = tmp.Remove(tmp.LastIndexOf("\\"));
            tmp += "\\";
            if (Directory.Exists(tmp))
            {
                currentPath = tmp;
                
                return currentPath;
            }
            else
                return currentPath;
        }

        public string [] FilesInDirectory (string selectedItem)
        {
            string[] arrayOfFiles = null, arrayOfFolders;
            if (File.Exists(currentPath + selectedItem))
            {
                MessageBox.Show("This is not a folder.", "Error", MessageBoxButtons.OK);
                return listOfFiles.ToArray();
            }
            else if (Directory.Exists(currentPath))
            {
                arrayOfFiles = Directory.GetDirectories(currentPath);
                arrayOfFolders = Directory.GetFiles(currentPath);
                 listOfFiles.Clear();
                foreach (string element in arrayOfFiles)
                    listOfFiles.Add(Path.GetFileName(element));
                foreach (string element in arrayOfFolders)
                    listOfFiles.Add(Path.GetFileName(element));
                return listOfFiles.ToArray();
            }
            else
            {
                MessageBox.Show("This is not a folder.", "Error", MessageBoxButtons.OK);
                return listOfFiles.ToArray();
            }
        }
    }
}
