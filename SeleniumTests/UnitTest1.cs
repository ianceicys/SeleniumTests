using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Selenium_GoogleChrome_Test_Google_HelloWorld()
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http://www.google.com");

            //Find the Search text box UI Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("Hello World!");

            Thread.Sleep(4000);

            //Close the browser
            driver.Close();
        }
        [TestMethod]
        public void Selenium_Edge_Test_Google_HelloWorld()
        {
            //Create the reference for our browser
            IWebDriver driver = new EdgeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http://www.google.com");

            //Find the Search text box UI Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("Hello World!");

            Thread.Sleep(4000);

            //Close the browser
            driver.Close();
        }
        [TestMethod]
        public void Selenium_FireFox_Test_Google_HelloWorld()
        {
            //Create the reference for our browser
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service);

            //Navigate to google page
            driver.Navigate().GoToUrl("http://www.google.com");

            //Find the Search text box UI Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("Hello World!");

            Thread.Sleep(4000);

            //Close the browser
            driver.Close();
        }
    }
}
