using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void p_dodaj_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
                errorProvider1.SetError(tb_name, "Empty field");
            else
            {
                errorProvider1.SetError(tb_name, "");
                if (tb_surname.Text == "")
                    errorProvider1.SetError(tb_surname, "Empty field");
                else
                {
                    errorProvider1.SetError(tb_surname, "");
                    string newLine = tb_name.Text + " " + tb_surname.Text + " " + num.Value.ToString();
                    listBox.Items.Add(newLine);
                    Console.WriteLine(newLine);
                }
            }



        }

    }
}
