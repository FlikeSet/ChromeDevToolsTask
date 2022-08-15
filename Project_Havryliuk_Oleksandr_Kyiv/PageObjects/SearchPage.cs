using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Project_Havryliuk_Oleksandr_Kyiv.PageObjects
{
    public class SearchPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//img[contains(@id, 'dimg')]")]
        private IWebElement SearchingImage { get; set; }

        internal SearchPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        internal IWebElement GetSearchingImage()
        {
            return SearchingImage;
        }

    }
}
