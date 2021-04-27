using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefullMethods;

namespace Classes
{
   public class Chat
    {
        private string ChatID { get; set; }
        private List<Message> Messages { get; set; }

        public Chat()
        {
            ChatID = "Chat_" + SystemTools.RandomString();
            Messages = new List<Message>(50);
        }


    }
}
