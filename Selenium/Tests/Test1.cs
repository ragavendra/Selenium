using NUnit.Framework;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    public class Tests : TestFixture1
    {

        [Test]
        public void Test1()
        {

			Home home = new Home(driver);
			home.gettingStarted.Click();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
			

			GettingStarted gettingStarted = new GettingStarted(driver);
			//Assert.IsTrue(gettingStarted.pageTitle.Contains("Getting Started"), "Invalid page title");
			Assert.AreEqual("Getting Started - Atata", gettingStarted.pageTitle, "Invalid page title");

			gettingStarted.Installation.Click();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

			gettingStarted.Usage.Click();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

			gettingStarted.components.Click();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

			Components components = new Components(driver);
			Assert.AreEqual("Components - Atata", components.pageTitle, "Invalid page title");

			//gettingStarted.Installation.Click();
			components.Inputs.Click();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

			//gettingStarted.Usage.Click();
			components.Select.Click();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);


			//driver.Title
			//Console.WriteLine(driver.Title);

			//	driver.Quit();

			/*
	<select>
	 <option value=value1>Bread</option>
	 <option value=value2 selected>Milk</option>
	 <option value=value3>Cheese</option>
	</select>*/

			/*

			IWebElement selectElement = driver.FindElement(By.Id("selectElementID"));
			var selectObject = new SelectElement(selectElement);

			// Select an <option> based upon the <select> element's internal index
			selectObject.SelectByIndex(1);

			// Select an <option> based upon its value attribute
			selectObject.SelectByValue("value1");

			// Select an <option> based upon its text
			selectObject.SelectByText("Bread");

			// Return a List<WebElement> of options that have been selected
			var allSelectedOptions = selectObject.AllSelectedOptions;

			// Return a WebElement referencing the first selection option found by walking down the DOM
			var firstSelectedOption = selectObject.AllSelectedOptions.FirstOrDefault();

			// Return a IList<IWebElement> of options that the <select> element contains
			IList<IWebElement> allAvailableOptions = selectObject.Options;

			// Deselect an <option> based upon the <select> element's internal index
			selectObject.DeselectByIndex(1);

			// Deselect an <option> based upon its value attribute
			selectObject.DeselectByValue("value1");

			// Deselect an <option> based upon its text
			selectObject.DeselectByText("Bread");

			// Deselect all selected <option> elements
			selectObject.DeselectAll();

			bool doesThisAllowMultipleSelections = selectObject.IsMultiple;

			*/

			/*
			class name		Locates elements whose class name contains the search value (compound class names are not permitted)
			css selector	Locates elements matching a CSS selector
			id				Locates elements whose ID attribute matches the search value
			name			Locates elements whose NAME attribute matches the search value
			link text		Locates anchor elements whose visible text matches the search value
			partial link text	Locates anchor elements whose visible text contains the search value. If multiple elements are matching, only the first one will be selected.
			tag name		Locates elements whose tag name matches the search value
			xpath			Locates elements matching an XPath expression
			*/

			/*
			var emailLocator = RelativeBy.WithLocator(By.TagName("input")).Above(By.Id("password"));
			var cancelLocator = RelativeBy.WithLocator(By.TagName("button")).LeftOf(By.Id("submit"));

			var emailLocator1 = RelativeBy.WithLocator(By.TagName("input")).Near(By.Id("lbl-email"));
			var submitLocator = RelativeBy.WithLocator(By.TagName("button")).Below(By.Id("email")).RightOf(By.Id("cancel"));

			*/
			/*
			<ol id="vegetables">
			 <li class="potatoes">…
			 <li class="onions">…
			 <li class="tomatoes"><span>Tomato is a Vegetable</span>…
			</ol>
			<ul id="fruits">
			  <li class="bananas">…
			  <li class="apples">…
			  <li class="tomatoes"><span>Tomato is a Fruit</span>…
			</ul>
			 */

			/*

			IReadOnlyList<IWebElement> plants = driver.FindElements(By.TagName("li"));

			try
			{
				// Navigate to Url
				driver.Navigate().GoToUrl("https://example.com");

				// Get all the elements available with tag name 'p'
				IList<IWebElement> elements = driver.FindElements(By.TagName("p"));
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

			}*/

			//Assert.Pass();
		}
	}
}