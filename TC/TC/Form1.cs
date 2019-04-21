using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TC.VievNS;

namespace TC
{
    public partial class Form1 : Form, InterfaceViev
    {
        public Form1()
        {
            InitializeComponent();
        }

        public new InterfacePanelViev Left
        {
            get
            {
                return ControlLeftPanel;
            }
        }

        public new InterfacePanelViev Right
        {
            get
            {
                return ControlRightPanel;
            }
        }

        public event Action <bool> CopyItem;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void ButtonCopyToLeft_Click(object sender, EventArgs e)
        {
            if (CopyItem != null)
                CopyItem(true);
        }

        private void ButtonCopyToRight_Click(object sender, EventArgs e)
        {
            if (CopyItem != null)
                CopyItem(false);
        }
    }
}
