using NUnit.Framework;

namespace TennisGame.UnitTests.The_Score_Should_Increment_Once_A_Player_Scores
{
    [TestFixture]
    public class Given_The_Score_Is_0_0 : TennisGameTest
    {
        [SetUp]
        public void SetUp()
        {
            GivenTheScoreIs(Score.Zero, Score.Zero);
        }
         
        [Test]
        public void When_The_Server_Wins_A_Point()
        {
            WhenTheServerWinsAPoint();

            Assert.That(ScoreOutput, Is.EqualTo("15:0"));
        }

        [Test]
        public void When_The_Receiver_Wins_A_Point()
        {
            WhenTheReceiverWinsAPoint();

            Assert.That(ScoreOutput, Is.EqualTo("0:15"));
        }
    }
}
