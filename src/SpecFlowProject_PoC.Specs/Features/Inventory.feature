Feature: Inventory

This feature is to test the inventory functionality

@tag1
Scenario: Get all inventory
 Given There are 55 items in the inventory
 When I get all the inventory
 Then I should get 55 items

Scenario: Add item to inventory
 Given There are 20 items in the inventory
 When I add 5 item to inventory
 Then I should get 25 items

Scenario: Remove item From inventory
 Given There are 100 items in the inventory
 When I remove 20 item from inventory
 Then I should get 80 items
