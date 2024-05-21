Feature: Insight_Tab

In order to use the benefit of the website
I will need to first navigate to https://www.kurtosys.com/

@tag1
Scenario: Valid/positive test
	Given User navigate to the website
	And User navigate to the insight tab
	And From the dropdown I choose White Papers & eBooks option
	And Validate the title that reads White Papers
	And User click on UCITS Whitepaper 
	And User enter Last Name
	And User enter Company
	And User enter Industry
	And User enter the email address
	When User click on send me a copy button
	And User take screenshot of the error messages
	Then Validate all massages and they should be thank you successful message


