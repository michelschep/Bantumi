Feature: BantumiBoard
	In order to play bantumi 
	As a player
	I want to have a interactive bantumi board

Background: 
	Given a player named Michel
	And a player named Geale
	And Michel plays Geale

Scenario: Play a non strike move
	Given an initial bantumi board
	When Michel plays field F4
	Then the board should be 
			| F1 | F2 | F3 | F4 | F5 | F6 |
			| 4  | 4  | 4  | 4  | 4  | 5  |
			| 4  | 4  | 4  | 0  | 5  | 5  |
	And score Michel-Geale should be 1-0
	And it is Geale's turn

#Scenario: Play a non strike move without scoring
#	Given an initial bantumi board
#	When Michel plays field 2
#	Then the board should be 
#			| 4 | 4 | 4 | 4 | 4 | 5 |
#			| 4 | 0 | 5 | 5 | 5 | 5 |
#	And score Michel-Geale should be 1-0
#	And it is Geale's turn
#
#Scenario: Play a strike move
#	Given an initial bantumi board
#	When Michel plays field 4
#	Then the board should be 
#			| 4 | 4 | 4 | 4 | 4 | 4 |
#			| 4 | 4 | 0 | 5 | 5 | 5 |
#	And score Michel-Geale should be 1-0
#	And it is Michel's turn


