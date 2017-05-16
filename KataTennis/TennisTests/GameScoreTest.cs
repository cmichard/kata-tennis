using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisScore;

namespace TennisTests
{
    [TestClass]
    public class GameScoreTest
    {
        [TestMethod]
        public void RafaShouldWin()
        {
            var score = new GameScore();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            Assert.AreEqual("30", score.JokoGameScore.Points);
            Assert.AreEqual("game", score.RafaGameScore.Points);
            Assert.AreEqual("game rafa", score.Score);
        }

        [TestMethod]
        public void ShouldDeuce()
        {
            var score = new GameScore();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            Assert.AreEqual("40", score.JokoGameScore.Points);
            Assert.AreEqual("40", score.RafaGameScore.Points);
            Assert.AreEqual("deuce", score.Score);
        }

        [TestMethod]
        public void DeuceShouldAdvantage()
        {
            var score = new GameScore();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            Assert.AreEqual("advantage rafa", score.RafaGameScore.Points);
        }

        [TestMethod]
        public void AdvantageShouldWinGame()
        {
            var score = new GameScore();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            Assert.AreEqual("game rafa", score.RafaGameScore.Points);
        }

        [TestMethod]
        public void AdvantageShouldBackToDeuce()
        {
            var score = new GameScore();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.JokoWinPoint();
            Assert.AreEqual("deuce", score.RafaGameScore.Points);
        }
    }
}
