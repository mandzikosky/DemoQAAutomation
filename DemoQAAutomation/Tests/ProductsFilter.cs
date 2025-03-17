using DemoQAAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SeleniumExtras.PageObjects;


namespace DemoQAAutomation.Tests
{
    public class ProductsFilterTest : BaseTest
    {
        [Test]

        //private Produc productsPage;

        public void WriteTextInFilterBoxTest()
       
        {
            var text = "Product 2"; 
            Thread.Sleep(8000);
            ProductPage.WriteTextInFilterBox(text);
            ProductPage.ClickFilterButton();
            var filteredProductNames = ProductPage.GetFilteredProductNames();
            Assert.That(filteredProductNames, Contains.Item("Product 2"));
            Thread.Sleep(8000);
            ProductPage.ClickResetButton();
            Thread.Sleep(8000);
            ProductPage.ClickAddProductButton();
            Thread.Sleep(8000);


        }
    }
}
