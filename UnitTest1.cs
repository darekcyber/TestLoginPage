using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace guruLoginTestPage
{
    public class Tests
    {

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/login.html");
            driver.Manage().Window.Maximize();

            IWebElement emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("mg12345");

            IWebElement passwdInput = driver.FindElement(By.Id("passwd"));
            passwdInput.SendKeys("df12@434c");

            Thread.Sleep(1000);

            IWebElement submitButton = driver.FindElement(By.Id("SubmitLogin"));
            submitButton.Click();

            Thread.Sleep(2000);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}