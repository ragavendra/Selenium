using System;
using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class Home : Base<Home>
    {

        public By searchBox = By.Name("q");

        public By searchButton = By.Name("btnK");
        
        public Home(IWebDriver driver) : base(driver)
        { 
        }

        //public IWebElement Name => driver.FindElement(By.CssSelector("#name"));
        //public IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}
