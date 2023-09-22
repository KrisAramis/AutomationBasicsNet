using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace FinalTest;

public class Tests
{
    
    IWebDriver Driver;
    private string _epamUrl = "https://www.epam.com/";

    [SetUp, Order(1)]
    public void SetupBrowser()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Window.Maximize();
    }

    [SetUp, Order(2)]
    public void SetCoockies()
    {
        IJavaScriptExecutor? js = Driver as IJavaScriptExecutor;
        var coockisAccept = Driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        js.ExecuteScript("arguments[0].click()", coockisAccept);
    }

    [Test]
    public void CheckIfLearnMoreButtonPresent()
    {
        var carersUrl = "https://www.epam.com/careers";
        Driver.Navigate().GoToUrl(carersUrl);
        var learnMoreButtons =
            Driver.FindElements(
                By.XPath("//*[contains(@href,'https://www.epam.com/careers/external-referral-program')]"));
        bool learMorePresent = learnMoreButtons.Any();
        Assert.IsTrue(learMorePresent,"No \"learn more\" button present");
    }

    [Test]
    public void CheckEnglishSwitch()
    {
        
    }
    
    
}