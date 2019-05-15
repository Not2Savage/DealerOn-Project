Feature: AboutUs

Scenario: Assert Jax's number matches expected results
	Given I open Chrome browser yet again
	Given I navigate to https://www.rothbardchevy.com/ yet again
	And I go to Meet Our Staff page
	And I go to Executive Team page
	When I see Jax Rothbards phone number
	Then it will match expected
	Then close browser yet again
