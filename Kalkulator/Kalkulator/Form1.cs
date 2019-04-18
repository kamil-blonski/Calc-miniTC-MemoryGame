using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private  char typeOfFunction;
        private double result = 0;
        private string firstNumber, secondNumber;
        private string lineOfItem; //textbox value
        Boolean doubleClick = false; //Prevent from wrong output for input 4+++ = 16
        List<String> listOfElements = new List<String>(); //label value
        public Form1()
        {
            InitializeComponent();
            
        }
        private void b_ClickNotNumbers(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (tb.Text == "Nie można dzielić przez 0!" /*|| tb.Text == "Zbyt duża wartość!"*/)
            {
                //bReset_Click(sender, e);
                //firstNumber = null;
                //secondNumber = null;
                //result = 0;
                return;
            }
            doubleClickF(char.Parse(button.Text));
            typeOfFunction = char.Parse(button.Text);
            if (button.Text == "=")
            {
                listOfElements.Clear();
                /*string tmp = result.ToString();
                for(int i = 0; i < result.ToString().Length; i++)
                {
                    listOfElements.Add(tmp[i].ToString());
                }*/
                if (secondNumber != null)
                {
                    string tmp = result.ToString();
                    for(int i = 0; i < result.ToString().Length; i++)
                    {
                        listOfElements.Add(tmp[i].ToString());
                    }
                    //listOfElements.Add(result.ToString());
                    lInput.Text = result.ToString();
                }
                else
                {
                    listOfElements.Add(firstNumber);
                    lInput.Text = firstNumber;
                }

                return;
            }

            if(listOfElements.Count > 0)
            {
                if ((listOfElements[listOfElements.Count - 1] == "+" || listOfElements[listOfElements.Count - 1] == "-"
                || listOfElements[listOfElements.Count - 1] == "/" || listOfElements[listOfElements.Count - 1] == "*"))
                {
                    listOfElements.RemoveAt(listOfElements.Count - 1);
                    listOfElements.Add(button.Text);
                }
                else
                {
                    listOfElements.Add(button.Text);
                }
            }
            showInput();
        }
   
        private void b_Click(object sender, EventArgs e)
        {
            tb.Font = new Font("Serif", 28);
            Button button = (Button)sender;
            if (tb.Text == "Nie można dzielić przez 0!")
                tb.Text = button.ToString();

            if(typeOfFunction == '=')
            {
                //listOfElements.Clear();
                lInput.Text = tb.Text;
                Console.WriteLine("XDDD");
                bReset_Click(sender, e);
            }


            if (!(tb.Text == "0" && button.Text == "0"))
            {
                if (tb.Text.Length < 12)
                {
                    listOfElements.Add(button.Text);
                    showInput();
                    fillInTb(button.Text);
                    doubleClick = false;
                 }
                if (listOfElements.Count > 0)
                {
                    if (/*tb.Text.Length == 12 &&*/
                    (listOfElements[listOfElements.Count - 1] == "+" || listOfElements[listOfElements.Count - 1] == "-" ||
                    listOfElements[listOfElements.Count - 1] == "*" || listOfElements[listOfElements.Count - 1] == "/"))
                    {
                        listOfElements.Add(button.Text);
                        showInput();
                        fillInTb(button.Text);
                        doubleClick = false;
                    }
                }
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
            lInput.Text = "";
            listOfElements.Clear();
        }



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
            if (firstNumber != null && (typeOfFunction == '+'))
            {
                fillInTb("0,");
                listOfElements.Add("0,");
                doubleClick = false;
                showInput();
            }

            if (tb.Text.Contains(","))
                return;
            if (tb.Text.Equals("") || lineOfItem == null)
            {
                fillInTb("0" + bPoint.Text);
                listOfElements.Add("0" + bPoint.Text);
                showInput();
                doubleClick = false;
                return;
            }
            else
            {
                fillInTb(bPoint.Text);
                doubleClick = false;
                listOfElements.Add(",");
                showInput();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double doTheMathXd (String firstNumber, String secondNumber, char sign)
        {

            double firstNumberH;
            double secondNumberH;
            if (!(Double.TryParse(firstNumber, out firstNumberH) && Double.TryParse(secondNumber, out secondNumberH))) //Prevent from wrong input like: 2/0=komunikat+2=bug.
            {
                bReset_Click(new object(), new EventArgs());
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
                        result = 0;
                        listOfElements.Clear();
                        return 0;
                    }
                    else
                        result = firstNumberH / secondNumberH;
                }
                else if (sign.Equals('='))
                {
                    return 0;
                }
                //String help = "";
                //for (int i = 0; i < listOfElements.Count(); i++)
                //    help += listOfElements[i];
                //lInput.Text = help;
                Console.WriteLine("lista");
                this.firstNumber = result.ToString();
                tb.Text = result.ToString();
            }
            if (result > double.MaxValue)
            {
                bReset_Click(new object(), new EventArgs());
                tb.Font = new Font("Serif", 16);
                tb.Text = "Zbyt duża wartość!";
                result = 0;
                listOfElements.Clear();

                return 0;
            }
            else
                return result;
        }

        private void showInput()
        {
            lInput.Text = "";
            if(listOfElements.Count > 40)
            {
                for(int i = 1; i < listOfElements.Count; i++)
                {
                    listOfElements[i-1] = listOfElements[i];
                }
                listOfElements.RemoveAt(listOfElements.Count - 1);
            }
            for (int i = 0; i < listOfElements.Count; i++)
            {
                lInput.Text += (listOfElements[i]);
            }

        }
    }
}
