using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.ActiveControl = tb_name;
            if (!readData())
            {
                MessageBox.Show("Could not find dane.txt file.");
                this.Close();
            }

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
                    listBox.Items.Add(new User(tb_name.Text, tb_surname.Text, (int)num.Value));
                    saveData();
                    tb_name.Text = null;
                    tb_surname.Text = null;
                    num.Value = 20;
                }
            }
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                this.ActiveControl = tb_surname;
            }
        }

        bool readData()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"data.txt");
                foreach (string element in lines)
                {
                    string[] tmp = element.Split(' ');
                    listBox.Items.Add(new User(tmp[0], tmp[1], int.Parse(tmp[2])));
                }

                return true;
            }
            catch (IOException e)
            {
                return false;
            }
        }

        void saveData()
        {
            //Console.WriteLine("ZAPISUJE");
            System.IO.StreamWriter saveData = new System.IO.StreamWriter("data.txt");
            foreach(var element in listBox.Items)
            {
                saveData.WriteLine(element);
            }
            saveData.Close();
        }

        private void b_delate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delate selected user?", "Note!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                tb_name.Text = null;
                tb_surname.Text = null;
                num.Value = 20;
                b_delate.Enabled = false;
                b_edit.Enabled = false;
                this.ActiveControl = tb_name;
                saveData();
            }

        }
        private void b_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes?", "Note!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int index = listBox.SelectedIndex;
                string newLine = tb_name + " " + tb_surname + " " + num.Value.ToString();
                listBox.Items.RemoveAt(index);
                listBox.Items.Insert(index, new User(tb_name.Text, tb_surname.Text, (int)num.Value));
                b_edit.Enabled = false;
                b_delate.Enabled = false;
                this.ActiveControl = tb_name;
                saveData();
            }               
        }

        private void tb_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.ActiveControl = num;
            }
        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            p_dodaj_Click(sender, e);
            this.ActiveControl = tb_name;
        }



        private void listBox_SelectedIndexChanged(object sender, EventArgs e) //wyrzuca wyjątek przy kliknięciu za pierwszym razem w puste pole
        {

            try
            {
                string item = listBox.SelectedItem.ToString();
                string[] tmp = item.Split(' ');
                tb_name.Text = tmp[0];
                tb_surname.Text = tmp[1];
                num.Value = decimal.Parse(tmp[2]);
                b_edit.Enabled = true;
                b_delate.Enabled = true;
            }
            catch (Exception ex) { }
        }

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
        //    //Point pt = new Point(e.X, e.Y);
        //    //int index = listBox.IndexFromPoint(pt);
        //    //if (index <= -1)
        //    //{
        //    //    return false;
        //    //}
        //    //return true; 
        }


    }
}
