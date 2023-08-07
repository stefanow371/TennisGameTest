using NUnit.Framework;

namespace TennisGame.UnitTests.The_Score_Should_Increment_Once_A_Player_Scores
{
    [TestFixture]
    public class Given_The_Score_Is_15_15 : TennisGameTest
    {
        [SetUp]
        public void SetUp()
        {
            GivenTheScoreIs(server:Score.Fifteen, receiver:Score.Fifteen);
        }

        [TestCase]
        public void When_The_Server_Wins_A_Point()
        {
            WhenTheServerWinsAPoint();

            Assert.That(ScoreOutput, Is.EqualTo("30:15"));
        }

        [Test]
        public void When_The_Receiver_Wins_A_Point()
        {
            WhenTheReceiverWinsAPoint();

            Assert.That(ScoreOutput, Is.EqualTo("15:30"));
        }
    }
}