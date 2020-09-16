using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Class1
    {
        private static IWebDriver chrome;
        [OneTimeSetUp]
        public static void SetUp()
        {
            chrome = new ChromeDriver();
            chrome.Url = "https://finance.yahoo.com/screener/new/";
            IWebElement popUp = chrome.FindElement(By.CssSelector("#consent-page > div > div > div > div.wizard-body > div.actions.couple > form > button"));
            popUp.Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //chrome.Quit();
        }

        [Test]
        public static void FilterBuilder()
        {
            IWebElement addFilters = chrome.FindElement(By.CssSelector(".Fw\\(500\\) > .Va\\(m\\) > span"));
            addFilters.Click();
        }

        
    }
}
