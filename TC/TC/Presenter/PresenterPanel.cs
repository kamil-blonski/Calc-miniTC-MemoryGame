using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC.ModelNS;
using TC.VievNS;

namespace TC.PresenterNS
{
    class PresenterPanel
    {
        InterfacePanelViev panel;
        Model model;
        public PresenterPanel(InterfacePanelViev panel, Model model)
        {
            //Console.WriteLine("Konstruktor PresenterPanel");
            this.panel = panel;
            this.model = model;
            this.panel.LoadingDrives += Panel_LoadDrives; //wywołanie tego z () i bez () ??

        }

        public void Panel_LoadDrives()
        {
            panel.Drives = model.GetDrives();
        }

    }
}
