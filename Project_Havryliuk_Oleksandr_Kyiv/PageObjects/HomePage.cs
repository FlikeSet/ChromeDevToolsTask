
using OpenQA.Selenium;
using Project_Havryliuk_Oleksandr_Kyiv.PageObjects;
using SeleniumExtras.PageObjects;

namespace Project_Havryliuk_Oleksandr_Kyiv
{

    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        private IWebElement SearchInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@role='button']")]
        private IWebElement SearchButton { get; set; }


        
        public HomePage(IWebDriver driver): base(driver)
        {
            PageFactory.InitElements(driver, this);
        }


        public IWebElement GetSearchInputField()
        {
            return SearchInputField;
        }


        internal void ClickSearchButton()
        {
            SearchButton.Click();
        }
    }  
}