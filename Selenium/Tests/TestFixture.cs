﻿using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
	//[TestFixture]
	public class TestFixture1
	{

		public IWebDriver driver { get; set; }
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

			wait();
		}

		public void wait(int timeout = Constants.timeout) {
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(timeout);
		}

		//trying generics
		public R waitn<R, S>(R[] arra, S[] arra1, int index) {
			//<R> arr;
			//arra1[0] = arra[0];
			//arra.Click();
			arra.Take(index).ToString();
			arra.Skip(index).ToString();
			return arra[0];
		}

		[TearDown]
		public void tear() {

            //DriverCommand.		
            driver.Quit();
        }

    }
}
