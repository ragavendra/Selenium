using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    //[TestFixture]
    public class TestFixture1
    {

		public ChromeOptions chromeOptions { get; set; }
		public IWebDriver driver;

		[SetUp]
		public void setup() {

			chromeOptions = new ChromeOptions();
			//chromeOptions.PageL
			chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
			driver = new ChromeDriver(chromeOptions);

			//var driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://atata.io");
			
			//driver.Title; // => "Google"
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
		}

		[TearDown]
		public void tear() {

            //DriverCommand.		
            driver.Quit();
        }

    }
}
