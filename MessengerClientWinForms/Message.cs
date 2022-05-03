using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerClientWinForms
{

    [Serializable]
    class Message
    {
        public string UserName { get; set; }
        public string MessgeText { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string userName, string messgeText, DateTime timeStamp)
        {
            this.UserName = userName;
            this.MessgeText = messgeText;
            this.TimeStamp = timeStamp;
        }
        public Message()
        {
            this.UserName = "System";
            this.MessgeText = "Server is running...";
            this.TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            string output = String.Format(" <{2}>   {0}: {1}", UserName, MessgeText, TimeStamp);
            return output;
        }
    }
}
