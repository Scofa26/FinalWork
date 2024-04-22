Feature: APIPostFeature

Проверка POST для AutomationRun

@API
@allure.label.story:API
@critical
@allure.label.owner:SophiaChida
Scenario: Api Post Test
	Given called automation run with id "41"
	Then status code is 201 Created 
