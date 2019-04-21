using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC.ModelNS;
using TC.VievNS;

namespace TC.PresenterNS
{
    class Presenter
    {
        InterfaceViev viev;
        Model model;
        PresenterPanel leftPanelPresenter;
        PresenterPanel rightPanelPresenter;
        public Presenter (Model model, InterfaceViev viev)
        {
            this.model = model;
            this.viev = viev;
            leftPanelPresenter = new PresenterPanel(viev.Left, model);
            rightPanelPresenter = new PresenterPanel(viev.Right, model);
            this.viev.CopyItem += Viev_CopyItem;
        }

        public void Viev_CopyItem(bool selectedButton)
        {
            
            bool copyOperation = false;
            if (selectedButton)
            {
                copyOperation = model.CopyItem(viev.Right.CurrentPath, viev.Left.CurrentPath, viev.Right.SelectedItem);
            }
            else
            {
                copyOperation = model.CopyItem(viev.Left.CurrentPath, viev.Right.CurrentPath, viev.Left.SelectedItem);
            }
            if (copyOperation)
            {
                viev.Right.FilesInDirectory = model.FilesInDirectory(viev.Right.CurrentPath);
            }
        }
    }
}
