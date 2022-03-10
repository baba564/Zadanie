using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport
{
   public class UserSetting
    {
        public static string ConnString { get; set; }
        public static void LoadSetting()
        {
            //podaj tutaj swój ConnString
            ConnString = @"data source=LAPTOP-66N0E4CF\SQLEXPRESS;initial catalog=TEST;integrated security=True";
        }


    }
}
