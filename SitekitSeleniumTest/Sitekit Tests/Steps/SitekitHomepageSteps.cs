using NUnit.Framework;
using OpenQA.Selenium;
using SitekitSeleniumTest.Sitekit_Tests.Page_Objects;
using TechTalk.SpecFlow;

namespace SitekitSeleniumTest.Sitekit_Tests.Steps
{
    [Binding]
    public class SitekitHomepageSteps
    {
        private SiteKitHomePage _homepage;

        public SitekitHomepageSteps()
        {
            var driver = (IWebDriver)ScenarioContext.Current["driver"];
            _homepage = new SiteKitHomePage(driver);
        }

        [Given(@"I am on the Sitekit homepage")]
        [When(@"I navigate to the Sitekit homepage")]
        public void INavigateToTheSitekitHomepage()
        {
            _homepage.NavigateToSiteKitHomePage();
        }

        [Then(@"I can see the contact number is '(.*)'")]
        public void ICanSeeTheContactNumberIs(string expectedNumber)
        {
            var actualNumber = _homepage.GetContactNumber();

            Assert.AreEqual(expectedNumber, actualNumber, "Expected contact number and actual contact number do not match.");
        }

        [Then(@"I can see '(.*)' is a listed office")]
        public void ICanSeeTheOfficeIsListed(string office)
        {
            var officeList = _homepage.GetListOfOffices();

            var expectedOfficeIsDisplayed = officeList.Contains(office);

            Assert.IsTrue(expectedOfficeIsDisplayed, "The Oxford office is not displayed on the Sitekit homepage.");
        }
    }
}
