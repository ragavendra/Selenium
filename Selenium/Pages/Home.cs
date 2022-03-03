using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class Home : Base
    {

        public By searchBox = By.Name("q");
        public By searchButton = By.Name("btnK");
        
        public Home(IWebDriver driver) : base(driver)
        { 
        }

        //public IWebElement Name => driver.FindElement(By.CssSelector("#name"));
        //public IWebElement Password => driver.FindElement(By.CssSelector("#password"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }

    //trying partial
    public partial class TestClass {

        public TestClass() { }
    
        public int num { get; set; }

        //[SerializableAttribute]
        //[System.Runtime]
        public int num2 { get; set; }

        public partial void name();

        partial class Nestedclass { }

        public void method() { }

    }

}

namespace Selenium {


    partial class TestClass
    {

        //public TestClass() { }
        public int num1 { get; set; }
        public partial void name() {

            //return "test";
            num1 = 6;

        }

        partial class Nestedclass { }

        public void method2() { }

    }
}
