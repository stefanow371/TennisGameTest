using NUnit.Framework;

namespace TennisGame.UnitTests.A_Winner_Is_Declared
{
    [TestFixture]
    public class Given_The_Score_Is_40_A : TennisGameTest
    {
        [SetUp]
        public void SetUp()
        {
            GivenTheScoreIs(Score.Advantage, Score.Fourty);
        }

        [Test]
        public void When_The_Receiver_Wins_A_Point()
        {
            Assert.Fail("TODO");
        }
    }
}