using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using QATest.BookingFeature.Util;

namespace QATest.BookingFeature.Implementations
{
    public class HotelListIMPL : BaseConfig
    {
        
        public HotelListIMPL() { }

        
        public void GivenIAmInTheBookingHomePage()
        {
            StartBrowser();
        }

        public void WhenIInformACity()
        {
            StartBrowser();
        }

        public void WhenISelectACheckingDate()
        {
            StartBrowser();
        }

        public void WhenISelectACheckoutDate()
        {
            StartBrowser();
        }

        public void WhenIPressTheSearchButton()
        {
            StartBrowser();
        }

        public void WhenISelectTheSaunaFilter()
        {
            StartBrowser();
        }

        public void ThenTheLimerickStrandHotelShouldBeVisible()
        {
            StartBrowser();
        }

        public void ThenTheGeorgeLimerickHotelShouldNotBeVisible()
        {
            StartBrowser();
        }

        public void WhenISelectTheStarFilter()
        {
            StartBrowser();
        }

    }
}
