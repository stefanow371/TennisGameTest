using NUnit.Framework;
using TennisGame.UnitTests.Resources;

namespace TennisGame.UnitTests.A_Winner_Is_Declared
{
    [TestFixture]
    public class Receiver_Is_A_Winner : Helper
    {
        //TestCase(serverScore, receiverScore, expected)

        [Test]
        [TestCase(Score.Zero, Score.Fourty, Scores.zero_win)]
        [TestCase(Score.Fifteen, Score.Fourty, Scores.fifteen_win)]
        [TestCase(Score.Thirty, Score.Fourty, Scores.thirty_win)]
        [TestCase(Score.Fourty, Score.Advantage, Scores.fourty_win)]
        public void ReceiverIsAWinnerTest(int serverScore, int receiverScore, string expected)
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