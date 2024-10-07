using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotNetSelenium
{
    public static class SeleniumCustomMethods
    {

        public static void ClickEle(this IWebElement locator)
        {
            locator.Click();
        }

        public static void SubmitEle(this IWebElement locator)
        {
            locator.Submit();
        }

        public static void EnterText(this IWebElement locator, string Text)
        {
            locator.Clear();
            locator.SendKeys(Text);
        }

        public static void SelectDropDownByText1(this IWebElement locator, string Text)
        {
            SelectElement selectEle = new SelectElement(locator);
            selectEle.SelectByText(Text);
        }

        public static void SelectDropDownByValue(this IWebElement locator, string Value)
        {
            SelectElement selectEle = new SelectElement(locator);
            selectEle.SelectByValue(Value);
        }

        public static void SelectDropDownByIndex(this IWebElement locator, int Index)
        {
            SelectElement selectEle = new SelectElement(locator);
            selectEle.SelectByIndex(Index);
        }

        public static void MultiSelectElement(this IWebElement locator, string[] values)
        {
            SelectElement multiSel = new SelectElement(locator);

            foreach (var value in values)
            {

                multiSel.SelectByValue(value);

            }
        }

        public static List<string> GetAllSelectedList(this IWebElement locator)
        {
            List<string> options = new List<string>();
            SelectElement multiSel = new SelectElement(locator);

            IList<IWebElement> selectedOptions = multiSel.AllSelectedOptions;

            foreach (var option in selectedOptions)
            {
                options.Add(option.Text);
            }
            return options;
        }


    }
}