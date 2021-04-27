using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefullMethods;

namespace Classes
{
    public class Message
    {
        private string MessageID { get; set; }
        private string UserName { get; set; }
        private EnumMessageContent MessageContent { get; set; }

        public Message(string i_MessageId, string i_UserName, EnumMessageContent i_MessageContent)
        {
            MessageID = i_MessageId;
            UserName = i_UserName;
            MessageContent = i_MessageContent;
        }

        public Message( string i_UserName, EnumMessageContent i_MessageContent)
        {
            MessageID = "Message_" + SystemTools.RandomString();
            UserName = i_UserName;
            MessageContent = i_MessageContent;
        }
    }

   
}
