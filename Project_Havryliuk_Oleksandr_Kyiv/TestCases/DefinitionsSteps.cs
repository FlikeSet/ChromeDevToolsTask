
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Project_Havryliuk_Oleksandr_Kyiv.PageObjects;
using System;
using TechTalk.SpecFlow;


namespace Project_Havryliuk_Oleksandr_Kyiv.TestCases
{
    [Binding]
    public class DefinitionsSteps : BusinessLogicLayer
    {
        [Before]
        public void OpenHomePage()
        {
            driver.Url = "https://www.google.com/";
            try
            {
                var homePage = new HomePage(driver);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            }
            catch (NoSuchElementException) { }
        }

        [When(@"User makes input is (.*)")]
        public void TryMakeInput(string input)
        {
            MakeInput(input);
        }

        [When(@"User click on searchbutton")]
        public void ClickSearchButton()
        {
            homePage.ClickSearchButton();
        }

        [Then(@"User checks searchpage contains images")]
        public void CheckSearchPageImages()
        {
            CheckSearchPageContainsImages();
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            driver.Quit();
        }
    }
}
