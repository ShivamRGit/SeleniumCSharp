using OpenQA.Selenium;

namespace DotNetSelenium.Pages
{
    public class AmazonHomePage
    {
        private readonly IWebDriver driver;

        public AmazonHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement ddAll => driver.FindElement(By.Id("nav-search-label-id"));

        public void SelectDropDownByValue(string value)
        {
            try
            {
                CustomMethods.SelectDropDownByValue(ddAll, value);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine($"Dropdown not found: {e.Message}");
            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine($"StaleElementReference:{e.Message}");
            }
            catch (ElementNotInteractableException e)
            {
                Console.WriteLine($"Element Not Interactable: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Excaption: {e.Message}");
            }
        }

        public void SelectDropDownByText(string text)
        {
            try
            {
                ddAll.SelectDropDownByText(text);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine($"Dropdown not found: {e.Message}");
            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine($"StaleElementReference:{e.Message}");
            }
            catch (ElementNotInteractableException e)
            {
                Console.WriteLine($"Element Not Interactable: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Excaption: {e.Message}");
            }
        }

        public void SelectDropDownByIndex(int index)
        {
            try
            {
                CustomMethods.SelectDropDownByIndex(ddAll, index);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine($"Dropdown not found: {e.Message}");
            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine($"StaleElementReference:{e.Message}");
            }
            catch (ElementNotInteractableException e)
            {
                Console.WriteLine($"Element Not Interactable: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Excaption: {e.Message}");
            }
        }

        public void ReturnAllOptions()
        {
            //CustomMethods.GetDropDownOptions(ddAll);
        }

    }
}
