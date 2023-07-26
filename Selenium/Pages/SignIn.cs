using OpenQA.Selenium;

namespace Selenium
{
    public sealed class SignIn : Base<SignIn>
    {
        
        public SignIn(IWebDriver driver) : base(driver)
        {
        }

        //public string pageTitle => _driver.Title;

        //making it more obvious to find the element
        public IWebElement Email_ => _driver.FindElement(RelativeBy.WithLocator(By.Id("email")).Above(By.Id("password")));
        //public IWebElement Email_() { return _driver.FindElement(RelativeBy.WithLocator(By.Id("email")).Above(By.Id("password"))); }

        public IWebElement Email => _driver.FindElement(By.Id("email"));

        public IWebElement Password_
            => _driver.FindElement(RelativeBy.WithLocator(By.Id("password")).Below(By.Id("email")).Above(By.ClassName("btn-primary")));

        public IWebElement Password => _driver.FindElement(By.Id("password"));

        //var submitLocator = RelativeBy.WithLocator(By.TagName("button")).Below(By.Id("email")).RightOf(By.Id("cancel"));
        public IWebElement signIn_1
            => _driver.FindElement(RelativeBy.WithLocator(By.ClassName("btn-primary")).Below(By.Id("password")).Below(By.Id("email")));

        public IWebElement signIn_ => _driver.FindElement(By.ClassName("btn-primary"));

        //public IWebElement Select => _driver.FindElement(By.LinkText("Select"));
        //public IWebElement LoginButton => _driver.FindElement(By.CssSelector("#login"));
    }
}
