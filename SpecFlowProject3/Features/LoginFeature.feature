Feature: Login functionality


@GUI
Scenario: Successful login
	Given open the login page
	When user enters "email" to the email filed
	* user enters "password" to the password field
	* user clicks login button
	Then user is successfully login
