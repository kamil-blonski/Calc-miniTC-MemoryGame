using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Model
    {
        GameEngine GameEngine;
        public Board StartGame()
        {
            GameEngine = new GameEngine();
            return GameEngine.StartGame();
        }

        public List<string> ListOfIcons()
        {
            return GameEngine.ListOfIcons();
        }

    }
}
