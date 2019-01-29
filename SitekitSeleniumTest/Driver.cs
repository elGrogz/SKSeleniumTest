using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SitekitSeleniumTest
{
    [Binding]
    public class Driver
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void TestRunSetup()
        {
            _driver = new ChromeDriver();
            ScenarioContext.Current["driver"] = _driver;
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TestCleanup()
        {
            _driver.Quit();
        }

    }
}
