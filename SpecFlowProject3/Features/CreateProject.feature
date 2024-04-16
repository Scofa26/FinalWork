Feature: CreateProject

Проверка на успешное создание сущности "Проект"

Background: Precondition authorization
    Given open the login page and enter pass and email

@GUI
Scenario: Succsessful creating the project
	When user click AddProjectButton
	* modal dialog is opened
	* user enters "projectName1" to the projectName field and "projectSummary" to the projectSummary field
	Then Project is created with name "projectName1"