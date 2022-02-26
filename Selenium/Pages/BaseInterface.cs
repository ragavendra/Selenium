using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium
{
    interface BaseInterface
    {

        public void setup();
        public string str { get; set; }
        public IWebDriver driver { get; set; }

        public string pageTitle => driver.Title;
    }
}
