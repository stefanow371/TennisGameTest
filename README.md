# qa-desktop-tennis-challenge
Recruitment task for Desktop Automation QAs

## Description:
The development team have completed a user story with the following requirements:

Write a program which can be used to track the score of a single set of a tennis game. The program will track a game of singles, where there are 2 players. These are the server and the receiver.

We would like to see the score once a player wins a point.  
We should be alerted when there is a winner.

> Server=1  
> Receiver=2  
> Please enter the player that wins the point: 

## Requirements:
As a system user I want to see the score increment correctly once a player wins a point.
- Given the score is 0:0, when the server wins a point Then the score is 15:0
- Given the score is 0:0 when the receiver wins a point Then the score is 0:15
- Given the score is 15:15 when the server wins a point Then the score is 30:15
- Given the score is 30:30 when the receiver wins a point then the score is 30:40

As a system user I want to see winner be declared correctly.
- Given the score is 40:30 when the server wins the they are declared the winner
- Given the score is 40:A when the receiver wins the point they are declared the winner

As a system user I want to see deuce and advantage scored correctly.
- Given the score is 40:40, when the server wins a point then the score should be A:40
- Given the score is A:40, when the receiver wins a point then the score should be 40:40

## Testers requirements:
A solution has been created with some incomplete unit tests. Write unit tests covering the requirements:
- As a system user I want to see winner be declared correctly
- As a system user I want to see deuce and advantage scored correctly
- As a system user I want to see the score is incremented correctly

There are three methods in the test API which will allow you to test the application:

`GivenTheScoreIs(server:Score.Fifteen, receiver:Score.Fifteen);`  
`WhenTheServerWinsAPoint();`  
`WhenTheReceiverWinsAPoint();`

The output is asserted:  
`Assert.That(ScoreOutput, Is.EqualTo("15:30"));`

There are some completed tests already in the solution to use as an example.

## Important notes:
Pleases note, **Both** of these tasks must be completed
1. Ensure **all** cases are covered, not only those in the requirements document. Add additional scenario folders and test fixtures where required.
2. The tests can be simplified. Please investigate how and then update the soloution to simplify all tests.
