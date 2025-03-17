using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Pages
{
    public class LoginPage
    {
        //locators
        
        IWebElement logInButton => driver.FindElement(By.CssSelector("a[data-testid=\"navbar-login\"]"));
        IWebElement usernameField => driver.FindElement(By.CssSelector("input[data-testid=\"username-textbox\"]"));
        IWebDriver driver;
        IWebElement passwordField => driver.FindElement(By.CssSelector("input[data-testid=\"password-textbox\"]"));
        IWebElement loginButton => driver.FindElement(By.CssSelector("button[data-testid=\"login-button\""));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //methods

        public LoginPage MainLogInButton()
        {
            logInButton.Click();
            return this;
        }

        public LoginPage WriteTextBoxUser (string username)
        {
            //Console.WriteLine("Login with username: " + username + " and password: " + password);
            usernameField.SendKeys("test");
            
            return this;

        }
        public LoginPage WriteTextBoxPass(string password)
        {
            
            passwordField.SendKeys("test");
            return this;
        }

        public  LoginPage ClickLogInButton()
        {
            loginButton.Click();
            return this;
        }

       
        
    }
}
