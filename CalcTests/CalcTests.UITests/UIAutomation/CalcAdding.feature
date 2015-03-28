Feature: CalcAdding
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Add two numbers
	When I add 1 and 2
	Then the result should be 3 on the screen

Scenario: Add two negative numbers
	When I add -1 and -2
	Then the result should be -3 on the screen

Scenario: Add negative and positive numbers
	When I add -1 and 2
	Then the result should be 1 on the screen