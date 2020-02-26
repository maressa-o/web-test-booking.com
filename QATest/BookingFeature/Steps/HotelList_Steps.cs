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

        [When(@"I inform a city")]
        public void WhenIInformACity()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i select a Checking date")]
        public void WhenISelectACheckingDate()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"i select a Checkout date")]
        public void WhenISelectACheckoutDate()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I press the Search button")]
        public void WhenIPressTheSearchButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select the Sauna filter")]
        public void WhenISelectTheSaunaFilter()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the Limerick Strand Hotel should be visible")]
        public void ThenTheLimerickStrandHotelShouldBeVisible()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the George Limerick Hotel should not be visible")]
        public void ThenTheGeorgeLimerickHotelShouldNotBeVisible()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select the (.*) Star filter")]
        public void WhenISelectTheStarFilter(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
