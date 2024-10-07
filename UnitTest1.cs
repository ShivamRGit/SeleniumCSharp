using DotNetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Sudo Code for setting up the selenium

            //1. Create a new instance of a Selenium Web Driver

            IWebDriver driver = new ChromeDriver();

            //2. Navigate to the URL

            driver.Navigate().GoToUrl("https://www.google.com/");

            //2.a Maximize Browser

            driver.Manage().Window.Maximize();

            //3. Find the search box element

            var webElement = driver.FindElement(By.Name("q"));

            //4. Type in text box

            webElement.SendKeys("Selenium");

            //5. Click Enter

            webElement.SendKeys(Keys.Return);
        }

        [Test]
        public void EAWebSiteTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");

            // Instead of IWebElement loginLink, we can use var loginLink by using var keyword

            //var loginLink = driver.FindElement(By.PartialLinkText("Login"));
            //loginLink.Click();
            driver.FindElement(By.PartialLinkText("Login")).Click();

            //IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
            //txtUserName.SendKeys("admin");
            driver.FindElement(By.Name("UserName")).SendKeys("admin");

            //var txtPassword = driver.FindElement(By.CssSelector("#Password"));
            //txtPassword.SendKeys("password");
            driver.FindElement(By.CssSelector("#Password")).SendKeys("password");
            
            //var btnLogin = driver.FindElement(By.ClassName("btn-default"));
            //btnLogin.Submit();
            driver.FindElement(By.ClassName("btn-default")).Submit();

        }

        [Test]
        public void TestWithPOM()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");
            // POM Initialization
            LoginPage lp = new LoginPage(driver);
            
            lp.ClickLogin();
            lp.Login("admin", "password");

        }

        [Test]
        public void WorkingWIthAdvancedControls()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            PracticePage pp = new PracticePage(driver);
            //SelectElement selectEle = new SelectElement(driver.FindElement(By.Id("dropdown-class-example")));

            //selectEle.SelectByValue("option1");
            //selectEle.SelectByText("Option3");
            //selectEle.SelectByIndex(2);

            pp.SelectDropDownByValue("option1");
            pp.SelectDropDownByText("Option3");
            pp.SelectDropDownByIndex(2);


            //IList<IWebElement> selectedOption = selectEle.AllSelectedOptions;

            //foreach (IWebElement option in selectedOption)
            //{
            //    Console.WriteLine(option.Text);
            //}

            //var getSelectedOptions = SeleniumCustomMethods.GetAllSelectedList(driver, By.Id("dropdown-class-example"));

            //List<string> getSelectedOptions = pp.GetSelectedItems();


            //foreach (var option in getSelectedOptions)
            //{
            //    Console.WriteLine(option);
            //}

            //getSelectedOptions.ForEach(option => Console.WriteLine(option));

            //driver.FindElement(By.Name("checkBoxOption2")).Click();
            //SeleniumCustomMethods.Click(driver, By.Name("checkBoxOption2"));
            pp.SelectCB();

            //driver.FindElement(By.XPath("//input[@value='radio3']")).Click();
            pp.SelectRB();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Quit();






        }
    }

}