using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace EasyProjects.Client.Test
{
    static class Global
    {
        public static string BaseAddress
        {
            get {
                return ConfigurationManager.AppSettings["baseUrl"];
            }
        }

        public static string Username
        {
            get
            {
                return ConfigurationManager.AppSettings["username"];
            }
        }

        public static string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["password"];
            }
        }

    }
}
