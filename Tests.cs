using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace automation_template
{
    [TestClass]
    public class TestList : Base
    {
        [TestInitialize]
        public void SetupTest()
        {
            StartBrowser(BrowserToLaunch);
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
            NavigateTo();
        }

		[TestCategory("StableTestEnv"), TestMethod()]
        public void LoginAsAnExisingUser()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homePage = loginPage.Login("", "");
            //COMPLETE THE ASSERTATION TO CONFIRM LOGIN
        }
		
		[TestCategory("StableTestEnv"), TestMethod()]
        public void SearchForCurrentWeatherInBristol()
        {
            WeatherPage weatherPage = new WeatherPage();
            //COMPLETE THE CODE TO CALL THE TEST ON WEATHERPAGE.CS AND MAKE ASSERTATION
        }		

        [TestCleanup]
        public void TearDown()
        {
            string expectedResult = TestContext.CurrentTestOutcome.ToString();
            string nameOfTest = TestContext.TestName.ToString();
            if (expectedResult == "Failed")
            {
                takeScreenshotOfPage(currentDateTime + "_" + nameOfTest);
            }
            driver.Quit();
        }
    }
}
