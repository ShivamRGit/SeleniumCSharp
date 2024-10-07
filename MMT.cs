using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace DotNetSelenium
{
    public class MMT
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void MakeMyTripTest()
        {
            //Create Instance of Selenium Web Driver
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Navigate to the URL
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//span[@data-cy=\'closeModal\']")).Click();
            
            driver.FindElement(By.Id("fromCity")).Click();

            driver.FindElement(By.XPath("//input[@placeholder='From']")).SendKeys("HYD");

            driver.FindElement(By.XPath("//p[contains(text(), 'Rajiv Gandhi')]")).Click();

            driver.FindElement(By.Id("toCity")).Click();

            driver.FindElement(By.XPath("//input[@placeholder='To']")).SendKeys("DEL");

            driver.FindElement(By.XPath("//p[contains(text(), 'Delhi')]")).Click();

            DateTime futureDate = DateTime.Now.AddDays(7);

            string dateToSelect = futureDate.ToString("ddd MMM dd yyyy");

            Console.WriteLine(dateToSelect);

            //driver.FindElement(By.XPath("//label[@for=\'departure\']")).Click();

            driver.FindElement(By.XPath($"//div[@aria-label='dateToSelect']")).Click();















        }

    }
}

