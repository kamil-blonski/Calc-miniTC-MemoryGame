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
            this.viev.LoadingDrives += Viev_LoadDrives; //wywołanie tego z () i bez () ??
            this.viev.ChangingDrive += Viev_ChangeDrive;
            this.viev.ShowFilesInDirectory += Viev_ShowFilesInDirectory;

        }

        public void Viev_LoadDrives()
        {
            viev.Drives = model.GetDrives();
        }

        public void Viev_ChangeDrive(string selectedDrive)
        {
            viev.CurrentPath = model.ChangePath(selectedDrive);
        }

        public void Viev_ShowFilesInDirectory(string directory)
        {
            viev.FilesInDirectory = model.FilesInDirectory(directory);
        }
    }
}
