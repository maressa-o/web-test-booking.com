Feature: This story represents the user's search flow in the Booking site.

Background: 
			Given I am in the Booking home page

@Browser:Chrome @Sauna
Scenario: Find hotels with Sauna filter on Booking 

	When I inform a place 
	And i select my stay period
	And I do the search
	And I select the Sauna filter
	Then i check wich <hotels> are avaliable

	Examples:

		| hotel                 |
		| Limerick Strand Hotel |
		| George Limerick Hotel |

@Browser:Chrome @5Stars
Scenario: Find hotels with 5 Star filter on Booking

	When I inform a place 
	And i select my stay period
	And I do the search
	And I select the 5 Star filter
	Then i check wich <hotels> are avaliable

	Examples:

		| hotel                 |
		| The Savoy Hotel       |
		| George Limerick Hotel |
		