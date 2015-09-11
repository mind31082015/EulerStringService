Feature: StringManipulationExtension

@LowerCase
Scenario: Validate Lower Case Service
	When I consume LowerCase service with 'tEsT' string
	Then the result should be 'test' on the screen

	When I consume LowerCase service with '123' string
	Then the result should be '123' on the screen

	When I consume LowerCase service with '' string
	Then the result should be '' on the screen

	When I consume LowerCase service with 'aA1!9(' string
	Then the result should be 'aa1!9(' on the screen

@Reverse
Scenario: Validate Reverse Service
	When I consume Reverse service with 'tEsT' string
	Then the result should be 'TsEt' on the screen

	When I consume Reverse service with '123' string
	Then the result should be '321' on the screen

	When I consume Reverse service with '' string
	Then the result should be '' on the screen

	When I consume Reverse service with 'aA1!9(' string
	Then the result should be '(9!1Aa' on the screen