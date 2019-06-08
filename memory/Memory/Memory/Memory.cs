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
        public event Action<TableLayoutPanel> AssignIconsToSquares;
        private Board _NewBoard;
        public Memory()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)//Przycisk generuje plansze w gropuboxie
        {
            if (StartGame != null)
                StartGame();

            groupBox1.Controls.Add(NewBoard);

            if (AssignIconsToSquares != null)
                AssignIconsToSquares(NewBoard.TableLayoutPanel());  //zastanowić się, czy da sięjakoś inaczej dostać do tableLayoutPanel z Board
            
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
    }
}
