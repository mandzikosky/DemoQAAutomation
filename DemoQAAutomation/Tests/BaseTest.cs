using DemoQAAutomation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace DemoQAAutomation.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected ProductPage ProductPage { get;private set; }
        protected LoginPage LoginPage { get; private set; }
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://commitquality.com/"); 
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ProductPage = new ProductPage(Driver);
            LoginPage = new LoginPage(Driver);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
