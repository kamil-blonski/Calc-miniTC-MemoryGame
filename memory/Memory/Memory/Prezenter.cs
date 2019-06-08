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
            this.viev.IVievBoard.Click += Click;
            this.viev.IVievBoard.StartTimer += StartTimer;
        }

        private void StartGame()
        {
            viev.NewBoard = model.StartGame();
        }

        private void AssignIconsToSquares()
        {
            List<string> Icons = model.ListOfIcons();
            Label label;
            int RandomNumber;

            for(int i = 0; i < viev.IVievBoard.TableLayoutPanel.Controls.Count; i++)
            {
                Console.WriteLine(i);
                if (viev.IVievBoard.TableLayoutPanel.Controls[i] is Label)
                    label = (Label)viev.IVievBoard.TableLayoutPanel.Controls[i];
                else
                    continue;
                RandomNumber = Random.Next(0, Icons.Count);
                label.Text = Icons[RandomNumber];
                Icons.RemoveAt(RandomNumber);
            }
        }

        private void Click(Label label)
        {
            model.Click(label);
            if (viev.IVievBoard.FirstClick == null)
            {
                label = model.FirstClick();
                if (label != null)
                {
                    viev.IVievBoard.FirstClick = label;
                }

                return; //Zapobiega wykonaniu kolejnego if
            }
            if(viev.IVievBoard.SecondClick == null)
            {
                label = model.SecondClick();
                if (label != null)
                {
                    viev.IVievBoard.SecondClick = label;
                    model.ResetClicks();
                }
            }
           
        }

        private void StartTimer()
        {
            viev.IVievBoard.Timer.Start();
        }
    }
}
