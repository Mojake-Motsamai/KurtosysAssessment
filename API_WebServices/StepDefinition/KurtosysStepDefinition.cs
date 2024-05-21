using API_WebServices.Utilities;
using OpenQA.Selenium.DevTools.V123.CacheStorage;
using OpenQA.Selenium.DevTools.V123.Fetch;
using OpenQA.Selenium.DevTools.V124.CacheStorage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace API_WebServices.StepDefinition
{
    [Binding]
    class KurtosysStepDefinition
    {
        HttpClient _httpClient;
        HttpResponseMessage _responseMessage;

        string responseBody;
        private readonly ISpecFlowOutputHelper _outputHelper;
        string elapsedTime;

        
        public KurtosysStepDefinition(ISpecFlowOutputHelper _outputHelper )
        {
           _httpClient = new HttpClient();
            this._outputHelper = _outputHelper;
        }
        

        
        [Given(@"User navigate to the URL""([^""]*)""")]
        public async Task GivenUserNavigateToTheURL(string url)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1000);
            //stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
             elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                     ts.Hours, ts.Minutes, ts.Seconds,
                     ts.Milliseconds);

            Console.WriteLine("RunTime " + elapsedTime);


            _responseMessage = await _httpClient.GetAsync(url);
            responseBody = await _responseMessage.Content.ReadAsStringAsync();
            stopWatch.Stop();

        }

        [Then(@"User should recieve the (.*) status code")]
        public void ThenUserShouldRecieveTheStatusCode(int p0)
        {
            Assert.True( _responseMessage.IsSuccessStatusCode );
        }
        [Then(@"User should recieve the response time within two seconds\.")]
        public void ThenUserShouldRecieveTheResponseTimeWithinTwoSeconds_()
        {
            Assert.Greater(elapsedTime, Is.GreaterThan(TimeSpan.FromSeconds(2)).ToString());
        }


        [Then(@"User should recieve the server header having a value of Cloudflare")]
        public void ThenUserShouldRecieveTheServerHeaderHavingAValueOfCloudflare()
        {
            Dictionary<string, string> HeaderList = new Dictionary<string, string>();

            foreach (var item in _responseMessage.Headers) 
            {
                string[] keyPairs = item.ToString().Split('=');
                HeaderList.Add(keyPairs[0], keyPairs[18]);
            }
            Assert.That(HeaderList["Server"], Is.EqualTo("Cloudflare"), "Server not matching");         
        }
    

    }
}
