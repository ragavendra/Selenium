using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
	public class Tests : TestFixture
	{

		[TestCase(TestName = "Page navigation workflow"), Order(0)]
		public void PageNavigation()
		{
			//initialize home page
			Home home = new Home(driver);
			home.plans.Click();
			wait();

			//waitn(home.gettingStarted, home.gettingStarted);
			//initialize Getting started page
			Plans plans = new Plans(driver);
			//Assert.IsTrue(gettingStarted.pageTitle.Contains("Getting Started"), "Invalid page title");
			Assert.AreEqual("Plans - Atata Sample App", plans.pageTitle, "Invalid page title");

			plans.products.Click();
			wait();

			Products products = new Products(driver);
			Assert.AreEqual("Products - Atata Sample App", products.pageTitle, "Invalid page title");

		}

		[TestCase(TestName = "User signs in workflow"), Order(1)]
		public void SignInRelativeElements()
		{
			//initialize home page
			Home home = new Home(driver);
			home.signIn.Click();
			wait();

			//waitn(home.gettingStarted, home.gettingStarted);
			//initialize Getting started page
			SignIn signIn = new SignIn(driver);
			//Assert.IsTrue(gettingStarted.pageTitle.Contains("Getting Started"), "Invalid page title");
			Assert.AreEqual("Sign In - Atata Sample App", signIn.pageTitle, "Invalid page title");

			signIn.Email.SendKeys("admin@mail.com");

			signIn.Password.SendKeys("abc123");

			wait();

			signIn.signIn_.Click();

			wait();

			Assert.AreEqual("Users - Atata Sample App", signIn.pageTitle, "Invalid page title");

			Users users = new Users(driver);
			users.New.Click();

		}

		[TestCase(TestName = "User signs in workflow - Relative web elements"), Order(2)]
		public void SignIn()
		{
			//initialize home page
			Home home = new Home(driver);
			home.signIn.Click();
			wait();

			//waitn(home.gettingStarted, home.gettingStarted);
			//initialize Getting started page
			SignIn signIn = new SignIn(driver);
			//Assert.IsTrue(gettingStarted.pageTitle.Contains("Getting Started"), "Invalid page title");
			Assert.AreEqual("Sign In - Atata Sample App", signIn.pageTitle, "Invalid page title");

			//signIn.Email1.
			//submitLocator
			//emailLocator.FindElement("");
			signIn.Email_.SendKeys("admin@mail.com");
			//signIn.Email.SendKeys("admin@mail.com");

			signIn.Password_.SendKeys("abc123");

			wait();

			signIn.signIn_1.Click();

			wait();

			Assert.AreEqual("Users - Atata Sample App", signIn.pageTitle, "Invalid page title");

			Users users = new Users(driver);
			users.New.Click();

		}

		[TestCase(TestName = "Select boxes workflow"), Order(3)]
		public void SelectBoxes()
		{

			driver.Navigate().GoToUrl("https://select2.org/getting-started/basic-usage");

			wait();

			IWebElement selectElement = driver.FindElement(By.CssSelector("html.js.csstransforms3d body.searchbox-hidden section#body div.padding.highlightable div#body-inner select.js-states.form-control"));
			var selectObject = new SelectElement(selectElement);

			// Select an <option> based upon the <select> element's internal index
			selectObject.SelectByIndex(1);

			// Select an <option> based upon its value attribute
			selectObject.SelectByValue("WA");

			// Select an <option> based upon its text
			selectObject.SelectByText("Vermont");

			// Return a List<WebElement> of options that have been selected
			var allSelectedOptions = selectObject.AllSelectedOptions;

			// Return a WebElement referencing the first selection option found by walking down the DOM
			//var firstSelectedOption = selectObject.AllSelectedOptions.FirstOrDefault();

			// Return a IList<IWebElement> of options that the <select> element contains
			IList<IWebElement> allAvailableOptions = selectObject.Options;

			foreach (var ele in allAvailableOptions)
				System.Console.WriteLine($"Select options: { ele.Text}");

			/*
			// Deselect an <option> based upon the <select> element's internal index
			selectObject.DeselectByIndex(1);

			// Deselect an <option> based upon its value attribute
			selectObject.DeselectByValue("WA");

			// Deselect an <option> based upon its text
			selectObject.DeselectByText("Vermont");

			// Deselect all selected <option> elements
			selectObject.DeselectAll();
			*/

			bool doesThisAllowMultipleSelections = selectObject.IsMultiple;
		}

		[TestCase(TestName = "Get element from elements workflow"), Order(6)]
		public void FindElements()
		{
			//initialize home page
			Home home = new Home(driver);
			home.products.Click();
			wait();

			Products products = new Products(driver);
			Assert.AreEqual("Products - Atata Sample App", products.pageTitle, "Invalid page title");
			wait();

			//IReadOnlyList<IWebElement> plants = driver.FindElements(By.TagName("td"));

			try
			{
				// Navigate to Url
				//driver.Navigate().GoToUrl("https://example.com");

				// Get all the elements available with tag name 'p'
				IList<IWebElement> elements = driver.FindElements(By.TagName("td"));
				foreach (IWebElement e in elements)
				{
					System.Console.WriteLine(e.Text);
				}

			}
			finally
			{
				//driver.Quit();

				// Get attribute of current active element
				string attr = driver.SwitchTo().ActiveElement().GetAttribute("title");

			}
		}





	}
}