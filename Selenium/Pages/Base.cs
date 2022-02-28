using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;

namespace Selenium
{
    public abstract class Base : BaseInterface<Base>
    {
        //public IWebDriver driver;

        //menus go on this class
        private protected Base(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string pageTitle => driver.Title;

        public IWebElement plans => driver.FindElement(By.LinkText("Plans"));

        public IWebElement products => driver.FindElement(By.LinkText("Products"));

        //interface code below
        public string str { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IWebDriver driver { get; set; }

        public void setup() { }
    }

    public interface IResponse {

        string fname { get; set; }
        string lname { get; set; }
        string address { get; set; }
        string pin { get; set; }
    }

    public class RegisterResponse : IResponse {
        public string fname { get; set; }
        public string lname { get; set; }
        public string address { get; set; }
        public string pin { get; set; }
        public string extra_field { get; set; }
    }

    public class RegisterResponse2 : IResponse
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string address { get; set; }
        public string pin { get; set; }
        public string extra_field2 { get { return extra_field2; } set { value = ""; } }
    }
}
