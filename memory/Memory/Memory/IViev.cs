using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Memory
{
    interface IViev
    {
        event Action StartGame;
        event Action<TableLayoutPanel> AssignIconsToSquares;
        Board NewBoard { set; get; }
    }
}
