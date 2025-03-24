using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQAAutomation.Pages
{
    public class AddProductPage(IWebDriver driver)  
    {
        public readonly IWebDriver driver = driver;
        private readonly WebDriverWait wait = new(driver, TimeSpan.FromSeconds(10));
        private readonly By addProductButton = By.CssSelector("a[data-testid='add-a-product-button']");
        private readonly By nameField = By.CssSelector("input[data-testid=\"product-textbox\"]");
        private readonly By priceField = By.CssSelector("input[data-testid=\"price-textbox\"]");
        private readonly By dateStockedField = By.CssSelector("input[data-testid=\"date-stocked\"]");
        private readonly By submitButton = By.CssSelector("button[data-testid=\"submit-form\"]");
        private readonly By cancelButton = By.CssSelector("a[data-testid=\"cancel-button\"]");

        public AddProductPage NavAddButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(addProductButton)).Click();
            return this;
        }

        public AddProductPage NameField(string nameProduct)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(nameField)).SendKeys(nameProduct);
            return this;
        }

        public AddProductPage PriceField(string priceProduct)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(priceField)).SendKeys(priceProduct);
            return this;
        }

        public AddProductPage FieldDateStocked(string dateStockedProduct)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(dateStockedField)).SendKeys(dateStockedProduct);
            return this;
        }
        public AddProductPage SubmitButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(submitButton)).Click();
            return this;
        }

        public AddProductPage CancelButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(cancelButton)).Click();
            return this;
        }


    }
}
