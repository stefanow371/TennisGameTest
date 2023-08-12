
namespace TennisGame.UnitTests.Resources
{
    public class Scores
    {
        //All possible Scores:

        //win cases:
        public const string zero_win =  "0:W";
        public const string fifteen_win = "15:W";
        public const string thirty_win = "30:W";
        public const string fourty_win = "40:W";
        public const string win_zero = "W:0";
        public const string win_fifteen = "W:15";
        public const string win_thirty = "W:30";
        public const string win_fourty = "W:40";
        public const string fifteen_fourty = "15:40";
        public const string thirty_fourty = "30:40";
        public const string fourty_fourty = "40:40";
        public const string fourty_fifteen = "40:15";

        //advantage cases:
        public const string advantage_fourty = "A:40";
        public const string fourty_advantage = "40:A";

        //other cases:
        public const string fifteen_zero = "15:0";
        public const string zero_fifteen = "0:15";
        public const string fifteen_fifteen = "15:15";
        public const string zero_thirty = "0:30";
        public const string fifteen_thirty = "15:30";
        public const string zero_fourty = "0:40";
        public const string thirty_zero = "30:0";
        public const string thirty_fifteen = "30:15";
        public const string thirty_thirty = "30:30";
        public const string fourty_zero = "40:0";
        public const string fourty_thirty = "40:30";

    }
}