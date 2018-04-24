using Chatroom.Wrt;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public static string nick,message;


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            message = textBox2.Text;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            message = textBox2.Text;
            Form2 form = new Form2();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nick = textBox1.Text;
        }
    }
}
