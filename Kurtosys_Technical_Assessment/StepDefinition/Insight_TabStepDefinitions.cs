using Kurtosys_Technical_Assessment.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Kurtosys_Technical_Assessment.StepDefinition
{
    [Binding]
    public class Insight_TabStepDefinitions
    {
        InsightPageObject insightPageObject;

        Insight_TabStepDefinitions() 
        {
            insightPageObject = new InsightPageObject();
        }


        [Given(@"User navigate to the website")]
        public void GivenUserNavigateToTheWebsite()
        {
            insightPageObject.NavigateToWebsite();
        }

        [Given(@"User navigate to the insight tab")]
        public void GivenUserNavigateToTheInsightTab()
        {
            insightPageObject.Insights();
        }

        [Given(@"From the dropdown I choose White Papers & eBooks option")]
        public void GivenFromTheDropdownIChooseWhitePapersEBooksOption()
        {
            insightPageObject.WhitePapersAndeBooks();
        }

        [Given(@"Validate the title that reads White Papers")]
        public void GivenValidateTheTitleThatReadsWhitePapers()
        {
            Thread.Sleep(4000);
            Assert.That(insightPageObject.IsWhitePapersDisplayed());
        }

        [Given(@"User click on UCITS Whitepaper")]
        public void GivenUserClickOnUCITSWhitepaper()
        {

            insightPageObject.UCITWhitepaper();
        }

        [Given(@"User enter Last Name")]
        public void GivenUserEnterLastName()
        {
            insightPageObject.LastName();
        }

        [Given(@"User enter Company")]
        public void GivenUserEnterCompany()
        {
            throw new PendingStepException();
        }

        [Given(@"User enter Industry")]
        public void GivenUserEnterIndustry()
        {
            insightPageObject.Industry();
        }

        [Given(@"User enter the email address")]
        public void GivenUserEnterTheEmailAddress()
        {
            insightPageObject.Email();
        }

        [When(@"User click on send me a copy button")]
        public void WhenUserClickOnSendMeACopyButton()
        {
            insightPageObject.SubmitButton();
        }

        [When(@"User take screenshot of the error messages")]
        public void WhenUserTakeScreenshotOfTheErrorMessages()
        {
            
        }

        [Then(@"Validate all massages and they should be thank you successful message")]
        public void ThenValidateAllMassagesAndTheyShouldBeThankYouSuccessfulMessage()
        {
            
        }
    }
}
