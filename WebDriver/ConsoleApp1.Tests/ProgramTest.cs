using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Оочень сложную авиакомпанию выбрал: стоят "i'm not a robot", названия классов и id генерируются при каждом 
            // обновлении страницы
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.airindia.in/RouteMap/RouteMap.aspx";

            driver.Manage().Timeouts();

            driver.FindElement(By.Id("leavingFrom")).SendKeys("Brussels");
            driver.FindElement(By.Id("goingTo")).SendKeys("Mumbai");


            driver.FindElement(By.LinkText("All Airlines")).Click();

            Thread.Sleep(100);

            driver.FindElement(By.LinkText("Air India")).Click();

            driver.FindElement(By.Id("findRoutes")).Click();

            var alert = new WebDriverWait(driver, new TimeSpan(0, 0, 0, 2));
            
            Assert.AreEqual(alert.Until(drv => drv.SwitchTo().Alert().Text), "No flights found for these locations.");
        }
    }
}
