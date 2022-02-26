using OpenQA.Selenium;

namespace Selenium
{
    public class GettingStarted : Base
    {

        public GettingStarted(IWebDriver driver) : base(driver)
        {
        }

        //public By installation = By.LinkText("Installation");
        //public By usage = By.LinkText("Usage");

        public IWebElement Installation => driver.FindElement(By.LinkText("Installation"));

        public IWebElement Usage => driver.FindElement(By.LinkText("Usage"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}
