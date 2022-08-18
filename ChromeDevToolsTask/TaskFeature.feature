Feature: Mail on gmail.com
	Check knowledge of WebDriver

Scenario Outline: Check login and mail on gmail.com
	When User input login is <login>
	Then User clicks on next loginbutton
	When User input password is <password>
	Then User clicks on next passwordbutton
	Given User clicks on writebutton
	When User input receiver is <receiver>
	When User input subject is <subject>
	When User input message is <text>
	Then User clicks on sendbutton
	
	Examples: 
	| login                    | password          | receiver             | subject      | text                 |
	| ac.for.testing@gmail.com | frfeynajhntcnsyu9 | flikeset99@gmail.com | Test_message | This is test message |

