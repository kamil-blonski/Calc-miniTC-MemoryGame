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
    public partial class Board : UserControl, IVievBoard
    {
        public event Action<Label> Click;
        public event Action StartTimer;
        private TableLayoutPanel _TableLayoutPanel;
        private Label _firstClick, _secondClick;
        private Timer _timer;
        public Board()
        {
            InitializeComponent();
            TableLayoutPanel = tableLayoutPanel;
            Timer = timer; 
        }

        public TableLayoutPanel TableLayoutPanel
        {
            get
            {
                return _TableLayoutPanel;
            }
            set
            {
                _TableLayoutPanel = tableLayoutPanel;
            }
        }

        public Label FirstClick
        {
            set
            {
                _firstClick = value;
                if (_firstClick != null)
                    _firstClick.ForeColor = Color.Black;
            }
            get
            {
                return _firstClick;
            }
        }

        public Label SecondClick
        {
            set
            {
                _secondClick = value;
                if (_secondClick != null)
                    _secondClick.ForeColor = Color.Black;
                StartTimer();
            }
            get
            {
                return _secondClick;
            }
        }

        public Timer Timer
        {
            set
            {
                _timer = value;
            }
            get
            {
                return _timer;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer_active(object sender, EventArgs e) //dlaczego ta metoda wykonuje się dwa razy?
        {
            timer.Stop();
            timer.Enabled = false;
            Console.WriteLine("Zatrzymuje");

            if (FirstClick != null && SecondClick != null)
            {
                FirstClick.ForeColor = FirstClick.BackColor;
                SecondClick.ForeColor = SecondClick.BackColor;
                Console.WriteLine("ROBIE NULLE");
                _firstClick = null;
                _secondClick = null;
                FirstClick = null;
                SecondClick = null;
            }

        }

        private void label_Click(object sender, EventArgs e)
        {
            if (FirstClick != null && SecondClick != null)
                return;
            if (Click != null)
                Click((Label)sender);
        }
    }
}
