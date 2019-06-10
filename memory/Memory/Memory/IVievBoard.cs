using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Memory
{
    interface IVievBoard
    {
        event Action<Label> Click;
        event Action StartTimer, CheckChoices, CheckIfEnd;
        TableLayoutPanel TableLayoutPanel { get; set; }
        Label FirstClick { get; set; }
        Label SecondClick { get; set; }

        Timer Timer { get; set; }
        int CorrectChoices { get; set; }
        int WrongChoices { get; set; }
        int CorrectChoicesR { get; set; }
        int WrongChoicesR { get; set; }

    }
}
