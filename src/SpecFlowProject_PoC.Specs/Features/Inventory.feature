Feature: Inventory

This feature is to test the inventory functionality

@tag1
Scenario: Get all inventory
	Given There are 55 item in the inventory
	When I get all the inventory
	Then I should get 55 items
