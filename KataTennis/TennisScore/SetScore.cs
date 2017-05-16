using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    /// <summary>
    /// Match set score.
    /// </summary>
    public class SetScore
    {
        /// <summary>
        /// Set score summary.
        /// </summary>
       public string Score
        {
            get
            {
                return string.Format("{0}-{0}", this.RafaGamesWon, this.JokoGamesWon);
            }
        }

        /// <summary>
        /// Number of games won by player1 in this set.
        /// </summary>
        public int RafaGamesWon { get; set; }

        /// <summary>
        /// Number of games won by player2 in this set.
        /// </summary>
        public int JokoGamesWon { get; set; }

        public void RafaWinPoint()
        {

        }

        public void JokoWinPoint()
        {

        }
    }
}
