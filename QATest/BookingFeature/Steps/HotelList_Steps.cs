using OpenQA.Selenium;
using QATest.BookingFeature.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace QATest.BookingFeature.Steps
{
    [Binding]
    public sealed class HotelList_Steps
    {
        protected readonly IWebDriver browser;
        private HotelListIMPL HotelList;

        [Given(@"I am in the Booking home page")]
        public void GivenIAmInTheBookingHomePage()
        {
            HotelList = new HotelListIMPL();
            HotelList.GivenIAmInTheBookingHomePage();
        }

        [When(@"I inform a place")]
        public void WhenIInformAPlace()
        {
            HotelList.WhenIInformAPlace();
        }

        [When(@"i select my stay period")]
        public void WhenISelectMyStayPeriod()
        {
            HotelList.WhenISelectMyStayPeriod();
        }
        
        [When(@"I do the search")]
        public void WhenIDoTheSearch()
        {
            HotelList.WhenIDoTheSearch();
        }

        [When(@"I select the Sauna filter")]
        public void WhenISelectTheSaunaFilter()
        {
            HotelList.WhenISelectTheSaunaFilter();
        }

        [When(@"I select the 5 Star filter")]
        public void WhenISelectThe5StarFilter()
        {
            HotelList.WhenISelectThe5StarFilter();
        }

        [Then(@"i check wich (.*) are avaliable")]
        public void ThenICheckWichAreAvaliable(string hotel)
        {
            HotelList.ThenICheckWichAreAvaliable(hotel);

        }
    }
}
