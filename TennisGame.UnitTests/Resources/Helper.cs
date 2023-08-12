using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame.UnitTests.Resources
{
    public class Helper : TennisGameTest
    {
        //The message that will be displayed on failure
        protected static string AssertionMessage(Score serverScore, Score ReceiverScore, string expectedScore, string ScoreOutput) =>
           $"When score is: {serverScore}:{ReceiverScore} the output should be {expectedScore} but is: {ScoreOutput}";
    }
}