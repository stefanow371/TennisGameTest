using NUnit.Framework;
using TennisGame.UnitTests.Resources;

namespace TennisGame.UnitTests.The_Score_Should_Increment_Once_A_Player_Scores
{
    [TestFixture]
    public class Server_Is_A_Winner : Helper
    {
        //TestCase(serverScore, receiverScore, expected)

        [Test]
        [TestCase(Score.Fourty, Score.Zero, Scores.win_zero)]
        [TestCase(Score.Fourty, Score.Fifteen, Scores.win_fifteen)]
        [TestCase(Score.Fourty, Score.Thirty, Scores.win_thirty)]
        [TestCase(Score.Advantage, Score.Fourty, Scores.win_fourty)]
        public void ServerIsAWinnerTest(int serverScore, int receiverScore, string expected)
        {
            //Arrange (Convert to Score)
            Score server = (Score)serverScore;
            Score receiver = (Score)receiverScore;

            //Act (Check the score and count new score for server)
            GivenTheScoreIs(server, receiver);
            WhenTheServerWinsAPoint();
            string actual = ScoreOutput;

            //Assert (if the score is counted correctly)
            Assert.That(
                actual, Is.EqualTo(expected),
                AssertionMessage(server, receiver, expected, actual)
            );
        }
    }
}