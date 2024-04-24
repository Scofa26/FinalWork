Feature: CreateProject

Проверка на успешное создание сущности "Проект"
Проверка на ввод граничного значения в поле Summary
Проверка на ввод значения >80 символов в поле Summary
Зафейлиный тест на создание проекта
Проверка диалогового окна включена в эти тесты. На шаге * modal dialog is opened проверяю, что окно открыто, а также title

Background: Precondition authorization
    Given open the login page and enter pass and email

@GUI
@allure.label.suite:GUI
@critical
@allure.label.owner:SophiaChida
Scenario: Succsessful creating the project
	When user click AddProjectButton
	* modal dialog is opened
	* user enters "FirstProject" to the projectName field and "projectSummary" to the projectSummary field
	Then Project is created, homePage is opened

@GUI
@allure.label.suite:GUI
@critical
@allure.label.owner:SophiaChida
Scenario: Succsessful filling the summary field by boundary value
	When user click AddProjectButton
	* modal dialog is opened
	* user enters "projectName2" to the projectName field and summary 
	"""markdown
	Test with successful filling the summary field by boundary value. Count of chars
	"""
	Then count of chars is equal to 80
	* Project is created, homePage is opened

@GUI
@allure.label.suite:GUI
@critical
@allure.label.owner:SophiaChida
Scenario: Succsessful filling the summary field by value > 80
	When user click AddProjectButton
	* modal dialog is opened
	* user enters summary is more than 80
	"""markdown
	Test with successful filling the summary field by boundary value. Count of chars 83
	"""
	Then count of chars is equal to 80


@GUI
@allure.label.suite:GUI
@critical
@allure.label.owner:SophiaChida
Scenario: Failed creating the project
	When user click AddProjectButton
	* modal dialog is opened
	* user enters "" to the projectName field and "" to the projectSummary field
	Then Project is created, homePage is opened