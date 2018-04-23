using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MementoPatternProject
{
    public partial class Form1 : Form
    {
        PersonData person;
        MementoManager[] manager;
        int count = 0;


        public Form1()
        {
            InitializeComponent();
            person = new PersonData();
            manager = new MementoManager[15];

        }

        public void displayData()
        {
            textBox1.Text = person.Name;
            textBox2.Text = person.Surname;
            textBox3.Text = person.PhoneNumber.ToString();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count < 15)
            {
                manager[count] = new MementoManager();
                manager[count].Memento = person.CreateMemento();
                count++;
                person.Name = textBox1.Text;
                person.Surname = textBox2.Text;
                person.PhoneNumber = int.Parse(textBox3.Text);
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count--;
                person.setMemento(manager[count].Memento);
                displayData();

                
            }
        }
    }
}
