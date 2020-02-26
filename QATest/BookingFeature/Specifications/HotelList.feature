Feature: This story represents the user's search flow in the Booking site.

Background: 
			Given I am in the Booking home page

@Browser:Chrome @Sauna
Scenario: Find hotels with Sauna filter on Booking 

	When I inform a city 
	And i select a Checking date 
	And i select a Checkout date
	And I press the Search button
	And I select the Sauna filter
	Then the Limerick Strand Hotel should be visible 
	And the George Limerick Hotel should not be visible

@Browser:Chrome @HotelList @5Stars
Scenario: Find hotels with 5 Star filter on Booking

	When I inform a city 
	And i select a Checking date 
	And i select a Checkout date
	And I press the Search button
	And I select the 5 Star filter
	Then the Limerick Strand Hotel should be visible 
	And the George Limerick Hotel should not be visible