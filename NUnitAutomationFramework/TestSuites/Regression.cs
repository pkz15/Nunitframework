using NUnit.Framework;
using NUnitAutomationFramework.Base;
using NUnitAutomationFramework.Pages;
using NUnitAutomationFramework.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitAutomationFramework.TestSuites
{
    [Parallelizable(ParallelScope.Children)]
    public class Regression : BaseSetup
    {
        [Test, Category("Regression")]
        public void ExploreMoreValidation()
        { 
            string? testcase = TestContext.CurrentContext.Test.MethodName;
            HomePage page = new(GetDriver(), extent_test.Value);
            page.OpenExploreMore();
            extent_test.Value.Pass("Open Explore Tab Testcase is passed");
        }

        [Test ,Category("Regression")]
        public void FillContactUsForm()
        {
            string? testcase = TestContext.CurrentContext.Test.MethodName;
            var contactPage = new ContactSale(GetDriver(), extent_test.Value);
            contactPage.ClickContactSaleButton();
            contactPage.SelectHelpOption("Careers or HR Inquiry");
            contactPage.EnterEmail("testuser@gmail.com");
            contactPage.EnterFirstName("Prem");
            contactPage.EnterLastName("M");
            contactPage.EnterCompany("TestCompany");
            contactPage.EnterJobTitle("QA Automation Engineer");
            contactPage.EnterPhone("9876543210");
            contactPage.SelectCountry("United States");
            contactPage.SelectState("Florida");
            contactPage.CheckConsent();
            extent_test.Value.Pass("Form Filling Completed Passed...");


        }
    }
}
