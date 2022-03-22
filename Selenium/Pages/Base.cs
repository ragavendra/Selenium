using OpenQA.Selenium;
using System;
using System.IO;
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

        //public string pageTitle1 = driver.Title;

        //public string pageTitle() { return driver.Title; }
        public string pageTitle => driver.Title;

        public IWebElement plans => driver.FindElement(By.LinkText("Plans"));

        public IWebElement products => driver.FindElement(By.LinkText("Products"));

        public IWebElement signIn => driver.FindElement(By.LinkText("Sign In"));

        //interface code below
        public string str { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IWebDriver driver { get; set; }

        public void setup() { }

        public void TakeScreen(string testName) {

            //create dir in root of project folder with test name
            string path = "../../../../RunLog/" + testName;
            DirectoryInfo di = new DirectoryInfo(path);

            if (di.Exists)
            { }
            else
                di.Create();

            ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
			Screenshot screenshot = takesScreenshot.GetScreenshot();
			screenshot.SaveAsFile(path + "/Step_" + DateTime.Now.ToString("ddMMyyy_hhmmss") + ".png");
        }
    }

    //Interface usage when response can have multiple json return types
    //onr interface can handle both the json's
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

        public RegisterResponse(string first, string last, string address, string pin, string extra_field) {

            fname = first;
            lname = last;
            this.address = address;
            this.pin = pin;
            this.extra_field = extra_field;
        }
    }

    public class RegisterResponse2 : IResponse
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string address { get; set; }
        public string pin { get; set; }
        public string extra_field2 { get { return extra_field2; } set { value = ""; } }

        public RegisterResponse2(string first, string last, string address, string pin, string extra_field2)
        {

            fname = first;
            lname = last;
            this.address = address;
            this.pin = pin;
            this.extra_field2 = extra_field2;
        }

        //public RegisterResponse2() { }
    }
}
