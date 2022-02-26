using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;

namespace Selenium
{
    public abstract class Base
    {
        public IWebDriver driver;

        //menus go on this class
        public Base(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string pageTitle => driver.Title;

        //public By gettingStarted = By.LinkText("Getting Started");
        //public By components = By.LinkText("Components");

        public IWebElement gettingStarted => driver.FindElement(By.LinkText("Getting Started"));

        public IWebElement components => driver.FindElement(By.LinkText("Components"));

    }
}
