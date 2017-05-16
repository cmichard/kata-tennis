using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    /// <summary>
    /// Tennis game score.
    /// </summary>
    public class GameScore
    {
        public string Score { get; private set; }

        /// <summary>
        /// First player game score.
        /// </summary>
        public PlayerGameScore RafaGameScore { get; private set; }

        /// <summary>
        /// Second player game score.
        /// </summary>
        public PlayerGameScore JokoGameScore { get; private set; }

        /// <summary>
        /// Player 1 wins point.
        /// </summary>
        public void RafaWinPoint()
        {

        }

        /// <summary>
        /// Player 2 wins point.
        /// </summary>
        public void JokoWinPoint()
        {

        }
    }
}
