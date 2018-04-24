using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatroom.Wrt
{
    class Chat : ChatAbst
    {
        private Dictionary<string, Member> list = new Dictionary<string, Member>();

        public override void Register(Member member)
        {
            if (!list.ContainsValue(member))
            {
                list[member.Name] = member;
            }
            member.Chatroom = this;

        }

        public override void Send(string from, string to, string message)
        {
            Member member = list[to];

            if(member != null)
            {
                member.Receive(from, message);
                member.Notify(from);
            }
        }

    }
}
