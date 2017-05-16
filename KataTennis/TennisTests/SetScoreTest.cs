using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisScore;

namespace TennisTests
{
    [TestClass]
    public class SetScoreTest
    {
        [TestMethod]
        public void ShouldStartAtZero()
        {
            var score = new SetScore();
            Assert.AreEqual(0, score.JokoGamesWon);
            Assert.AreEqual(0, score.RafaGamesWon);
            Assert.AreEqual("0-0", score.Score);
        }

        [TestMethod]
        public void JokoShouldWinSet()
        {
            var score = new SetScore();
            score.RafaGamesWon = 4;
            score.JokoGamesWon = 5;
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            Assert.AreEqual("set joko", score.Score);
        }

        [TestMethod]
        public void JokoShouldNotWinSet()
        {
            var score = new SetScore();
            score.RafaGamesWon = 5;
            score.JokoGamesWon = 5;
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            string actual = score.Score;
            Assert.AreEqual("5-6", actual);
        }

        [TestMethod]
        public void RafaShouldWinSetAtSeven()
        {
            var score = new SetScore();
            score.RafaGamesWon = 6;
            score.JokoGamesWon = 5;
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            Assert.AreEqual("set rafa", score.Score);
        }

        [TestMethod]
        public void ShouldTieBreakAtSixGamesAll()
        {
            var score = new SetScore();
            score.RafaGamesWon = 6;
            score.JokoGamesWon = 6;
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            Assert.AreNotEqual("set rafa", score.Score);
        }

        [TestMethod]
        public void ShouldWinTieBreakAtSix()
        {
            var score = new SetScore();
            score.RafaGamesWon = 6;
            score.JokoGamesWon = 6;
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            score.RafaWinPoint();
            Assert.AreNotEqual("set rafa", score.Score);
            score.RafaWinPoint();
            Assert.AreEqual("set rafa", score.Score);
        }

        [TestMethod]
        public void ShouldWinTieBreakWithTwoPointsDifference()
        {
            var score = new SetScore();
            score.RafaGamesWon = 6;
            score.JokoGamesWon = 6;
            score.RafaWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.JokoWinPoint();
            score.RafaWinPoint();
            score.JokoWinPoint();
            score.JokoWinPoint();
            Assert.AreEqual("set joko", score.Score);
        }
    }
}
