Feature: DeleteProjectFeature

Проверка удаления сущности "Проект"
Проверка на отображение диалогового окна. При нажатии на иконку удаления проекта, всплывает диалоговое окно.

Background: Precondition authorization
    Given open the login page and enter pass and email

@GUI
@allure.label.suite:GUI
@critical
@allure.label.owner:SophiaChida
Scenario: Successful deleting project
	Given user clicks Admin button on HomePage
	* user clicks Projects section
	When user clicks delete item
	* delete modal dialog is opened 
	* user confirms agreement checkbox
	* user clicks Delete project button
	Then Project successfully deleted
