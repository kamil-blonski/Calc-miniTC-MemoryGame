using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Memory
{
    class Prezenter
    {
        private Model model;
        private IViev viev;
        private Random Random = new Random();
        public Prezenter(Model model, IViev viev)
        {
            this.model = model;
            this.viev = viev;
            this.viev.StartGame += StartGame;
            this.viev.AssignIconsToSquares += AssignIconsToSquares;
        }

        private void StartGame()
        {
            viev.NewBoard = model.StartGame();
        }

        private void AssignIconsToSquares(TableLayoutPanel Tlp)
        {
            List<string> Icons = model.ListOfIcons();
            Label label;
            int RandomNumber;

            for(int i = 0; i < Tlp.Controls.Count; i++)
            {
                if (Tlp.Controls[i] is Label)
                    label = (Label)Tlp.Controls[i];
                else
                    continue;
                RandomNumber = Random.Next(0, Icons.Count);
                label.Text = Icons[RandomNumber];
                Icons.RemoveAt(RandomNumber);
            }
        }
    }
}
