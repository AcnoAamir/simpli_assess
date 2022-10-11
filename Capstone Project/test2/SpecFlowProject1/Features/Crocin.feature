Feature: Search and Add Crocin
	See the seacrhing of items

@ToDoApp
Scenario: Add 2 items to cart 
	Given I open the app
	And I login in
	And I search for Crocin
	And I add it to cart
	When when I press Submit
	Then I check