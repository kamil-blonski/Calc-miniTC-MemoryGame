using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Memory
{
    class GameEngine //komunikacja tylko z modelem
    {
        private List<string> Icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        private Label FirstClicked, SecondClicked;


        public Board StartGame()
        {
            return new Board();
        }

        public List<string> ListOfIcons()
        {
            return Icons;
        }
    }
}
