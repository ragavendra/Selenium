using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{

    public struct Constants
    {
        public const string browser = "chrome"; //set default browser here - chrome, msedge, firefox
        public const string environment = "qa"; //prd stg qa

        //EyesOnTransit
        public const string appURL = "https://demo.atata.io";
        public const int timeout = 500; //in milliseconds

        public const string apiKey = "apiKey";    //DEV
        public const string protocol = "https";

        public static string timestamp = DateTime.Now.ToString("yyyyMMdd_hhmmss");
        public static DateTime now = DateTime.Now;

    }

}
