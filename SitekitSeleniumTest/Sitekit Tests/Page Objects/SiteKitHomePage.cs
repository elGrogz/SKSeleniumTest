using OpenQA.Selenium;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SitekitSeleniumTest.Sitekit_Tests.Page_Objects
{
    [Binding]
    public class SiteKitHomePage
    {
        private IWebDriver _driver;

        private IWebElement ContactNumberElement => _driver.FindElement(By.XPath("//div[@id='contact']/div/div/div[2]/h3"));
        private IList<IWebElement> OfficeListElement => _driver.FindElements(By.XPath("//div[contains(@class, 'our-offices')]/h4/a/strong"));

        public SiteKitHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToSiteKitHomePage()
        {
            _driver.Navigate().GoToUrl("http://www.sitekit.net");
        }

        public string GetContactNumber() => ContactNumberElement.Text.RemoveSpacesFromString();

        public List<string> GetListOfOffices()
        {
            var officeList = new List<string>();

            foreach (var office in OfficeListElement)
            {
                officeList.Add(office.Text.RemoveCommasFromString());
            }

            return officeList;
        }
    }
}
