using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;

namespace DealerOn_Project.Steps
{
    [Binding]
    public class AboutUsSteps : BaseClass
    {
        [Given(@"I open Chrome browser yet again")]
        public void GivenIOpenChromeBrowserYetAgain()
        {
            driver = new ChromeDriver("C:\\Users\\hunte\\source\\repos");
        }

        [Given(@"I navigate to https://www\.rothbardchevy\.com/ yet again")]
        public void GivenINavigateToHttpsWww_Rothbardchevy_ComYetAgain()
        {
            driver.Navigate().GoToUrl("https://www.rothbardchevy.com/");
        }

        [Given(@"I go to Meet Our Staff page")]
        public void GivenIGoToMeetOurStaffPage()
        {
            driver.FindElement(By.CssSelector("img[alt='close window']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            Actions action = new Actions(driver);
            IWebElement aboutUs = driver.FindElement(By.Id("parent_6"));
            action.MoveToElement(aboutUs).Perform();

            driver.FindElement(By.Id("7_child_3")).Click();
        }
        
        [Given(@"I go to Executive Team page")]
        public void GivenIGoToExecutiveTeamPage()
        {
            driver.FindElement(By.LinkText("Executive Team")).Click();
        }
        
        [When(@"I see Jax Rothbards phone number")]
        public void WhenISeeJaxRothbardsPhoneNumber()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            System.Threading.Thread.Sleep(250);
            IWebElement phoneNumber = driver.FindElement(By.XPath("//*[@id='tab-pane-4417']/div[1]/div[2]/ul/li[3]/ul/li[2]/a"));
            String phone = phoneNumber.Text;
            Assert.AreEqual("584-681-5189", phone);
        }

        [Then(@"it will match expected")]
        public void ThenItWillMatch()
        {

        }
        
        [Then(@"close browser yet again")]
        public void ThenCloseBrowserYetAgain()
        {
            driver.Quit();
        }
    }
}
