Feature: Searching on google.com
	Check knowledge of WebDriver

Scenario Outline: Check searchpage contains images 
	When User makes input is <input>
	When User click on searchbutton
	Then User checks searchpage contains images 
	Examples: 
	| input				| 
	| cats images       |
	| зображення кавуна |
