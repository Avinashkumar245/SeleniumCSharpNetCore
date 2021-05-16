using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleinum
{
    public  class CustomControl:DriverHelper
    {
        public static void ComboBox(string controlName,string value )
        {
            IWebElement combobox = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            combobox.Clear();
            combobox.SendKeys("Mango");

            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }

        public static void EnterText(IWebElement webElement, string value)
        {
            webElement.Clear();
            webElement.SendKeys(value);
        }

        public static void Click(IWebElement webElement)
        {
            webElement.Click();
        }

        public static void SelectByValues(IWebElement webElement,string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }
    }
}
