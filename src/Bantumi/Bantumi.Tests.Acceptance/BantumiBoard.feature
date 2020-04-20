Feature: BantumiBoard
	In order to play bantumi 
	As a player
	I want to have a interactive bantumi board

@mytag
Scenario: Play the first strike move
	Given I have an initial bantumi board
	When I play field 3
	Then the board other player should be 
			| 4 | 4 | 4 | 4 | 4 | 4 |
	And my part of the board should be	
			| 4 | 4 | 0 | 5 | 5 | 5 |
	And score other player should be 0
	And my score should be 1
	And it is my turn again


