using DotNetSelenium.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DotNetSelenium
{
    public class DataDrivenTesting
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
        [Category("DDT")]
        [TestCaseSource(nameof(LoginJsonDataSource))]
        public void TestWithPOM(LoginModel LogMod)
        {
            //POM Initialization
            //Arrange
            LoginPage lp = new LoginPage(_driver);

            //Act
            lp.ClickLogin();
            lp.Login(LogMod.UserName, LogMod.Password);

            //Assert
            var isLogIn = lp.IsLoggedIn();
            //Assert.IsTrue(isLogIn.empDetails);
            //Assert.IsTrue(isLogIn.Item2);
            Assert.IsTrue(isLogIn.empDetails && isLogIn.manageUsers);

        }



        [Test]
        [Category("DDTJSON")]
        
        public void TestWithPOMWithJsonData()
        {
            string JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login.json");
            var jsonString = File.ReadAllText(JsonFilePath);

            var LoginMod = JsonSerializer.Deserialize<LoginModel>(jsonString);

            LoginPage lp = new LoginPage(_driver);

            lp.ClickLogin();
            lp.Login(LoginMod.UserName, LoginMod.Password);

        }

        public static IEnumerable<LoginModel> Login()
        {
            yield return new LoginModel()
            {
                UserName = "admin",
                Password = "password"
            };
        }

        public static IEnumerable<LoginModel> LoginJsonDataSource()
        {
            string JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login.json");
            var jsonString = File.ReadAllText(JsonFilePath);

            var LoginMod = JsonSerializer.Deserialize<List<LoginModel>>(jsonString);

            foreach(var loginData in LoginMod)
            {
                yield return loginData;
            }
            
        }

        private void ReadJsonFile()
        {
            string JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Login.json");
            var jsonString = File.ReadAllText(JsonFilePath);
            
            var LoginMod = JsonSerializer.Deserialize<LoginModel>(jsonString);

            Console.WriteLine($"UserName {LoginMod.UserName} Password {LoginMod.Password}");

        }


        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }


    }
}
