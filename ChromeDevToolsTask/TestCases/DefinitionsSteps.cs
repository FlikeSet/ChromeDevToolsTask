
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ChromeDevToolsTask.PageObjects;
using System;
using TechTalk.SpecFlow;


namespace ChromeDevToolsTask.TestCases
{
    [Binding]
    public class DefinitionsSteps : BusinessLogicLayer
    {
        [Before]
        public void OpenHomePage()
        {
            driver.Url = "https://mail.google.com/mail/u/0/#";
            try
            {
                var homePage = new HomePage(driver);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            }
            catch (NoSuchElementException) { }
        }

        [When(@"User input login is (.*)")]
        public void TryMakeInputLogin(String login)
        {
            MakeInputLogin(login);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [Then(@"User clicks on next loginbutton")]
        public void ClickLoginNextButton()
        {
            homePage.ClickLoginNextButton();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [When(@"User input password is (.*)")]
        public void TryMakeInputPassword(String password)
        {
            MakeInputPassword(password);
        }

        [Then(@"User clicks on next passwordbutton")]
        public void ClickPasswordNextButton()
        {
            homePage.ClickPasswordNextButton();
        }

        [Given(@"User clicks on writebutton")]
        public void ClickWriteButton()
        {
            searchPage.ClickWriteButton();
        }

        [When(@"User input receiver is (.*)")]
        public void TryMakeInputReceiver(String receiver)
        {
            MakeReceiverInput(receiver);
        }

        [When(@"User input subject is Test_message")]
        public void TryMakeInputSubject(String subject)
        {
            MakeSubjectInput(subject);
        }

        [When(@"User input message is (.*)")]
        public void TryMakeInputMessage(String text)
        {
            MakeMailInput(text);
        }

        [Then(@"User clicks on sendbutton")]
        public void ClickSendButton()
        {
            searchPage.ClickSendButton();
        }


        [ClassCleanup()]
        public static void ClassCleanup()
        {
            driver.Quit();
        }
    }
}
