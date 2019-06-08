using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Board : UserControl
    {
        public Board()
        {
            //Dock = fill - autodopasowanie tabelki do okna kontrolki
            //Console.WriteLine("LOADING board ... ");
            InitializeComponent();
            //TableLayoutPanel TLP = new TableLayoutPanel();
            
        }

        public TableLayoutPanel TableLayoutPanel()
        {
            return tableLayoutPanel;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
