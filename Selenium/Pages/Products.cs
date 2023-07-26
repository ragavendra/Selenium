using OpenQA.Selenium;

namespace Selenium
{
    public sealed class Products : Base<Products>
    {
        
        public Products(IWebDriver driver) : base(driver)
        {
        }

        //public string pageTitle => driver.Title;

        //public IWebElement Inputs => driver.FindElement(By.LinkText("Inputs"));

        //public IWebElement Select => driver.FindElement(By.LinkText("Select"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}
