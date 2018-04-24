using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatroom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public static string nick, message;

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.message;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            message = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nick = textBox1.Text;
        }
    }
}
