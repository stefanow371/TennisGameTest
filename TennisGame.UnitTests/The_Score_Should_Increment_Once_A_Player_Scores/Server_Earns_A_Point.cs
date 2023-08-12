using NUnit.Framework;
using TennisGame.UnitTests.Resources;

namespace TennisGame.UnitTests.The_Score_Should_Increment_Once_A_Player_Scores
{
    [TestFixture]
    public class Server_Earns_A_Point : Helper
    {
        //TestCase(serverScore, receiverScore, expected)

        [Test]
        [TestCase(Score.Zero, Score.Zero, Scores.fifteen_zero)]
        [TestCase(Score.Fifteen, Score.Zero, Scores.thirty_zero)]
        [TestCase(Score.Thirty, Score.Zero, Scores.fourty_zero)]
        [TestCase(Score.Zero, Score.Fifteen, Scores.fifteen_fifteen)]
        [TestCase(Score.Fifteen, Score.Fifteen, Scores.thirty_fifteen)]
        [TestCase(Score.Thirty, Score.Fifteen, Scores.fourty_fifteen)]
        [TestCase(Score.Zero, Score.Thirty, Scores.fifteen_thirty)]
        [TestCase(Score.Fifteen, Score.Thirty, Scores.thirty_thirty)]
        [TestCase(Score.Thirty, Score.Thirty, Scores.fourty_thirty)]
        [TestCase(Score.Zero, Score.Fourty, Scores.fifteen_fourty)]
        [TestCase(Score.Fifteen, Score.Fourty, Scores.thirty_fourty)]
        [TestCase(Score.Thirty, Score.Fourty, Scores.fourty_fourty)]
        public void ServerEarnsAPointTest(int serverScore, int receiverScore, string expected)
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