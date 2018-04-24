using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatroom.Wrt
{
    abstract class Member
    {
        private string name;

        public string Name
        {
            get { return name; }
        }

        private ChatAbst chatroom;
        public ChatAbst Chatroom
        {
            set { chatroom = value; }
            get { return chatroom; }
        }

        public Member(string name)
        {
            this.name = name;
        }

        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        public abstract void Receive(string from, string message);
        public abstract void Notify(string from);


    }
}
