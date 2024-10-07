using DotNetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium
{
    public class AmazonDropDown
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://amazon.com/");
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        [Test]

        public void SelectDDValue()
        {
            AmazonHomePage hp = new AmazonHomePage(driver);

            hp.SelectDropDownByValue("Baby");
            hp.SelectDropDownByText("Baby");
            hp.SelectDropDownByIndex(3);

            hp.ReturnAllOptions();
        }



        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
