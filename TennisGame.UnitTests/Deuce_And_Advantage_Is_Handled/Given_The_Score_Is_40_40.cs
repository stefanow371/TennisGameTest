using NUnit.Framework;
using TennisGame.UnitTests.Resources;

namespace TennisGame.UnitTests.Deuce_And_Advantage_Is_Handled
{
    [TestFixture]
    public class Given_The_Score_Is_40_40 : Helper
    {
        //TestCase(serverScore, receiverScore, expected)
        [Test]
        [TestCase(Score.Fourty, Score.Fourty, Scores.advantage_fourty)]
        public void ServerWinsAPoint_40_40(int serverScore, int receiverScore, string expected)
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

        [Test]
        [TestCase(Score.Fourty, Score.Fourty, Scores.fourty_advantage)]
        public void ReceiverWinsAPoint_40_40(int serverScore, int receiverScore, string expected)
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