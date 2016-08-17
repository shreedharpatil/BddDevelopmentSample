Feature: LoginFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario: Should login to application successfully
	Given I have entered username in username field
	And I have entered password in password field
	When I click login
	Then system should validate entered credentials and home page should be displayed

	Scenario: Should show error message for invalid credentials
	Given I have entered invalid username in username field
	And I have entered password in password field
	When I click login button
	Then system should validate entered credentials and show username invalid error messages