using System;
using System.Text;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections;

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

			//take screen
			plans.TakeScreen(TestContext.CurrentContext.Test.Name);

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

		[TestCase(TestName = "Learning Extension methods and immutable types"), Order(7)]
		public static void immutable()
		{
			string s = "Hello Extension Methods";

			//extension method for string
			int inte = s.WordCount(); //from class Extension in Attribute.cs file

			int p = s.AasInString();

			int aaa = 300;
			//aaa.square
			int q = aaa.DecimalCount();

			q = aaa.square();

			Console.WriteLine(q);

			//string type is immutable meaning every value assignment
			// to it creates in new memory increasing garbage collection
			string test = "this is sample str";

			//can freeze VS
			for (int i = 0; i < 10; i++)
				test = test + test;

			//we can use StringBuilder class in Sys...Text instead of string
			// which is mutable and uses the same memo for string updates
			StringBuilder sample = new StringBuilder();
			//sample = "hi";
			sample.Append("hi");


			//can freeze VS
			for (int i = 0; i < 10; i++)
				sample.Append(sample);

			//sample mutable var
			Mutable test1 = new Mutable("test");
			string yes = test1.getStr;

			//nested class
			Extension.subclass.sublass2 sub2 = new Extension.subclass.sublass2();
			sub2.var1 = 3;

		}

		/*
		[TestCase(TestName = "Page navigation workflow zero"), Order(8)]
		public void PageNavigation0()
		{

			OomaLogin login = new OomaLogin(driver);
			login.username.SendKeys("15043008172");
			login.password.SendKeys("password1");

			login.loginButton.Click();

			Hashtable extName = new Hashtable();

			OomaExtensions ext = new OomaExtensions(driver);
			try
			{
				for (int row = 0; row < 10; row++) {
					for (int col = 0; col < 2; col++)
					{
						extName.Add(ext.extension(row.ToString(), col.ToString()).GetProperty("text"), ext.name(row.ToString(), col.ToString()).GetProperty("text"));
						//extName.Add()
						extName.Add("name1", 10);
					}
				}
			}
			catch { 
			}

			//HashSet abc = new HashSet();
			//List<string> list = new List<string>();
			//list.Add

			//Hashtable sample = new Hashtable();
			//Directory 
			//sample.Add();

		}
*/
		/*
		 * 
		 * Write a function which:
- prints names of all people who has age 30 
- count of people who is younger than 30 
- count of people who is older than 30 
Ex.: {"Anna" => 18, "Brian" => 45, "Megan" => 30, "John" => 31, "Mary" => 30, "Sam" => 7, "Angel" => 50)
		 * */
/*
		[TestCase(TestName = "30 and greater"), Order(0)]
		public void PageNavigation1()
		{
			Hashtable nameNumber = new Hashtable();
			nameNumber.Add("Anna", 18);
			nameNumber.Add("Brian", 45);
			nameNumber.Add("Megan", 30);
			nameNumber.Add("John", 31);
			nameNumber.Add("Mary", 30);
			nameNumber.Add("Sam", 7);
			nameNumber.Add("Angel", 50);

			nameNumber.ContainsValue(3);

			int greater = 0;
			int lesser = 0;

			foreach (DictionaryEntry de in nameNumber)
			{

				int a = int.Parse(de.Value.ToString());

				if (a > 30)
					greater++;
				else if (a < 30)
					lesser++;
				else if (a == 30)
					Console.WriteLine(de.Key + " is 30");
				
			}

			Console.WriteLine("No of people above 30 " + greater);
			Console.WriteLine("No of people less than 30 " + lesser);

		}

*/



	}
}
