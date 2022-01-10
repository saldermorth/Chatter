using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.MS.Chatter.Core.Models
{
    public class MessageModel
    {
        public DateTime TimeWritten { get; set; }
        public string ActiveMessage { get; set; }
        public string UserAlias { get; set; }
        public string NameDate{ get; set; }
        private string _nameDate(MessageModel o)        {
                        
            return $"{o.UserAlias} : {o.TimeWritten.ToShortTimeString()}";
                
        }

       
    
        public MessageModel(DateTime timeWritten, string activeMessage, string userAlias)
        {
            TimeWritten = timeWritten;
            ActiveMessage = activeMessage;
            UserAlias = userAlias;
            NameDate = _nameDate(this);
        }
    }
}
