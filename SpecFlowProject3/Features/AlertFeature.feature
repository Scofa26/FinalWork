Feature: AlertFeature

Проверка текста на всплывающем окне (использовала hover)
Background: Precondition authorization
    Given open the login page and enter pass and email

@GUI
Scenario: Validation text in alert
	When user hovers navbaricon
	Then alert is opened 
	* alerts Title is equal to "Testmo resources"

