Feature: KurtosysWeb

A short summary of the feature

@tag1
Scenario: Functional API Test
	Given User navigate to the URL"https://www.kurtosys.com"
	Then User should recieve the 200 status code
	And User should recieve the response time within two seconds.
	And User should recieve the server header having a value of Cloudflare
