using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DotNetSelenium
{
    public static class CustomMethods
    {

        public static void SelectDropDownByValue(IWebElement locator, string value)
        {
            SelectElement selectEle = new SelectElement(locator);
            selectEle.SelectByValue(value);
        }

        public static void SelectDropDownByText(this IWebElement locator, string text)
        {
            SelectElement selectEle = new SelectElement(locator);
            selectEle.SelectByText(text);
        }

        public static void SelectDropDownByIndex(IWebElement locator, int index)
        {
            SelectElement selectEle = new SelectElement(locator);
            selectEle.SelectByIndex(index);
        }

        //public static List<string> GetDropDownOptions(IWebElement locator)
        //{
        //    try
        //    {
        //        List<string> optionsList = new List<string>();
        //        SelectElement selectEle = new SelectElement(locator);

        //        foreach (var option in selectEle.Options)
        //        {
        //            optionsList.Add(option.Text);
        //        }
        //        return optionsList;
        //    }
        //    catch (NoSuchElementException e)
        //    {
        //        Console.WriteLine($"Dropdown not found: {e.Message}");
        //    }
        //    catch (StaleElementReferenceException e)
        //    {
        //        Console.WriteLine($"StaleElementReference:{e.Message}");
        //    }
        //    catch (ElementNotInteractableException e)
        //    {
        //        Console.WriteLine($"Element Not Interactable: {e.Message}");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Excaption: {e.Message}");
        //    }
             
        //}
    }
}
