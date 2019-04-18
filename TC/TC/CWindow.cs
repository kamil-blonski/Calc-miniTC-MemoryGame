using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC
{
    public partial class CWindow : UserControl, InterfacePanelViev
    {
        public event Action LoadingDrives;
        public string CurrentPath
        {
            get
            {
                return TextBoxCurrentPath.Text;
            }
            set
            {
                TextBoxCurrentPath.Text = value;
            }
        }

        public string[] Drives
        {
            set
            {
                //Console.WriteLine("Kolejcka dysków.");
                ComboBoxDrives.Items.Clear();
                foreach (var element in value)
                    ComboBoxDrives.Items.Add(element);
            }
        }

        public CWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxDrives_MouseDown(object sender, MouseEventArgs e)
        {
            //if (LoadDrives != null)
              //  LoadDrives();
        }

        private void ComboBoxDrives_MouseClick(object sender, MouseEventArgs e)
        {
            if (LoadingDrives != null)
                LoadingDrives();
        }

        private void ComboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
