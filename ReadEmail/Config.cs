using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadEmail
{
    class Config
    {
        string cred = ConfigurationManager.AppSettings.Get("credenciais");

        public string[] tratar()
        {
            string[] creds = cred.Split(",");
            return creds;
        }
    }

}
