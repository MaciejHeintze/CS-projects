using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatroom.Wrt
{
    abstract class ChatAbst
    {
        public abstract void Send(string from, string to, string message);
        public abstract void Register(Member member);
        
    }
}
