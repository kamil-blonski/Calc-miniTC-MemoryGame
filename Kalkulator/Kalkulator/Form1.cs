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

        private void bAddition_Click(object sender, EventArgs e)
        {
            doubleClickF('+');
            typeOfFunction = '+';
        }
        private void bSubtraction_Click(object sender, EventArgs e)
        {
            doubleClickF('-');
            typeOfFunction = '-';
        }
        private void bMultiplication_Click(object sender, EventArgs e)
        {
            doubleClickF('*');
            typeOfFunction = '*';
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            doubleClickF('/');
            typeOfFunction = '/';
        }
        private void bEqual_Click(object sender, EventArgs e)
        {
            doubleClickF('=');
            typeOfFunction = '=';
            resetCalculations();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            fillInTb("1");
            doubleClick = false;
        }
        private void b2_Click(object sender, EventArgs e)
        {
            fillInTb("2");
            doubleClick = false;
        }
        private void b3_Click(object sender, EventArgs e)
        {
            fillInTb("3");
            doubleClick = false;
        }
        private void b4_Click(object sender, EventArgs e)
        {
            fillInTb("4");
            doubleClick = false;
        }
        private void b5_Click(object sender, EventArgs e)
        {
            fillInTb("5");
            doubleClick = false;
        }
        private void b6_Click(object sender, EventArgs e)
        {
            fillInTb("6");
            doubleClick = false;
        }
        private void b7_Click(object sender, EventArgs e)
        {
            fillInTb("7");
            doubleClick = false;
        }
        private void b8_Click(object sender, EventArgs e)
        {
            fillInTb("8");
            doubleClick = false;
        }
        private void b9_Click(object sender, EventArgs e)
        {
            fillInTb("9");
            doubleClick = false;
        }
        private void b0_Click(object sender, EventArgs e)
        {
            fillInTb("0");
            doubleClick = false;
        }
        private void bReset_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Działą reset.");
            tb.Text = "";
            firstNumber = null;
            secondNumber = null;
            lineOfItem = null;
            typeOfFunction = 'x';
            lShowLines.Text = "";
            listOfElements.Clear();
        }
        private void lShowLines_Click(object sender, EventArgs e)
        {

        }

        //My functions

        private void  doubleClickF(char sign)
        {
            //typeOfFunction = sign; tu tego być nie może bo sie psują zwykłe działania
            Console.WriteLine("Znak : " + sign);
            if (!doubleClick)
            {
                whetherassignNumberStart(tb.Text);
                //typeOfFunction = sign;
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

        private void resetCalculations() // After user click = calc start working from beginign.
        {
            firstNumber = tb.Text;
            secondNumber = null;
            lineOfItem = null;
            typeOfFunction = 'x';
            lShowLines.Text = "";
            listOfElements.Clear();
        }
        private void fillInTb(String sign) //It's useing to fill in text box with numbers inputed by user. 
        {
            Console.WriteLine("Działa fillInTb");
            lineOfItem += sign;
            tb.Text = lineOfItem;
        }

        private void tbTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void assignNumber(String line) //Function decide which number is inputed.
        {
            Console.WriteLine("Działa assignNumber.");
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
            Console.WriteLine("Pierwsza liczba assign: " + firstNumber + " Druga liczba: " + secondNumber);
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }

        private double doTheMathXd (String firstNumber, String secondNumber, char sign)
        {
            
            double result = 0;
            Console.WriteLine("Działa doTheMathXd");
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
                        Console.WriteLine("Przez 0");
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
                tb.Text = result.ToString();
                this.firstNumber = result.ToString();
            }
            return result;
        }
    }
}
