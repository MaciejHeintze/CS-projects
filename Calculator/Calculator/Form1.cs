using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        char wrt = ' ';
        string number, numberTwo;

        private void saveNumber(int number1)
        {
         if (wrt == ' ')
         {
                number += number1;
                textBox1.Text = number;
            }else
            {
                numberTwo += number1;
                textBox1.Text = numberTwo;
            }
            }

         
        

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveNumber(1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            saveNumber(2);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            saveNumber(3);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            saveNumber(4);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            saveNumber(5);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            saveNumber(6);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            saveNumber(7);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            saveNumber(8);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            saveNumber(9);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            saveNumber(0);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            wrt = '-';
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            wrt = '*';
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            wrt = '/';
            textBox1.Text = "";
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            wrt = '+';
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (wrt)
            {
                
                case('+'):
                    textBox1.Text = (int.Parse(number) + int.Parse(numberTwo)).ToString();
                    break;
                case ('-'):
                    textBox1.Text = (int.Parse(number) - int.Parse(numberTwo)).ToString();
                    break;
                case ('*'):
                    textBox1.Text = (int.Parse(number) * int.Parse(numberTwo)).ToString();
                    break;

                case ('/'):
                    textBox1.Text = (int.Parse(number) + int.Parse(numberTwo)).ToString();
                    break;
            }
            number = " ";
            numberTwo = " ";
            wrt = ' ';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number = " ";
            numberTwo = " ";
            wrt = ' ';
            textBox1.Text = " ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
    }










