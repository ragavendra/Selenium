using OpenQA.Selenium;

namespace Selenium
{
    public sealed class GettingStarted : Base
    {

        public GettingStarted(IWebDriver driver) : base(driver)
        {
        }

        //public By installation = By.LinkText("Installation");
        //public By usage = By.LinkText("Usage");

        private IWebElement Installation => driver.FindElement(By.LinkText("Installation"));

        private IWebElement Usage => driver.FindElement(By.LinkText("Usage"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}
