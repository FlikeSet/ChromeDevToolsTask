
using OpenQA.Selenium;
using ChromeDevToolsTask.PageObjects;
using SeleniumExtras.PageObjects;

namespace ChromeDevToolsTask
{

    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@type = 'email']")]
        private IWebElement LoginInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='identifierNext']/div/button")]
        private IWebElement LoginNextButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type = 'password']")]
        private IWebElement PasswordInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='passwordNext']/div/button")]
        private IWebElement PasswordNextButton { get; set; }



        public HomePage(IWebDriver driver): base(driver)
        {
            PageFactory.InitElements(driver, this);
        }


        public IWebElement GetLoginInputField()
        {
            return LoginInputField;
        }

        public IWebElement GetPasswordInputField()
        {
            return PasswordInputField;
        }

        internal void ClickLoginNextButton()
        {
            LoginNextButton.Click();
        }

        internal void ClickPasswordNextButton()
        {
            PasswordNextButton.Click();
        }
    }  
}