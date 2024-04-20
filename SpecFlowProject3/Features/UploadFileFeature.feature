Feature: UploadFileFeature

Проверка на загрузку файла
Background: Precondition authorization
    Given open the login page and enter pass and email

@GUI
@allure.label.story:UploadFileFeature
@critical
@allure.label.owner:SophiaChida
Scenario: Successful upload the file
	Given Repository page is opened
	When user clicks on add testcase button
	* user chooses file to upoad
	Then file is successfule uploaded and file name is displayed on add test case modal window
