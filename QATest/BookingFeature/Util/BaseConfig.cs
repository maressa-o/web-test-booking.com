using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace QATest.BookingFeature.Util
{
    public class BaseConfig
    {
        IWebDriver browser;
        public void StartBrowser()
        {
            browser = new ChromeDriver("C:\\Users\\Zupper\\Desktop\\KneatTest\\QATest\\bin\\Debug");
            browser.Manage().Window.Maximize();
            browser.Url = "https://www.booking.com";
            browser.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
        }
    }
}
