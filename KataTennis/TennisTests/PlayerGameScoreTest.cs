using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisScore;

namespace TennisScore
{
    [TestClass]
    public class PlayerGameScoreTest
    {
        [TestMethod]
        public void ShouldStartAtZero()
        {
            var playerPoints = new PlayerGameScore();
            Assert.AreEqual("0", playerPoints.Points);
        }

        [TestMethod]
        public void ShouldGetFifteen()
        {
            var playerPoints = new PlayerGameScore();
            playerPoints.Win();
            Assert.AreEqual("15", playerPoints.Points);
        }

        [TestMethod]
        public void ShouldGetThirty()
        {
            var playerPoints = new PlayerGameScore();
            playerPoints.Win();
            playerPoints.Win();
            Assert.AreEqual("30", playerPoints.Points);
        }

        [TestMethod]
        public void ShouldGetFourty()
        {
            var playerPoints = new PlayerGameScore();
            playerPoints.Win();
            playerPoints.Win();
            playerPoints.Win();
            Assert.AreEqual("40", playerPoints.Points);
        }

        [TestMethod]
        public void ShouldWin()
        {
            var playerPoints = new PlayerGameScore();
            playerPoints.Win();
            playerPoints.Win();
            playerPoints.Win();
            playerPoints.Win();
            Assert.AreEqual("game", playerPoints.Points);
        }
    }
}
