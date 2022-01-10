using ChatterLibrary;
using MVVM.MS.Chatter.Core.Models;
using MVVM.MS.Chatter.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MVVM.MS.Chatter.Core.ViewModels
{
    public class ChatHistoryViewModel : ObservableObject
    {
        DataAccess data = new DataAccess();
        //public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<UsersModel> Users { get; set; }
       
        
        private ObservableCollection<MessageModel> Messages;

        public ObservableCollection<MessageModel> messages 
        {
            get { return Messages; }
            set 
            {
                Messages = value;
                OnPropertyChanged();
            }
        }

        // To do add radbryte-

        public ChatHistoryViewModel()
        {
           


            Users = new ObservableCollection<UsersModel>();

            Users = data.GetUsers();

            Messages = new ObservableCollection<MessageModel>();

            Messages = data.GetMessages();

            

        }
    }
}
