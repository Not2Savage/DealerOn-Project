Feature: SearchInventoryFeature
Scenario: User searches for 2017 Chevrolet Corvette
	Given I open Chrome browser again
	Given I navigate to https://www.rothbardchevy.com/ again
	When I select Used in inventory search
	And I select year 2017
	And I select make Chevrolet
	And I select model Corvette
	And I select search
	Then results page should show 2017 Chevrolet Corvette results
	Then close browser again
