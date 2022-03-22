using OpenQA.Selenium;

namespace Selenium
{
    public sealed class SignIn : Base
    {
        
        public SignIn(IWebDriver driver) : base(driver)
        {
        }

        //public string pageTitle => driver.Title;

        //making it more obvious to find the element
        public IWebElement Email_ => driver.FindElement(RelativeBy.WithLocator(By.Id("email")).Above(By.Id("password")));
        //public IWebElement Email_() { return driver.FindElement(RelativeBy.WithLocator(By.Id("email")).Above(By.Id("password"))); }

        public IWebElement Email => driver.FindElement(By.Id("email"));

        public IWebElement Password_ => driver.FindElement(RelativeBy.WithLocator(By.Id("password")).Below(By.Id("email")).Above(By.ClassName("btn-primary")));
        public IWebElement Password => driver.FindElement(By.Id("password"));

        //var submitLocator = RelativeBy.WithLocator(By.TagName("button")).Below(By.Id("email")).RightOf(By.Id("cancel"));
        public IWebElement signIn_1 => driver.FindElement(RelativeBy.WithLocator(By.ClassName("btn-primary")).Below(By.Id("password")).Below(By.Id("email")));
        public IWebElement signIn_ => driver.FindElement(By.ClassName("btn-primary"));

        //public IWebElement Select => driver.FindElement(By.LinkText("Select"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }
}
