Feature: StringManipulation

@UpperCase
Scenario: UpperCase
	When I consume UpperCase service with 'tEsT' string
	Then the result should be 'TEST' on the screen
