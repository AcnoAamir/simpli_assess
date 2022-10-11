Feature: Add2Remove1
		Testing to see if the bot can order me some meds


@ToDoApp
Scenario: Add 2 items to cart 
	Given I open the app
	And I login in
	And I select first item
	And I select second item
	And I remove 1 item
	When when I press Submit
	Then I check