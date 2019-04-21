using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC.ModelNS;
using TC.VievNS;
using TC;

namespace TC.PresenterNS
{
    class PresenterPanel
    {
        InterfacePanelViev viev;
        Model model;
        public PresenterPanel(InterfacePanelViev viev, Model model)
        {
            //Console.WriteLine("Konstruktor PresenterPanel");
            this.viev = viev;
            this.model = model;
            this.viev.LoadingDrives += Viev_LoadDrives; 
            this.viev.ChangingDrive += Viev_ChangeDrive;
            this.viev.ShowFilesInDirectory += Viev_ShowFilesInDirectory;
            this.viev.ChangingFolder += Viev_ChangingFolder;
            this.viev.ChangingFolderBack += Viev_ChangingFolderBack;
        }

        public void Viev_LoadDrives()
        {
            viev.Drives = model.GetDrives();
        }

        public void Viev_ChangeDrive(string selectedDrive)
        {
            viev.CurrentPath = model.ChangeDrive(selectedDrive);
        }

        public void Viev_ShowFilesInDirectory(string selectedItem)
        {
            viev.FilesInDirectory = model.FilesInDirectory(selectedItem);
        }
        public void Viev_ChangingFolder(string selectedFolder)
        {
            viev.CurrentPath = model.ChangingFolder(selectedFolder);
        }
        public void Viev_ChangingFolderBack()
        {
            viev.CurrentPath = model.ChangeFolderBackDecision();
            viev.FilesInDirectory = model.FilesInDirectory(viev.CurrentPath);
        }
    }
}
