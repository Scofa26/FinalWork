﻿Feature: IncorrectDataLoginFeature

Проверка на ввод некорректных данных на логин странице

@GUI
@allure.label.suite:GUI
@critical
@allure.label.owner:SophiaChida
Scenario: IncorrectLogin
	Given open the login page and enter wrong pass and wrong email
	Then Get error message
