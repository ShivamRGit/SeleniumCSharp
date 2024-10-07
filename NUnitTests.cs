using DotNetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotNetSelenium
{

    public class NUnitTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp() 
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.eaapp.somee.com/");
        }

        [Test]
        [Category("Smoke")]
        public void TestWithPOM()
        {

            // POM Initialization
            LoginPage lp = new LoginPage(_driver);

            lp.ClickLogin();
            lp.Login("admin", "password");

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
