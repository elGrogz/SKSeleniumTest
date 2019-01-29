Feature: SitekitHomepage
	As a visitor to the Sitekit homepage
	I want to be able to view basic contact information
	So that I know how to contact Sitekit

Scenario: Correct Contact number is displayed
	When I navigate to the Sitekit homepage
	Then I can see the contact number is '08452990900'
	

Scenario Outline: Correct Office is displayed
	Given I am on the Sitekit homepage
	Then I can see '<city>' is a listed office

	Examples: 
	| city   |
	| Oxford |
	| London |
