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
        private Random random = new Random();
        public Board StartGame()
        {
            board = new Board();
            return board;
        }

        public List<string> ListOfIcons()
        {

            List<char> Characters = new List<char>()
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n' ,'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            /*"!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"*/

            List<string> Icons = new List<string>();
            int RandomNumber;
            for(int i = 0; i < 8; i++)
            {
                RandomNumber = random.Next(0, Characters.Count);
                Icons.Add(Characters[RandomNumber].ToString());
                Icons.Add(Characters[RandomNumber].ToString());
                Characters.RemoveAt(RandomNumber);
            }
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
