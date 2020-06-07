using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auriga.Pebbles.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void InitialExample_ReturnsExpectedScore()
        {
            // Arrange
            var squares = new int[] { 1, -2, 0, 9, -1, -2 };

            // Act
            var result = new Solution().MaxScore(squares);

            // Assert
            Assert.AreEqual(8, result, "Should return max sum of 8");
        }
    }
}
