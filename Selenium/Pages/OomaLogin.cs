using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class OomaLogin
    {
        public IWebDriver driver { get; set; }

        public By searchBox = By.Name("q");
        public By searchButton = By.Name("btnK");

        public OomaLogin(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement username => driver.FindElement(By.Id("phone"));

        public IWebElement password => driver.FindElement(By.Id("password"));

        public IWebElement loginButton => driver.FindElement(By.Id("login-button"));
        //login-button
        //public IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}