using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Tests
{
    public  class LoginTest : BaseTest
  { 
        [Test]
       public void WriteTextBoxUserPassTest()
        {
            LoginPage.MainLogInButton();
            var username = "test";
            Thread.Sleep(3000);
            var password = "test";
            Thread.Sleep(3000);
            LoginPage.WriteTextBoxUser(username);
            Thread.Sleep(4000);
           
            LoginPage.WriteTextBoxPass(password);
            Thread.Sleep(4000);
            LoginPage.ClickLogInButton();
            Thread.Sleep(4000);
        }
    }
}
