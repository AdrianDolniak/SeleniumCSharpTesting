using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;



namespace BasicSeleniumIntroduction.tests
{
    [TestFixture]
    class SeleniumTesting
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("D:\\Testing\\Visual Studio C # Testing\\");
            driver.Url = "https://www.objectivity.co.uk/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

        [Test]
        public void Home_page_title()
        {
            string myTitle = driver.Title;
            Assert.AreEqual(myTitle, "Software Development Company | Bespoke Software UK | Objectivity");
            Thread.Sleep(10000);
        }
        [Test]
        public void Join_us()
        {
            IWebElement joinUs = driver.FindElement(By.CssSelector("#navbarToggler > ul > li:nth-child(8)"));
            joinUs.Click();
            Thread.Sleep(10000);
        }
    }
}