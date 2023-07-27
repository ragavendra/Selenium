using System;
using OpenQA.Selenium;
//using SeleniumExtras.PageObjects;

namespace Selenium
{
    public abstract class Base<T> : BaseInterface<T>, IDisposable
    {
        //public IWeb_driver _driver;
        private bool _disposed;

        //menus go on this class
        private protected Base(IWebDriver driver)
        {
            _driver = driver;
        }

        //public string pageTitle1 = _driver.Title;

        //public string pageTitle() { return _driver.Title; }
        public string pageTitle => _driver.Title;

        public IWebElement plans => _driver.FindElement(By.LinkText("Plans"));

        public IWebElement products => _driver.FindElement(By.LinkText("Products"));

        // public IWebElement signIn => _driver.FindElement(By.LinkText("Sign In"));
        public IWebElement signIn => _driver.FindElement(RelativeBy.WithLocator(By.LinkText("Sign In")).LeftOf(By.LinkText("Sign Up")));

        protected IWebDriver _driver;

        public IWebDriver Driver { get; set; }

        public bool CheckIfAllElementsIsLoaded()
        {
            try
            {
                var properties = GetType().GetProperties();

                foreach (var item in properties)
                {
                    var val = item.GetValue(this);
                }

                return true;

            }
            catch (Exception exception)
            {
                Console.WriteLine("Issue loading element info " + exception.Message);
            }

            return false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if(disposing)
                {
                    _driver = null;
                }
                // return;
            }

            // todo: disp unmnaged resources
            _disposed = true;
            Console.WriteLine(GetType().Name + "Dispose is called now!");
        }
    }
}