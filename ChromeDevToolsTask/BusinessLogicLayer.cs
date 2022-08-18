using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ChromeDevToolsTask.PageObjects
{
    public class BusinessLogicLayer
    {
        internal static readonly IWebDriver driver = new ChromeDriver();

        internal HomePage homePage = new HomePage(driver);

        internal SearchPage searchPage = new SearchPage(driver);

        #region HomePageFuncs

        internal void MakeInputLogin(string login)
        {
            var GetInputField = homePage.GetLoginInputField();
            GetInputField.Clear();
            GetInputField.SendKeys(login);
        }

        internal void MakeInputPassword(string password)
        {
            var GetInputField = homePage.GetPasswordInputField();
            GetInputField.Clear();
            GetInputField.SendKeys(password);
        }

        #endregion HomePageFuncs

        #region GeneratePageFuncs
        internal void MakeReceiverInput(string receiver)
        {
            var GetInputField = searchPage.GetReceiverInputField();
            GetInputField.Clear();
            GetInputField.SendKeys(receiver);
        }

        internal void MakeMailInput(string text)
        {
            var GetInputField = searchPage.GetMailInputField();
            GetInputField.Clear();
            GetInputField.SendKeys(text);
        }

        internal void MakeSubjectInput(string subject)
        {
            var GetInputField = searchPage.GetSubjectInputField();
            GetInputField.Clear();
            GetInputField.SendKeys(subject);
        }

        #endregion GeneratePageFuncs

    }
}

