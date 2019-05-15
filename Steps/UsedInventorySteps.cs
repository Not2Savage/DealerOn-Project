using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DealerOn_Project.Steps 
{
    [Binding]
    public class UsedInventorySteps : BaseClass
    {
        [Given(@"I open Chrome browser")]
        public void GivenIOpenChromeBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\hunte\\source\\repos");
            
        }
        
        [Given(@"I navigate to https://www\.rothbardchevy\.com/")]
        public void GivenINavigateToHttpsWww_Rothbardchevy_Com()
        {
            driver.Navigate().GoToUrl("https://www.rothbardchevy.com/");
        }
        
        [Given(@"I go to Used Inventory page")]
        public void GivenIGoToUsedInventoryPage()
        {
            driver.FindElement(By.Id("parent_2")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
        
        [When(@"I assert mileage for each vehicle")]
        public void WhenIAssertMileageForEachVehicle()
        {
            Assert.AreEqual(
                driver.FindElements(By.CssSelector("div.srpVehicle")).Count, 
                driver.FindElements(By.CssSelector(".margin-top-1x > ul > li.mileageDisplay")).Count);   
        }
        
        [Then(@"results will be definately used vehicles")]
        public void ThenResultsWillBeDefinatelyUsedVehicles()
        {
            
        }
        
        
        [Then(@"close browser")]
        public void ThenCloseBrowser()
        {
            driver.Quit();
        }
    }
}
