Feature: StringManipulation

@UpperCase
Scenario: Validate Upper Case Service
	When I consume UpperCase service with 'tEsT' string
	Then the result should be 'TEST' on the screen

	When I consume UpperCase service with '123' string
	Then the result should be '123' on the screen

	When I consume UpperCase service with '' string
	Then the result should be '' on the screen

	When I consume UpperCase service with 'aA1!9(' string
	Then the result should be 'AA1!9(' on the screen