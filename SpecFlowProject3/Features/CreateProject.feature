Feature: CreateProject

Проверка на успешное создание сущности "Проект"
Проверка на ввод граничного значения в поле Summary

Background: Precondition authorization
    Given open the login page and enter pass and email

@GUI
Scenario: Succsessful creating the project
	When user click AddProjectButton
	* modal dialog is opened
	* user enters "projectName1" to the projectName field and "projectSummary" to the projectSummary field
	Then Project is created with name "projectName1"

@GUI
Scenario: Succsessful filling the summary field by boundary value
	When user click AddProjectButton
	* modal dialog is opened
	* user enters "projectName2" to the projectName field and summary 
	"""markdown
	Test with successful filling the summary field by boundary value. Count of chars
	"""
	Then count of chars is equal to 80
	* Project is created with name "projectName2"

