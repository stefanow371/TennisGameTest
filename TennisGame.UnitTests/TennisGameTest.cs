using NUnit.Framework;
using TennisGame.GUI;
using TennisGame.Models;

namespace TennisGame.UnitTests
{
    public abstract class TennisGameTest
    {
        private ConsoleGui gui;
        private SetScore currentScore;

        [SetUp]
        public void SetUp()
        {
            gui = new ConsoleGui(new SetScoreCalculator());
            currentScore = new SetScore();
        }

        protected void GivenTheScoreIs(Score server, Score receiver)
        {
            if (server == Score.Advantage)
            {
                SetRecevierScore(receiver);
                SetServerScore(server);
                return;
            }

            SetServerScore(server);
            SetRecevierScore(receiver);
        }

        private void SetRecevierScore(Score receiver)
        {
            for (int i = 0; i < ScoreCount(receiver); i++)
            {
                WhenTheReceiverWinsAPoint();
            }
        }

        private void SetServerScore(Score server)
        {
            for (int i = 0; i < ScoreCount(server); i++)
            {
                WhenTheServerWinsAPoint();
            }
        }

        protected void WhenTheServerWinsAPoint()
        {
            currentScore = gui.SetScore(1, currentScore);
        }

        protected void WhenTheReceiverWinsAPoint()
        {
            currentScore = gui.SetScore(2, currentScore);
        }

        protected string ScoreOutput => currentScore.ToString();

        protected enum Score
        {
            Zero,
            Fifteen,
            Thirty,
            Fourty,
            Advantage
        }

        private int ScoreCount(Score server)
        {
            switch (server)
            {
                case Score.Zero:
                    return 0;
                case Score.Fifteen:
                    return 1;
                case Score.Thirty:
                    return 2;
                case Score.Fourty:
                    return 3;
                case Score.Advantage:
                    return 4;
                default:
                    return 0;
            }
        }
    }
}