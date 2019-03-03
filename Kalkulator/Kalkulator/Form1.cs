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
        List<String> listOfElements = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bAddition_Click(object sender, EventArgs e)
        {
            assignNumber(tb.Text);
            typeOfFunction = '+';
        }
        private void bSubtraction_Click(object sender, EventArgs e)
        {
            assignNumber(tb.Text);
            typeOfFunction = '-';

        }
        private void bMultiplication_Click(object sender, EventArgs e)
        {
            assignNumber(tb.Text);
            typeOfFunction = '*';
        }

        private void bDivision_Click(object sender, EventArgs e)
        {
            assignNumber(tb.Text);
            typeOfFunction = '/';
            
        }
        private void bEqual_Click(object sender, EventArgs e)
        {
            assignNumber(tb.Text);
            typeOfFunction = '=';
            bReset_Click(sender, e);
            //wywołanie funkcji z działaniem
        }

        private void b1_Click(object sender, EventArgs e)
        {
            fillInTb("1");
        }
        private void b2_Click(object sender, EventArgs e)
        {
            fillInTb("2");
            
        }
        private void b3_Click(object sender, EventArgs e)
        {
            fillInTb("3");
            
        }
        private void b4_Click(object sender, EventArgs e)
        {
            fillInTb("4");
            
        }
        private void b5_Click(object sender, EventArgs e)
        {
            fillInTb("5");
            
        }
        private void b6_Click(object sender, EventArgs e)
        {
            fillInTb("6");
           
        }
        private void b7_Click(object sender, EventArgs e)
        {
            fillInTb("7");
            
        }
        private void b8_Click(object sender, EventArgs e)
        {
            fillInTb("8");

        }
        private void b9_Click(object sender, EventArgs e)
        {
            fillInTb("9");
            
        }
        private void b0_Click(object sender, EventArgs e)
        {
            fillInTb("0");
            
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
        }
        private void lShowLines_Click(object sender, EventArgs e)
        {

        }
        //My functions

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



        private double doTheMathXd (String firstNumber, String secondNumber, char sign)
        {
            if (firstNumber == "" || secondNumber == "") //Prevent from bug when user start with push + / - buttons several times.
                return 0;                                //Prevent also from input 7+++ is equal 28.
            listOfElements.Add(firstNumber);
            listOfElements.Add(secondNumber);
            listOfElements.Add(sign.ToString());
            Console.WriteLine("Działa doTheMathXd");
            double firstNumberH = Double.Parse(firstNumber);
            double secondNumberH = Double.Parse(secondNumber);
            //Console.WriteLine("Pierwsza liczba doTheMath: " + firstNumberH + " Druga liczba: " + secondNumberH);
            double result = 0;
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
            else if(sign.Equals('=')) 
            {
                return 0;
            }
            String help = "";
            for (int i = 0; i < listOfElements.Count(); i++)
                help += listOfElements[i];
            lShowLines.Text = help;
            tb.Text = "";
            tbTest.Text = result.ToString();
            this.firstNumber = result.ToString();
            return result;
        }
    }
}
