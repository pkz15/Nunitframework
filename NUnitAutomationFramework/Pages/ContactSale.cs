using AventStack.ExtentReports;
using NUnit.Framework;
using NUnitAutomationFramework.Base;
using NUnitAutomationFramework.WebElements;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V102.DOM;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NUnitAutomationFramework.Pages
{
    public class ContactSale
    {
        
        private readonly IWebDriver driver;
        private readonly ExtentTest test;
        public ContactSale(IWebDriver driver, ExtentTest test)
        {
            this.driver = driver;
            this.test = test;
        }

        private readonly By helpDropdown = By.XPath("//select[@id='generalInquiryType']");
        private readonly By emailField = By.XPath("//form[@id='mktoForm_1028']//input[@id='Email']");
        private readonly By firstNameField = By.XPath("//form[@id='mktoForm_1028']//input[@id='FirstName']");
        private readonly By lastNameField = By.XPath("//form[@id='mktoForm_1028']//input[@id='LastName']");
        private readonly By companyField = By.XPath("//form[@id='mktoForm_1028']//input[@id='Company']");
        private readonly By jobTitleField = By.XPath("//form[@id='mktoForm_1028']//input[@id='Title']");
        private readonly By phoneField = By.XPath("//form[@id='mktoForm_1028']//input[@id='Phone']");
        private readonly By countryDropdown = By.XPath("//form[@id='mktoForm_1028']//select[@id='Country']");
        private readonly By stateDropdown = By.XPath("//form[@id='mktoForm_1028']//select[@id='State']");
        private readonly By consentCheckbox = By.XPath("//input[@id='mktoCheckbox_10921_0']");
        private readonly By ContactSaleButton = By.XPath("//span[normalize-space()='Contact Sales']");
        private readonly By ExploreMore = By.XPath("//span[normalize-space()='Explore More']");
        private readonly By ClosePopUp = By.ClassName("close-exit-intent");

        public void ClickContactSaleButton()
        {
            driver.FindElement(ExploreMore).Click();
            //Thread.Sleep(1000);
            try { driver.FindElement(ContactSaleButton).Click(); }
            catch (Exception e) {
                driver.FindElement(ClosePopUp).Click();
                driver.FindElement(ContactSaleButton).Click();
            }
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("https://www.hitachivantara.com/en-us/company/contact");
        }
        public void SelectHelpOption(string value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement dropdown = wait.Until(ExpectedConditions.ElementIsVisible(helpDropdown));
            //SelectElement select = new SelectElement(dropdown);
            new SelectElement(driver.FindElement(helpDropdown)).SelectByValue(value);
        }

        public void EnterEmail(string email)
        {
            driver.FindElement(emailField).SendKeys(email);
        }

        public void EnterFirstName(string firstName)
        {
            driver.FindElement(firstNameField).SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            driver.FindElement(lastNameField).SendKeys(lastName);
        }

        public void EnterCompany(string company)
        {
            driver.FindElement(companyField).SendKeys(company);
        }

        public void EnterJobTitle(string title)
        {
            driver.FindElement(jobTitleField).SendKeys(title);
        }

        public void EnterPhone(string phone)
        {
            driver.FindElement(phoneField).SendKeys(phone);
        }

        public void SelectCountry(string country)
        {
            new SelectElement(driver.FindElement(countryDropdown)).SelectByText(country);
        }

        public void SelectState(string state)
        {
            new SelectElement(driver.FindElement(stateDropdown)).SelectByText(state);
        }

        public void CheckConsent()
        {
            IWebElement checkbox = driver.FindElement(consentCheckbox);
            if (!checkbox.Selected)
            {
                checkbox.Click();
            }
        }

    }
}

