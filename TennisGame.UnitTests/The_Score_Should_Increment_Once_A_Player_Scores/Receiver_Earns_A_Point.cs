using NUnit.Framework;
using TennisGame.UnitTests.Resources;

namespace TennisGame.UnitTests.The_Score_Should_Increment_Once_A_Player_Scores
{
    [TestFixture]
    public class Receiver_Earns_A_Point : Helper
    {
        //TestCase(serverScore, receiverScore, expected)

        [Test]
        [TestCase(Score.Zero, Score.Zero, Scores.zero_fifteen)]
        [TestCase(Score.Zero, Score.Fifteen, Scores.zero_thirty)]
        [TestCase(Score.Zero, Score.Thirty, Scores.zero_fourty)]
        [TestCase(Score.Fifteen, Score.Zero, Scores.fifteen_fifteen)]
        [TestCase(Score.Fifteen, Score.Fifteen, Scores.fifteen_thirty)]
        [TestCase(Score.Fifteen, Score.Thirty, Scores.fifteen_fourty)]
        [TestCase(Score.Thirty, Score.Zero, Scores.thirty_fifteen)]
        [TestCase(Score.Thirty, Score.Fifteen, Scores.thirty_thirty)]
        [TestCase(Score.Thirty, Score.Thirty, Scores.thirty_fourty)]
        [TestCase(Score.Fourty, Score.Zero, Scores.fourty_fifteen)]
        [TestCase(Score.Fourty, Score.Fifteen, Scores.fourty_thirty)]
        [TestCase(Score.Fourty, Score.Thirty, Scores.fourty_fourty)]
        public void ReceiverEarnsAPointTest(int serverScore, int receiverScore, string expected)
        {
            //Arrange (Convert to Score)
            Score server = (Score)serverScore;
            Score receiver = (Score)receiverScore;

            //Act (Check the score and count new score for receiver)
            GivenTheScoreIs(server, receiver);
            WhenTheReceiverWinsAPoint();
            string actual = ScoreOutput;

            //Assert (if the score is counted correctly)
            Assert.That(
                actual, Is.EqualTo(expected),
                AssertionMessage(server, receiver, expected, actual)
            );
        }
    }
}