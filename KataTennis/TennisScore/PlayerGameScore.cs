using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    /// <summary>
    /// score of a player for a game.
    /// </summary>
    public class PlayerGameScore
    {
        public PlayerGameScore()
        {
            this.Points = "0";
        }

        /// <summary>
        /// Player game points.
        /// </summary>
        public string Points { get; private set; }

        /// <summary>
        /// Payer wins point.
        /// </summary>
        public void Win()
        {
            if (this.Points == "0")
            {
                this.Points = "15";
            }
            else if (this.Points == "15")
            {
                this.Points = "30";
            }
            else if (this.Points == "30")
            {
                this.Points = "40";
            }
            else if (this.Points == "40")
            {
                this.Points = "game";
            }
            else
            {
                throw new InvalidOperationException(string.Format("Unexpected game points {0}", this.Points));
            }
        }
    }
}
