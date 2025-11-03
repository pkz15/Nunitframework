using OpenQA.Selenium;
using NUnitAutomationFramework.WebElements;
using NUnitAutomationFramework.Base;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace NUnitAutomationFramework.Pages
{
    public class HomePage
    {
        
        private readonly IWebDriver driver;
        private readonly ExtentTest test;
        public HomePage(IWebDriver driver, ExtentTest test)
        {
            this.driver = driver;
            this.test = test;
        }

        private readonly string ExploreMore = "//span[normalize-space()='Explore More']";
        private readonly string HeadingValidating = "//h1[@class='heading']";

        public void OpenExploreMore()
        {
            ActionsElements.Click(driver, By.XPath(ExploreMore));
            test.Log(Status.Info, "Successfully clicked on Explore More");
            //Thread.Sleep(2000);
            IWebElement heading = driver.FindElement(By.XPath(HeadingValidating));
            string HeadingText=heading.Text;
            Assert.AreEqual("The Data Foundations.", HeadingText);
        }
        
    }
}

