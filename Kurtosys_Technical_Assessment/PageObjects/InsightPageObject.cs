using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurtosys_Technical_Assessment.Utilities;

namespace Kurtosys_Technical_Assessment.PageObjects
{
     class InsightPageObject
    {
        IWebDriver driver;
        public InsightPageObject()
        {
            driver = Hooks.driver;
        }

        IWebElement insights => driver.FindElement(By.XPath("//span[contains(text(),'Insights')]"));
        IWebElement whitePapersAndeBooks => driver.FindElement(By.XPath("//*[@id=\"kurtosys-menu-item-75710\"]/div/div/div/div/section/div/div/div/div/div/div/div/ul/li[3]/a/span"));
        IWebElement whitePapers => driver.FindElement(By.XPath("//h2[contains(text(),'White Papers')]"));
        IWebElement ucitWhitepaper => driver.FindElement(By.XPath("/html/body/div[2]/div/section[2]/div/div/div/div/div/div/div/div[1]/article[7]/div/div[1]/p/a"));
        IWebElement firstName => driver.FindElement(By.XPath("//label[contains(text(),'First Name')]"));
        IWebElement lastName => driver.FindElement(By.XPath("//label[contains(text(),'Last Name')]"));
        IWebElement email => driver.FindElement(By.XPath("//label[contains(text(),'Email*')]"));
        IWebElement company => driver.FindElement(By.XPath("//label[contains(text(),'Company')]"));
        IWebElement industry => driver.FindElement(By.XPath("//label[contains(text(),'Industry')]"));
        IWebElement sendMeAcopy => driver.FindElement(By.XPath("//*[@id=\"pardot-form\"]/p[2]/input"));
        IWebElement Accept_cookies=> driver.FindElement(By.XPath("//*[@id=\'onetrust-accept-btn-handler\']"));
        IWebElement myElement => driver.FindElement(By.XPath("/html/body/div[2]/div/section[2]/div/div/div/div/div/div/div/div[1]/article[7]/div/div[2]"));
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.kurtosys.com/");
        }

        public void Insights()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(insights).Build().Perform();
        }
        public void WhitePapersAndeBooks()
        {
            whitePapersAndeBooks.Click();
        }
        public bool IsWhitePapersDisplayed()
        {
            return whitePapers.Displayed;
        }
        public void UCITWhitepaper()
        {
            
            Actions actions = new Actions(driver);
            actions.MoveToElement(myElement).Build().Perform();

            ucitWhitepaper.Click();
            Thread.Sleep(12000);
            Accept_cookies.Click();
        }
        public void FirstName()
        {
            firstName.SendKeys("First_Test");
        }
        public void LastName()
        {
            lastName.SendKeys("Last_Test");
        }
        public void Email()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(100);

            email.SendKeys("test"+ randomInt + "@Kurtosys.com");
        }

        public void Company()
        {
            company.SendKeys("Kurtosys");
        }
        public void Industry()
        {
            industry.SendKeys("Information Technology");
        }
        public void SubmitButton()
        {
            sendMeAcopy.Click();
        }
    }
}
