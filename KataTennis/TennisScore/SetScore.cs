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
        private GameScore currentGameScore;

        public SetScore()
        {
            this.currentGameScore = new GameScore();
            this.UpdateScore();
        }

        /// <summary>
        /// Set score summary.
        /// </summary>
        public string Score { get; private set; }

        /// <summary>
        /// Number of games won by player1 in this set.
        /// </summary>
        public int RafaGamesWon { get; set; }

        /// <summary>
        /// Number of games won by player2 in this set.
        /// </summary>
        public int JokoGamesWon { get; set; }

        /// <summary>
        /// Player1 win point.
        /// </summary>
        public void RafaWinPoint()
        {
            this.currentGameScore.RafaWinPoint();
            if (this.currentGameScore.RafaGameScore.Points == "game")
            {
                this.RafaGamesWon++;
                this.currentGameScore = new GameScore();
                this.UpdateScore();
            }
        }

        /// <summary>
        /// Player 2 win point.
        /// </summary>
        public void JokoWinPoint()
        {
            this.currentGameScore.JokoWinPoint();
            if (this.currentGameScore.JokoGameScore.Points == "game")
            {
                this.JokoGamesWon++;
                this.currentGameScore = new GameScore();
                this.UpdateScore();
            }
        }

        private void UpdateScore()
        {
            if (this.JokoGamesWon == 6 && this.RafaGamesWon <= 4)
            {
                this.Score = "set joko";
            }
            else if (this.RafaGamesWon == 6 && this.JokoGamesWon <= 4)
            {
                this.Score = "set rafa";
            }
            else if (this.RafaGamesWon == 7)
            {
                this.Score = "set rafa";
            }
            else if (this.JokoGamesWon == 7)
            {
                this.Score = "set joko";
            }
            else
            {
                this.Score = string.Format("{0}-{1}", this.RafaGamesWon, this.JokoGamesWon);
            }
        }
    }
}
