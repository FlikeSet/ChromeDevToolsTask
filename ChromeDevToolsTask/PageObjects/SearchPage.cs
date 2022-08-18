using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace ChromeDevToolsTask.PageObjects
{
    public class SearchPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='T-I T-I-KE L3']")]
        private IWebElement WriteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id=':bc']")]
        private IWebElement ReceiverInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id=':7h']")]
        private IWebElement SubjectInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id=':8n']")]
        private IWebElement MailInputField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id=':hc']")]
        private IWebElement SendButton { get; set; }

        internal void ClickWriteButton()
        {
            WriteButton.Click();
        }
        internal void ClickSendButton()
        {
            SendButton.Click();
        }
        public IWebElement GetReceiverInputField()
        {
            return ReceiverInputField;
        }
        public IWebElement GetSubjectInputField()
        {
            return SubjectInputField;
        }
        public IWebElement GetMailInputField()
        {
            return MailInputField;
        }

        internal SearchPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

    }
}
