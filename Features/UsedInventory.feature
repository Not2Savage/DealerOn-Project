Feature: UsedInventory

Scenario: Assert used vehicle page has used vehicles
	Given I open Chrome browser
	Given I navigate to https://www.rothbardchevy.com/
	And I go to Used Inventory page
	When I assert mileage for each vehicle
	Then results will be definately used vehicles
	Then close browser
