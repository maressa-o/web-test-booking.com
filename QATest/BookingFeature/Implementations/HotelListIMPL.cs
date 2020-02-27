using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using QATest.BookingFeature.Util;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Linq;

namespace QATest.BookingFeature.Implementations
{
    public class HotelListIMPL : BaseConfig
    {
        
        public HotelListIMPL() { }


        public void GivenIAmInTheBookingHomePage()
        {
            StartBrowser();
        }

        public void WhenIInformAPlace()
        {
            var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));

            var placeName = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("ss")));
            placeName.SendKeys("Limerick");
            
            var selectPlace = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".c-autocomplete__item:nth-child(1) .search_hl_name")));
            selectPlace.Click();

            Thread.Sleep(1500);
        }

        public void WhenISelectMyStayPeriod()
        {
            var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));
       
            var nextMonth = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".bui-calendar__control--next > svg")));
            nextMonth.Click();
            nextMonth.Click();
            nextMonth.Click();

            var checkinDay = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".bui-calendar__row:nth-child(5) > .bui-calendar__date:nth-child(5) > span > span")));
            checkinDay.Click();
            Thread.Sleep(500);
            var checkoutDay = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".bui-calendar__wrapper:nth-child(1) .bui-calendar__row:nth-child(5) > .bui-calendar__date:nth-child(6)")));
            checkoutDay.Click();
            Thread.Sleep(1000);

        }

        public void WhenIDoTheSearch()
        {
            var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));

            var searchButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".sb-searchbox__button > span:nth-child(1)")));
            searchButton.Click();
        }

        public void WhenISelectTheSaunaFilter()
        {
            var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));

            var saunaFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("#filter_popular_activities .filterelement:nth-child(3) .filter_label")));
            saunaFilter.Click();
        }

        public void WhenISelectThe5StarFilter()
        {
            var wait = new WebDriverWait(browser, TimeSpan.FromSeconds(10));

            var starFilter = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("#filter_class .filterelement:nth-child(3) .filter_label")));
            starFilter.Click();
        }

        public void ThenICheckWichAreAvaliable(string hotel)
        {
            if (String.Equals(hotel, "Limerick Strand Hotel"))
            {
                var limerickHotel = browser.FindElements(By.XPath("//*[text()[contains(.,'Limerick Strand Hotel')]]")).Count() > 0;
                if (limerickHotel)
                {
                    Console.WriteLine("Limerick Strand Hotel is avaliable");
                }
                else
                {
                    Console.WriteLine("Limerick Strand Hotel isn't avaliable");
                }
            }

            if (String.Equals(hotel, "George Limerick Hotel"))
            {
                var georgeHotel = browser.FindElements(By.XPath("//*[text()[contains(.,'George Limerick Hotel')]]")).Count() == 0;
                if (georgeHotel)
                {
                    Console.WriteLine("George Limerick Hotel isn't avaliable");
                }
            }

            if (String.Equals(hotel, "Limerick Strand Hotel"))
            {
                var savoyHotel = browser.FindElements(By.XPath("//*[text()[contains(.,'The Savoy Hotel')]]")).Count() > 0;
                if (savoyHotel)
                {
                    Console.WriteLine("The Savoy Hotel is avaliable");
                }
                else
                {
                    Console.WriteLine("The Savoy Hotel isn't avaliable");
                }
            }

        }

       /* public void ThenICheckTheIfLimerickStrandHotelAreAvaliable(string hotel)
        {
            var limerickHotel = browser.FindElements(By.XPath("//*[text()[contains(.,'Limerick Strand Hotel')]]")).Count() > 0;
            if (limerickHotel)
            {
                Console.WriteLine("Limerick Strand Hotel is avaliable");
            }
            else
            {
                Console.WriteLine("Limerick Strand Hotel isn't avaliable");
            }
            
        }

        public void ThenICheckTheIfGeorgeLimerickHotelAreAvaliable(string hotel)
        {
            var georgeHotel = browser.FindElements(By.XPath("//*[text()[contains(.,'George Limerick Hotel')]]")).Count() == 0;
            if (georgeHotel)
            {
                Console.WriteLine("George Limerick Hotel isn't avaliable");
            }
        }
        
        public void ThenICheckTheIfTheSavoyHotelAreAvaliable(string hotel)
        {
            var savoyHotel = browser.FindElements(By.XPath("//*[text()[contains(.,'The Savoy Hotel')]]")).Count() > 0;
            if (savoyHotel)
            {
                Console.WriteLine("The Savoy Hotel is avaliable");
            }
            else
            {
                Console.WriteLine("The Savoy Hotel isn't avaliable");
            }
        }*/
    }
}
