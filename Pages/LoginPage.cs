using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement LoginLink => driver.FindElement(By.PartialLinkText("Login"));

        IWebElement txtUserName => driver.FindElement(By.Name("UserName"));

        IWebElement txtPassword => driver.FindElement(By.CssSelector("#Password"));

        IWebElement btnLogin => driver.FindElement(By.ClassName("btn-default"));

        IWebElement lnkEmpDetails => driver.FindElement(By.LinkText("Employee Details"));

        IWebElement lnkManageUsers => driver.FindElement(By.LinkText("Manage Users"));

        IWebElement lnkLogOff => driver.FindElement(By.LinkText("Log off"));


        public void ClickLogin()
        {
            SeleniumCustomMethods.ClickEle(LoginLink);
        }

        public void Login(string username, string password)
        {
            txtUserName.Clear();
            txtUserName.EnterText(username);
            txtPassword.EnterText(password);
            btnLogin.SubmitEle();
            
        }

        public (bool empDetails,bool manageUsers) IsLoggedIn()
        {
            return (lnkEmpDetails.Displayed, lnkManageUsers.Displayed);
        }


    }
}
