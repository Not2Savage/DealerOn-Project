using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DealerOn_Project
{
    [Binding]
    public class SearchInventoryFeatureSteps : BaseClass
    {
        [Given(@"I open Chrome browser again")]
        public void GivenIOpenChromeBrowserAgain()
        {
            driver = new ChromeDriver("C:\\Users\\hunte\\source\\repos");
        }

        [Given(@"I navigate to https://www\.rothbardchevy\.com/ again")]
        public void GivenINavigateToHttpsWww_Rothbardchevy_ComAgain()
        {
            driver.Navigate().GoToUrl("https://www.rothbardchevy.com/");
        }

        [When(@"I select Used in inventory search")]
        public void WhenISelectUsedInInventorySearch()
        {
            driver.FindElement(By.CssSelector("#isVehicleType > div:nth-child(2)")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.CssSelector("#isVehicleType > div:nth-child(2)")).Click();
        }

        [When(@"I select year (.*)")]
        public void WhenISelectYear(int p0)
        {
            IWebElement year = driver.FindElement(By.CssSelector("select[inventory-filter='Year']"));
            SelectElement selectYear = new SelectElement(year);
            selectYear.SelectByValue("2017");
            
        }
        
        [When(@"I select make Chevrolet")]
        public void WhenISelectMakeChevrolet()
        {
            IWebElement make = driver.FindElement(By.CssSelector("select[inventory-filter='Make']"));
            SelectElement selectMake = new SelectElement(make);
            selectMake.SelectByValue("Chevrolet");
        }
        
        [When(@"I select model Corvette")]
        public void WhenISelectModelCorvette()
        {
            IWebElement model = driver.FindElement(By.CssSelector("select[inventory-filter='Model']"));
            SelectElement selectModel = new SelectElement(model);
            selectModel.SelectByValue("Corvette");
        }
        
        [When(@"I select search")]
        public void WhenISelectSearch()
        {
            driver.FindElement(By.Id("isSubmit")).Click();
        }
        
        [Then(@"results page should show (.*) Chevrolet Corvette results")]
        public void ThenResultsPageShouldShowChevroletCorvetteResults(int p0)
        {
            Assert.IsTrue(driver.FindElement(By.PartialLinkText("2017 Chevrolet Corvette")).Displayed);
        }

        [Then(@"close browser again")]
        public void ThenCloseBrowserAgain()
        {
            driver.Quit();
        }
    }
}
