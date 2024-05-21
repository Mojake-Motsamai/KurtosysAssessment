using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Kurtosys_Technical_Assessment.Utilities
{
    [Binding]
    public  class Hooks
    {

        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}