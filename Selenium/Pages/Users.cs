using OpenQA.Selenium;

namespace Selenium
{
    public sealed class Users : Base
    {
        
        public Users(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement New => driver.FindElement(By.CssSelector("body > div > div.col-md-10.col-md-offset-1.col-sm-12.col-sm-offset-0 > button"));

        //public IWebElement Select => driver.FindElement(By.LinkText("Select"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}
