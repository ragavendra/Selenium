using OpenQA.Selenium;

namespace Selenium
{
    public sealed class Components : Base
    {
        
        public Components(IWebDriver driver) : base(driver)
        {
        }

        //public string pageTitle => driver.Title;

        private IWebElement Inputs => driver.FindElement(By.LinkText("Inputs"));

        private IWebElement Select => driver.FindElement(By.LinkText("Select"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}
