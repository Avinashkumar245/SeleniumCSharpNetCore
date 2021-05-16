using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Seleinum
{
    public class Tests: DriverHelper
    {
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
           
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            driver.Manage().Window.Maximize();
            IWebElement element=driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
            element.SendKeys("Tomato");

            IWebElement celery = driver.FindElement(By.XPath("//*[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']"));
            celery.Click();

            string comboboxxControlname = "ContentPlaceHolder1_AllMealsCombo";

            
            CustomControl.ComboBox(comboboxxControlname, "Mango");

            //IWebElement combobox = driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            //combobox.Clear();
            //combobox.SendKeys("Mango");

            //driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Mango']")).Click();


            
        }
    }
}