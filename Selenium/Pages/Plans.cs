using OpenQA.Selenium;
using System;
using System.Reflection;

//[assembly: AssemblyTitleAttribute("Production assembly 4")]
//[module: CLSCompliant(true)]

namespace Selenium
{
    public sealed class Plans : Base<Plans>
    {
        
        public Plans(IWebDriver driver) : base(driver)
        {
        }

        //public string pageTitle => driver.Title;

        //public IWebElement Inputs => driver.FindElement(By.LinkText("Inputs"));

        //public IWebElement Select => driver.FindElement(By.LinkText("Select"));
        //public IWebElement LoginButton => driver.FindElement(By.CssSelector("#login"));

    }

    /*
    //trying attributes
    [Serializable]
    //[target : attribute-list]
    public class Test {

        static void main()
        {
            Type th = typeof(String);
            //MethodInfo mi = th.GetMethod
            //th.GetMethod
            MethodInfo substr = th.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            Object result = substr.Invoke("Hello, World!", new Object[] { 7, 5 });
            Console.WriteLine("{0} returned \"{1}\".", substr, result);

        }

    }
    */
    /* This code example produces the following output:
        System.String Substring(Int32, Int32) returned "World". */
}
