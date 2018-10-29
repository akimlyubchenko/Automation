using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
