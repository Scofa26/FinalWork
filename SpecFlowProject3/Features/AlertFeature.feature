Feature: AlertFeature

Проверка текста на всплывающем окне (использовала hover)
Background: Precondition authorization
    Given open the login page and enter pass and email

@GUI
@allure.label.suite:GUI
@critical
@allure.label.owner:SophiaChida
Scenario: Validation text in alert
	When user hovers navbaricon
	Then alert is opened 
	* alerts Title is equal to "Testmo resources"

