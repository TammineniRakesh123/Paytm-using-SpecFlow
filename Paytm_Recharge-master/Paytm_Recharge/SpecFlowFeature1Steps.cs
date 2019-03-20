using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Paytm_Recharge
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        bool NoelementFound;
        IWebDriver driver=new ChromeDriver();
        [Given]
        public void GivenOpenPaytmWebBrowser()
        {
            driver.Navigate().GoToUrl("https://paytm.com/");
        }
        
        [Given]
        public void GivenInPaytmWebsiteSelect_P0_Option(string p0)
        {
            driver.Navigate().GoToUrl("https://paytm.com");
            driver.FindElement(By.XPath("//*[@id='app']/div/div[3]/div/div[1]/div/a[1]/div/img")).Click();
        }

        [Given]
        public void GivenClickedMobile()
        {
            //driver.FindElement(By.XPath("//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[1]/div[1]/label/i")).SendKeys(Keys.Enter);
        }
        [Given]
        public void GivenLaterEnterThe_P0(string p0)
        {
            driver.FindElement(By.XPath("//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[2]/ul/li[1]/div/div/input")).SendKeys("8296865364");
        }
        
        [Given]
        public void GivenEnterTheAmount()
        {
            driver.FindElement(By.XPath("//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[2]/ul/li[3]/div[1]/div[1]/input")).SendKeys("448");

        }
        
        [When]
        public void WhenInPaytmWebsiteThereShouldBeMobileElectricityDTHMetro()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='app']/div/div[3]/div/div[1]/div/a[1]/div/img"));//Mobile 
                driver.FindElement(By.XPath("//*[@id='app']/div/div[3]/div/div[1]/div/a[2]/div"));//electricity
                driver.FindElement(By.XPath("//*[@id='app']/div/div[3]/div/div[1]/div/a[3]/div"));//DTH
                driver.FindElement(By.XPath("//*[@id='app']/div/div[3]/div/div[1]/div/a[4]/div/img"));//Metro
            }
            catch(Exception e)
            {
                NoelementFound = true;
            }
        }
        
        [When]
        public void WhenClickedOnProceedToRecharge()
        {
            driver.FindElement(By.XPath("//*[@id='app']/div/div[4]/div[1]/div[1]/div/div[2]/div[5]/button")).SendKeys(Keys.Return);
        }
        
        [Then]
        public void ThenCheckIfTheElementsArePresent()
        {
              Assert.IsFalse(NoelementFound);
        }
        
        [Then]
        public void ThenItShouldRedirectTo_P0(string p0)
        {
            
            Assert.IsNotNull(driver.FindElement(By.XPath("//*[@id='app']/div/div[4]/div[2]")));
        }

        [AfterScenario]
        public void exit()
        {
            driver.Dispose();
        }

    }
}
