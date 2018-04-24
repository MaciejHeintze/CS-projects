using Chatroom.Wrt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatroom
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            Chat chat = new Chat();

            Member member1 = new Woman(Form1.nick);
            Member member2 = new Woman(Form2.nick);

            chat.Register(member1);
            chat.Register(member2);

            member1.Send(member2.ToString(), Form1.message);
            member2.Send(member1.ToString(), Form2.message);

            
        }
    }
}
