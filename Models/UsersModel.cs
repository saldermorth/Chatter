using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.MS.Chatter.Models
{
    public class UsersModel
    {
        private string Alias;

        public UsersModel()
        {

        }
        public string _alias
        {
            get { return Alias; }
            set { Alias = value; }
        }

        private bool  IsOnline;

        public bool  _isOnline
        {
            get { return IsOnline; }
            set { IsOnline = value; }
        }

    }
}
