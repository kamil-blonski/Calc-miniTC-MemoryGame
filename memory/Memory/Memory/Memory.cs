using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Memory : Form, IViev
    {
        public event Action StartGame;
        public event Action AssignIconsToSquares;
        private Board _NewBoard;
        private TableLayoutPanel _TableLayoutPanel;
        public Memory()
        {
            InitializeComponent();
            board1.Enabled = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)//Przycisk generuje plansze w gropuboxie
        {
            /*if (StartGame != null)
                StartGame();

            groupBox1.Controls.Add(NewBoard);*/ //w jaki sposób odwołać się do dynamicznie utworzonego user control? Przykład metoda IViev.IVievBoard
            board1.Enabled = true;
            if (AssignIconsToSquares != null)
                AssignIconsToSquares();  //zastanowić się, czy da sięjakoś inaczej dostać do tableLayoutPanel z Board
            
        }

        public Board NewBoard
        {
            set
            {
               _NewBoard = value;
            }
            get
            {
                return _NewBoard;
            }
        }

        public TableLayoutPanel TableLayoutPanel
        {
            set
            {
                _TableLayoutPanel = value;
            }
            get
            {
                return _TableLayoutPanel;
            }
        }

       IVievBoard IViev.IVievBoard
        {
            get
            {
                return board1;
            }
        }
    }
}
