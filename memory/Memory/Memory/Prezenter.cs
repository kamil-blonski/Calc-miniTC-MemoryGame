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
            this.viev.IVievBoard.CheckChoices += CheckChoices;
            this.viev.IVievBoard.CheckIfEnd += CheckIfEnd;
            this.viev.ResetGame += ResetGame;
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
            Console.WriteLine("Zacyznam mierzyć czas");
            viev.IVievBoard.Timer.Start();
        }

        private void CheckChoices()
        {
            if (model.CheckChoices())
            {
                viev.IVievBoard.CorrectChoices = 1;
                viev.IVievBoard.FirstClick.Enabled = false;
                viev.IVievBoard.SecondClick.Enabled = false;
                viev.IVievBoard.FirstClick = null; //czyści zmienne aby pozostawić je czarne na planszy
                viev.IVievBoard.SecondClick = null;
            }
            else
            {
                viev.IVievBoard.WrongChoices = 1;
                viev.IVievBoard.Timer.Start(); //??
            }

            viev.CorrectChoicesLabel = viev.IVievBoard.CorrectChoices.ToString();
            viev.WrongChoicesLabel = viev.IVievBoard.WrongChoices.ToString();
        }

        private void CheckIfEnd()
        {
            Label label;
            for (int i = 0; i < viev.IVievBoard.TableLayoutPanel.Controls.Count; i++)
            {
                label = (Label)viev.IVievBoard.TableLayoutPanel.Controls[i];
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            MessageBox.Show("Gratulacje! Udało Ci się dopasować wszystkie obrazki. Twój wynik procentowy udzielania poprawnych odpowiedzi to: " 
                + Math.Round(((double)viev.IVievBoard.CorrectChoices / ((double)viev.IVievBoard.CorrectChoices + (double)viev.IVievBoard.WrongChoices)), 2)*100);
            ResetGame();
        }

        private void ResetGame()
        {
            Label label;
            viev.CorrectChoicesLabel = "0";
            viev.WrongChoicesLabel = "0"; 
            viev.IVievBoard.CorrectChoicesR = 0;
            viev.IVievBoard.WrongChoicesR = 0;
            
            for (int i = 0; i < viev.IVievBoard.TableLayoutPanel.Controls.Count; i++)
            {
                label = (Label)viev.IVievBoard.TableLayoutPanel.Controls[i];
                label.Enabled = true;
                label.ForeColor = System.Drawing.Color.Chocolate;
            }
            viev.ResetB();
        }
    }
}
