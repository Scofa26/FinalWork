Feature: APIProjectFeature

API тесты Project 

@API
@allure.label.suite:API
@critical
@allure.label.owner:SophiaChida
Scenario: NFE Get Project
	Given called get project service with id "42"
	Then project is successfully got

@API
@allure.label.suite:API
@critical
@allure.label.owner:SophiaChida
Scenario: AFE Get Project with non-existetnt id
	Given called get project service with non-existetnt id "1"
	Then get the error message "{"message":"The project does not exist or you do not have the permissions to access it.","code":0}"
	* status code "NotFound"

@API
@allure.label.suite:API
@critical
@allure.label.owner:SophiaChida
Scenario: AFE Get Project with no auth
	Given called get project service with id "42" without auth
	Then status code is "Unauthorized"