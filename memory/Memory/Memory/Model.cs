using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Memory
{
    class Model
    {
        private Board board;
        private Label firstClick, secondClick;
        public Board StartGame()
        {
            board = new Board();
            return board;
        }

        public List<string> ListOfIcons()
        {
            List<string> Icons = new List<string>()
            {
                "!", "!", "N", "N", ",", ",", "k", "k",
                "b", "b", "v", "v", "w", "w", "z", "z"
            };
            return Icons;
        }

        public void Click(Label label)
        {
            if (firstClick == null)
            {
                firstClick = label;
                return;
            }

            if (label != firstClick) //zabezpiecza przed możliwością wyboru dwa razy tego samego obrazka
            {
                secondClick = label;
                return;
            }         
        }

        public Label FirstClick()
        {
            if(firstClick != null)
                return firstClick;
            else
                return null;
        }

        public Label SecondClick()
        {
            if (secondClick != null)
                return secondClick; 
            else
                return null;       
        }

        public void ResetClicks()
        {
            firstClick = null;
            secondClick = null;
        }

        public Boolean CheckChoices()
        {
            return firstClick.Text.Equals(secondClick.Text);
        }

    }
}
