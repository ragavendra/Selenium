using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    //Data for the tests can go here
    public struct Data{

        public static object[] Coordinates = {
            new object[] { "49.250494", "-123.185062" },
            new object[] { "49.226693", "-123.065819" },
            new object[] { "49.234649", "-123.156193" } 
        };

        public static object[] Pages = {    //object a = Data.Pages[0];
            new object[] { "/page/one", "Page One" },
            new object[] { "/page/two", "Page Two" }
        };
    }
}
