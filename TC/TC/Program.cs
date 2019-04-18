using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TC.ModelNS;
using TC.VievNS;
using TC.PresenterNS;
namespace TC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model model = new Model();
            InterfaceViev view = new Form1();
            Presenter presenter = new Presenter(model, view);
            Application.Run((Form)view);
            //PYTANIE NR 1: Dlaczego twprzymy obiekt Form1 typu interfejsu widoku?
            //Pytanie nr 3: dlaczego to nie działało:
            //Presenter presenter = new Presenter(new Model(), new Form1());
            //Application.Run(new Form1());
        }
    }
}
