using System.Linq.Expressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Advanced
{

    public class EpamRandomTests
    {
        IWebDriver Driver;
        private WebDriverWait Wait;
        private Actions Action;
        IJavaScriptExecutor? js;
        
        private string _epamUrl = "https://www.epam.com/";

        [SetUp, Order(1)]
        public void SetupBrowser()
        {
            Driver = new ChromeDriver();
            Action = new Actions(Driver);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_epamUrl);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [SetUp, Order(2)]
        public void SetCoockies()
        {
            IJavaScriptExecutor? js = Driver as IJavaScriptExecutor;
            var coockisAccept = Driver.FindElement(By.Id("onetrust-accept-btn-handler"));
            js.ExecuteScript("arguments[0].click()", coockisAccept);
        }
        
        [Test]
        public void Test1()
        {
            IJavaScriptExecutor? js = Driver as IJavaScriptExecutor;
            var action = new Actions(Driver);
            var careers =
                Driver.FindElement(By.XPath("//*[@href='/careers' and contains(@class, 'top-navigation__item-link')]"));
            action.MoveToElement(careers).Build().Perform();
            var joinourTeam = Driver.FindElement(By.XPath(
                "//*[@href = '/careers/job-listings' and contains(@class, 'bold-underlined-hover add-arrow' )]"));
            js.ExecuteScript("arguments[0].click()", joinourTeam);
            var expectedUrl = "https://www.epam.com/careers/job-listings";
            var JobListingsUrl = Driver.Url;
            Assert.AreEqual(expectedUrl, JobListingsUrl);
        }

        [Test]
        public void CheckLocationsPageAndApplyButton()
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;
            var action = new Actions(Driver);
            var careers =
                Driver.FindElement(By.XPath("//*[@href='/careers' and contains(@class, 'top-navigation__item-link')]"));
            action.MoveToElement(careers).Build().Perform();
            var hiringLocationsElement =
                Driver.FindElement(
                    By.XPath("//*[contains(@class, 'flyout-item')]/*[contains(@href, '/careers/locations')]"));
            hiringLocationsElement.Click();
            var applyButton = Driver.FindElement(By.XPath("//*[@href ='https://www.epam.com/careers/apply-now']"));
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", applyButton);
            Assert.IsTrue(applyButton.Displayed, "No Apply button displayed");
        }

        [Test]
        public void CheckLanguagesDropdown()
        {
            var languagesButton =
                Driver.FindElement(
                    By.XPath("//*[@class ='header__controls']//*[contains(@class, 'button-language-prefix')]"));
            Wait.IgnoreExceptionTypes(typeof(ElementNotInteractableException));
            var languageButtonClickableState = Wait.Until(condition =>
            {
                try
                {
                    var elementToDisplayed = languagesButton;
                    return elementToDisplayed.Displayed;
                }
                catch (ElementNotInteractableException)
                {
                    return false;
                }
            });
            languagesButton.Click();
            List<string> languages = new List<string>
            {
                "Hungary (English)", "СНГ (Русский)", "Česká Republika (Čeština)", "India (English)",
                "Україна (Українська)", "Czech Republic (English)", "日本 (日本語)", "中国 (中文)", "DACH (Deutsch)",
                "Polska  (Polski)"
            };
            var languagesActual = Driver.FindElements(By.XPath("//*[@class='location-selector__link']")).ToList();
            var languagesActualList = languagesActual.Select(a => a.GetAttribute("text"));
            Assert.AreEqual(languages, languagesActualList, "Incorrect languages list");
        }

        [Test]
        public void CheckViewMoreButtonPresent()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            int expectedNumberOfArcticles = 20;
            var searchButton = Driver.FindElement(By.CssSelector("[class*=dark-iconheader-search__search-icon]"));
            searchButton.Click();
            var randomElementOnSearchPanel = Driver.FindElement(By.CssSelector("li[class=frequent-searches__item]"));
            randomElementOnSearchPanel.Click();
            var findButton = Driver.FindElement(By.CssSelector("[class*=bth-text-layer]"));
            findButton.Click();
            js.ExecuteScript("javascript:window.scrollBy(0,document.body.scrollHeight-700)");
            var viewMoreButton = Driver.FindElement(By.CssSelector("[class*=search-results__view-more]"));
            Action.ScrollByAmount(100, 100);
            Action.ScrollToElement(viewMoreButton).Perform();
            var listOfArticles = Driver.FindElements(By.XPath("//article"));
            var actualNumberOfArticles = listOfArticles.Count;
            Assert.AreEqual(expectedNumberOfArcticles, actualNumberOfArticles);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}