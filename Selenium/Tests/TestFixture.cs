using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    //[TestFixture]
    public class TestFixture
    {

        private IWebDriver _driver;
        //public ChromeOptions chromeOptions { get; set; }

        public IWebDriver Driver { get => _driver; set => _driver = value; }

        [SetUp]
        public void setup()
        {

            //select and config the browser
            switch (Constants.browser)
            {
                case "chrome":
                    ChromeOptions chromeOptions;
                    chromeOptions = new ChromeOptions();
                    chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;

                    //for headless
                    if (Constants.headless)
                        chromeOptions.AddArgument("--headless");
                    //chromeCapabilities.set('chromeOptions', {args: ['--headless']});

                    _driver = new ChromeDriver(chromeOptions);
                    break;
                case "msedge":
                    //code for MS Edge browser
                    //add necessary package like Selenium.Webriver.IEDriver for other browser in nuget
                    //add case for each browsers here and set default one in the Constans.cs file
                    //Console.WriteLine("Add code for MS Edge browser");
                    break;
                case "default":
                    //code for unidentified browser
                    break;
            }

            //var driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(Constants.appURL);

            hardWait();
        }

        public void hardWait(int timeout = Constants.timeout)
        {
            // _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(timeout);
            Thread.Sleep(timeout);
        }

        //the default time the driver waits when trying to find each element 
        public void setImplicitWait(int timeout = Constants.timeout)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(timeout);
        }

        //trying generics
        public R waitn<R, S>(R[] arra, S[] arra1, int index)
        {
            //<R> arr;
            //arra1[0] = arra[0];
            //arra.Click();
            arra.Take(index).ToString();
            arra.Skip(index).ToString();
            return arra[0];
        }

        [TearDown]
        public void tear()
        {

            //DriverCommand.		
            _driver.Quit();
        }

    }
}
