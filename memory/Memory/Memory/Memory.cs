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
        public event Action ResetGame;
        public event Action AssignIconsToSquares;
        private Board _NewBoard;
        private TableLayoutPanel _TableLayoutPanel;
        public Memory()
        {
            InitializeComponent();
            board1.Visible = false;
            ButtonReset.Enabled = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            /*if (StartGame != null)
                StartGame();
            groupBox1.Controls.Add(NewBoard);*/ //w jaki sposób odwołać się do dynamicznie utworzonego user control? Przykład metoda IViev.IVievBoard
            ButtonReset.Enabled = true;
            ButtonStart.Enabled = false;
            board1.Visible = true;
            if (AssignIconsToSquares != null)
                AssignIconsToSquares(); 
            
        }

        public Board NewBoard {
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
        public string CorrectChoicesLabel
        { get
            {
                return LabelCorrectChoice.Text;
            }
            set
            {
                LabelCorrectChoice.Text = value;
            }
        }
        public string WrongChoicesLabel
        {
            get
            {
                return LabelWrongChoice.Text;
            }
            set
            {
                LabelWrongChoice.Text = value;
            }
        }
        public void ResetB()
        {
            ButtonReset.Enabled = false;
            ButtonStart.Enabled = true;
            board1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            board1.Visible = false;
            ButtonStart.Enabled = true;
            ButtonReset.Enabled = false;
            if (ResetGame != null)
                ResetGame();
        }
    }
}
