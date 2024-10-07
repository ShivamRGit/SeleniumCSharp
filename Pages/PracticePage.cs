using OpenQA.Selenium;

namespace DotNetSelenium.Pages
{
    public class PracticePage
    {
        private readonly IWebDriver driver;

        public PracticePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement ddExample => driver.FindElement(By.Id("dropdown-class-example"));

        IWebElement cbExample => driver.FindElement(By.Name("checkBoxOption2"));

        IWebElement rbExample => driver.FindElement(By.XPath("//input[@value='radio3']"));

        public void SelectDropDownByValue(string option)
        {
            SeleniumCustomMethods.SelectDropDownByValue(ddExample, option);
            
        }

        public void SelectDropDownByText(string option)
        {
            SeleniumCustomMethods.SelectDropDownByText1(ddExample, option);
        
        }

        public void SelectDropDownByIndex( int option1)
        {
            SeleniumCustomMethods.SelectDropDownByIndex(ddExample, option1);

        }

        //public List<string> GetSelectedItems()
        //{
        //    SeleniumCustomMethods.GetAllSelectedList(ddExample);
        //}

        public void SelectCB()
        {
            SeleniumCustomMethods.ClickEle(cbExample);
        }

        public void SelectRB()
        {
            SeleniumCustomMethods.ClickEle(rbExample);
        }
    }
    }
