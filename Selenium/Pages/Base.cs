using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;

namespace Selenium
{
    public abstract class Base : BaseInterface<Base>
    {
        //public IWebDriver driver;

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

        //interface code below
        public string str { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IWebDriver driver { get; set; }

        public void setup()
        {
            throw new System.NotImplementedException();
        }
    }
}
