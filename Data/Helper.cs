using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatterLibrary
{
    public class Helper
    {
        public static string CnnVal(string name)
        {

           /* if (name == "AzureChatDB")
            {
                return @"ConnectionString here";
            }*
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }

    }
}
