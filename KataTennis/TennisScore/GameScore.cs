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
        /// <summary>
        /// Create a new instance of <c>GameScore</c>.
        /// </summary>
        public GameScore()
        {
            this.RafaGameScore = new PlayerGameScore();
            this.JokoGameScore = new PlayerGameScore();
        }

        /// <summary>
        /// Game current score.
        /// </summary>
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
            if (this.Score == "advantage joko")
            {
                this.Score = "deuce";
            }
            else if (this.Score == "deuce")
            {
                this.Score = "advantage rafa";
            }
            else
            {
                this.RafaGameScore.Win();
                this.CheckDeuce();
            }

            this.CheckGame();
        }

        /// <summary>
        /// Player 2 wins point.
        /// </summary>
        public void JokoWinPoint()
        {
            if (this.Score == "advantage rafa")
            {
                this.Score = "deuce";
            }
            else if (this.Score == "deuce")
            {
                this.Score = "advantage joko";
            }
            else
            {
                this.JokoGameScore.Win();
                this.CheckDeuce();
            }

            this.CheckGame();
        }

        private void CheckGame()
        {
            if (this.RafaGameScore.Points == "game")
            {
                this.Score = "game rafa";
            }
            else if (this.JokoGameScore.Points == "game")
            {
                this.Score = "game joko";
            }
        }

        private void CheckDeuce()
        {
            if (this.RafaGameScore.Points == "40" && this.JokoGameScore.Points == "40")
            {
                this.Score = "deuce";
            }
            else
            {
                this.Score = string.Format("{0}-{1}", this.RafaGameScore.Points, this.JokoGameScore.Points);
            }
        }
    }
}
