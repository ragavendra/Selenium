using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    //[TestFixture]
    public class TestFixture1
    {

		public IWebDriver driver;
		//public ChromeOptions chromeOptions { get; set; }

		[SetUp]
		public void setup() {

			//select and config the browser
			switch (Constants.browser)
			{
				case "chrome":
					ChromeOptions chromeOptions;
					chromeOptions = new ChromeOptions();
					chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
					driver = new ChromeDriver(chromeOptions);
					break;
				case "msedge":
					//code for MS Edge browser
					//Console.WriteLine("Add code for MS Edge browser");
					break;
				case "default":
					//code for unidentified browser
					break;
			}

			//var driver = new ChromeDriver();
			driver.Navigate().GoToUrl(Constants.appURL);
			
			//driver.Title; // => "Google"
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(Constants.timeout);
		}

		[TearDown]
		public void tear() {

            //DriverCommand.		
            driver.Quit();
        }

    }
}
