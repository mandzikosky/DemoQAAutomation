using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Pages
{
    public class ProductPage
    {
        //locators
        IWebElement FilterBox => driver.FindElement(By.ClassName("filter-textbox"));
        IWebDriver driver;
        IWebElement FilterButton => driver.FindElement(By.CssSelector("button[data-testid=\"filter-button\"]"));
        IWebElement ProductListTable => driver.FindElement(By.ClassName("product-list-table"));
        IWebElement ResetButton => driver.FindElement(By.CssSelector("button[data-testid=\"reset-filter-button\"]"));
        IWebElement AddProductButton => driver.FindElement(By.CssSelector("a[data-testid=\"add-a-product-button\"]"));

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //methods
        public  ProductPage WriteTextInFilterBox (string text)
        {
            FilterBox.SendKeys("Product 2");
            return this;
        }
        public List<string> GetFilteredProductNames()
        {
            var productNames = new List<string>();
            var rows = ProductListTable.FindElements(By.CssSelector("tbody tr"));
            foreach (var row in rows)
            {
                var nameCell = row.FindElement(By.CssSelector("td[data-testid='name']"));
                productNames.Add(nameCell.Text);
            }
            return productNames;
        }

        public ProductPage ClickFilterButton()
        {
            FilterButton.Click();
            return this;
        }
        public ProductPage ClickResetButton()
        {
            ResetButton.Click();
            return this;
        }
        public ProductPage ClickAddProductButton()
        {
            AddProductButton.Click();
            return this;
        }
    }
}