using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class OomaExtensions
    {
        public IWebDriver driver { get; set; }

        public By searchBox = By.Name("q");
        public By searchButton = By.Name("btnK");

        public OomaExtensions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement username => driver.FindElement(By.Id("phone"));

        public IWebElement password => driver.FindElement(By.Id("password"));

        public IWebElement loginButton => driver.FindElement(By.Id("login-button"));


        ///html/body/div[3]/div/div[2]/div/div/div/div/div[3]/div/div[2]/div/div/div[1]/div[2]/div[1]
        ///

        public IWebElement row1 => driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/div/div/div[3]/div/div[2]/div/div/div[1]/div[2]/div[row1]/div/div[col1]/div/span"));

        public IWebElement extension(string rowNum, string colNum) {
            return driver.FindElement(By.XPath($"/html/body/div[3]/div/div[2]/div/div/div/div/div[3]/div/div[2]/div/div/div[1]/div[2]/div[{rowNum}]/div/div[{colNum}]/div/span"));
        }

        public IWebElement name(string rowNum, string colNum) {
            return driver.FindElement(By.XPath($"/html/body/div[3]/div/div[2]/div/div/div/div/div[3]/div/div[2]/div/div/div[1]/div[2]/div[{rowNum}]/div/div[{colNum}]/div/div/span"));
        }


        //login-button
        //public IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}