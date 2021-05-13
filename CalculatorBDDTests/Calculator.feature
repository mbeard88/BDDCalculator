Feature: Calculator
	Simple calculator for adding two number
	In order to avoid silly mistakes
	As a maths idiot
	I want to be able to do simple calculations
@mytag
Scenario: Add two numbers
	Given I have a calculator
	And I enter 5 and 2 into the calculator
	When when I press add
	Then the result should be 7