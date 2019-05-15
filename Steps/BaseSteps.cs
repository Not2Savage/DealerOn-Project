using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DealerOn_Project.Steps 
{
    [Binding]
    public class BaseSteps : BaseClass
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

        [Then(@"close browser")]
        public void ThenCloseBrowser()
        {
            driver.Quit();
        }
    }
}
