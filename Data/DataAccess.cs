using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MVVM.MS.Chatter.Core.Models;
using Dapper;
using MVVM.MS.Chatter.Models;
using System.Collections.ObjectModel;

namespace ChatterLibrary
{
    public class DataAccess
    {

        public ObservableCollection<UsersModel> GetUsers()
        {
            List<UsersModel> output;
            var myObservableCollection = new ObservableCollection<UsersModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AzureChatDB")))
            {
                output = connection.Query<UsersModel>("Usp_GetUsers").ToList();
                myObservableCollection = new ObservableCollection<UsersModel>(output);
            }

            return myObservableCollection;
        }
        public ObservableCollection<MessageModel> GetMessages()
        {
            List<MessageModel> output;
            var myObservableCollection = new ObservableCollection<MessageModel>();

           


            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AzureChatDB")))
            {
                //var p = new DynamicParameters();
                //p.Get("@Alias",message, )
                output = connection.Query<MessageModel>("dbo.ChatHistoryGetAllActive").ToList();
                myObservableCollection = new ObservableCollection<MessageModel>(output);
            }

            return myObservableCollection;
        }
      
      
        //public  void UploadMessage(MessageModel newMessage)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AzureChatDB")))
        //    {

        //        var p = new DynamicParameters();
        //        p.Add("@TimeWritten", newMessage.TimeWritten);
        //        p.Add("@ActiveMessage", newMessage.ActiveMessage);
        //        p.Add("@UserAlias", newMessage.UserAlias);
                             
        //        connection.Execute("[dbo].[ChatInsert]", p, commandType: CommandType.StoredProcedure);
               

        //        //connection.Query($"Insert into ChattHistory (TimeWritten, @ActiveMessage, @UserAlias) " +
        //           // $"values({newMessage.TimeWritten}, {newMessage.ActiveMessage}, {newMessage.UserAlias})");
        //    }

        //}
        //public List<string> UpdateChatWindow(int listWidth)
        //{
           
        //    List<String> messages = new List<string>();
        //    List<MessageModel> MessagesInList = GetMessages();
        //    foreach (var item in MessagesInList)
        //    {
        //        messages.Add(" -"+ item.TimeWritten.ToShortTimeString()+ "-" + item.UserAlias + "- ");
                
        //        if (item.ActiveMessage.Length > listWidth)
        //        {
        //            int chunkSize = listWidth-1;
        //            int stringLength = item.ActiveMessage.Length;
        //            for (int i = 0; i < stringLength; i += chunkSize)
        //            {
        //                if (i + chunkSize > stringLength) chunkSize = stringLength - i;
        //                messages.Add(item.ActiveMessage.Substring(i, chunkSize));
        //            }
        //        }
        //        else
        //        {
        //            messages.Add(item.ActiveMessage);
        //        }
                
                
               
        //        messages.Add("                                             ");
        //    }

        //    return messages;
        //}
      
    }
}
