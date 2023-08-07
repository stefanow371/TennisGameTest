using NUnit.Framework;

namespace TennisGame.UnitTests.The_Score_Should_Increment_Once_A_Player_Scores
{
    [TestFixture]
    public class Given_The_Score_Is_30_30 : TennisGameTest
    {
        [SetUp]
        public void SetUp()
        {
            GivenTheScoreIs(Score.Thirty, Score.Thirty);
        }

        [Test]
        public void When_The_Server_Wins_A_Point()
        {
            WhenTheServerWinsAPoint();

            Assert.That(ScoreOutput, Is.EqualTo("40:30"));
        }

        [Test]
        public void When_The_Receiver_Wins_A_Point()
        {
            WhenTheReceiverWinsAPoint();

            Assert.That(ScoreOutput, Is.EqualTo("30:40"));
        }
    }
}