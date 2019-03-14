using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private  char typeOfFunction;
        private String firstNumber, secondNumber;
        private String lineOfItem;
        Boolean doubleClick = false; //Prevent from wrong output for input 4+++ = 16
        List<String> listOfElements = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }
        private void b_ClickNotNumbers(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            doubleClickF(char.Parse(button.Text));
            typeOfFunction = char.Parse(button.Text);
        }
   
        private void b_Click(object sender, EventArgs e)
        {
            tb.Font = new Font("Serif", 28);
            Button button = (Button)sender;
            if (!(tb.Text == "0" && button.Text == "0"))
            {
                fillInTb(button.Text);
                doubleClick = false;
            }
        }
        private void bReset_Click(object sender, EventArgs e)
        {
            tb.Font = new Font("Serif", 28);
            tb.Text = "0";
            firstNumber = null; //Delate bug with sign change
            secondNumber = null;
            lineOfItem = null;
            typeOfFunction = 'x';
            lShowLines.Text = "";
            listOfElements.Clear();
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@ My functions

        //private void resetCalculations() // After user click = calc start working from beginign.
        //{
        //    if (firstNumber != null && secondNumber != null) //Prevent from bugs like: =->number->sign->0
        //        firstNumber = tb.Text;                       //and make sure that solution afret push '=' is the fitst sign to next caluclations
        //    else
        //        firstNumber = null;
        //    secondNumber = null;
        //    lineOfItem = null;
        //    typeOfFunction = 'x';
        //    lShowLines.Text = "";
        //    listOfElements.Clear();
        //    /*firstNumber = tb.Text;
        //    secondNumber = null;
        //    lineOfItem = null;
        //    typeOfFunction = 'x';
        //    lShowLines.Text = "";
        //    listOfElements.Clear();*/
        //}
        private void  doubleClickF(char sign)
        {
            //typeOfFunction = sign; //this instruction right there is spoil calculations
            if (!doubleClick)
            {
                whetherassignNumberStart(tb.Text);
            }
            doubleClick = true;
        }
        private void whetherassignNumberStart(string number) //fixet bug like, input: +++++6 -> firstNumber is empty, secondNumber=6
        {                                                      //also fixed bug like 6+++ = 36
            if (tb.Text != "" && tb.Text != null)
            {
                assignNumber(number);
            } 
        } 
        
        private void fillInTb(String sign) //It's useing to fill in text box with numbers inputed by user. 
        {
            lineOfItem += sign;
            tb.Text = lineOfItem;
        }

        private void assignNumber(String line) //Function decide which number is inputed.
        {
            lineOfItem = null;
            if(firstNumber == null)
            {
                firstNumber = line;
            }
            else
            {
                secondNumber = line;
                if (secondNumber != null)
                    doTheMathXd(firstNumber, secondNumber, typeOfFunction);
            }
        }

        private void bPoint_Click(object sender, EventArgs e)
        {
            tb.Font = new Font("Serif", 28);
            if (tb.Text.Contains(","))
                return;
            if (tb.Text.Equals("") || lineOfItem == null)
            {
                fillInTb("0" + bPoint.Text);
                doubleClick = false;
                return;
            }
            else
            {
                fillInTb(bPoint.Text);
                doubleClick = false;
            }
        }

        private double doTheMathXd (String firstNumber, String secondNumber, char sign)
        {
            double result = 0;
            double firstNumberH;
            double secondNumberH;
            if (!(Double.TryParse(firstNumber, out firstNumberH) && Double.TryParse(secondNumber, out secondNumberH))) //Prevent from wrong input like: 2/0=komunikat+2=bug.
            {
                return 0;
            }
            else
            {                
                if (sign.Equals('+'))
                    result = firstNumberH + secondNumberH;
                else if (sign.Equals('-'))
                    result = firstNumberH - secondNumberH;
                else if (sign.Equals('*'))
                    result = firstNumberH * secondNumberH;
                else if (sign.Equals('/'))
                {
                    if (secondNumberH == 0)
                    {
                        bReset_Click(new object(), new EventArgs());
                        tb.Font = new Font("Serif", 16);
                        tb.Text = "Nie można dzielić przez 0!";
                        return 0;
                    }
                    else
                        result = firstNumberH / secondNumberH;
                }
                else if (sign.Equals('='))
                {
                    return 0;
                }
                String help = "";
                for (int i = 0; i < listOfElements.Count(); i++)
                    help += listOfElements[i];
                lShowLines.Text = help;
                
                this.firstNumber = result.ToString();
                tb.Text = result.ToString();
            }
            return result;
        }
    }
}
