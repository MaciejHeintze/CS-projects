using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatroom.Wrt
{
    class Woman : Member
    {
        public Woman(string name) : base(name) { }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: {2}", from, Name, message);
        }
        public override void Notify(string from)
        {
            Console.WriteLine("{0} gets message from: {1}", Name, from);
        }

    }
}
