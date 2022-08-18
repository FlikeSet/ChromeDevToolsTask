using OpenQA.Selenium;


namespace ChromeDevToolsTask.PageObjects
{
    public class BasePage
    {
        public IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
