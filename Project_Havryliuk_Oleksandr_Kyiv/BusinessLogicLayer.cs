using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Project_Havryliuk_Oleksandr_Kyiv.PageObjects
{
    public class BusinessLogicLayer
    {
        internal static readonly IWebDriver driver = new ChromeDriver();

        internal HomePage homePage = new HomePage(driver);

        internal SearchPage searchPage = new SearchPage(driver);

        #region HomePageFuncs

        internal void MakeInput(string input)
        {
            var GetInputField = homePage.GetSearchInputField();
            GetInputField.Clear();
            GetInputField.SendKeys(input);
        }


        #endregion HomePageFuncs

        #region SearchPageFuncs


        internal bool CheckSearchPageContainsImages()
        {
            var FirstImageView = searchPage.GetSearchingImage();
            String id = FirstImageView.GetAttribute("id");
            return id.StartsWith("dimg");
        }

        #endregion GeneratePageFuncs

    }
}

