using System.Linq;
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

        [TestMethod]
        public void AllPositiveAllMaximum_ReturnsFullMultiplication()
        {
            // Arrange 
            var squares = Enumerable.Repeat(Constants.MaximumSquareValue, Constants.MaximumBoardLength).ToArray();

            // Act
            var result = new Solution().MaxScore(squares);

            // Assert
            Assert.AreEqual(10000 * 100000, result, $"Should return {Constants.MaximumSquareValue} * {Constants.MaximumBoardLength}");
        }

        [TestMethod]
        public void AllNegativeAllMinimum_ReturnsMultiplicationOfMinimumAndQuotient()
        {
            // Arrange 
            var squares = Enumerable.Repeat(Constants.MinimumSquareValue, Constants.MaximumBoardLength).ToArray();

            // Act
            var result = new Solution().MaxScore(squares);

            // Assert
            var quotient = Constants.MaximumBoardLength / Constants.MaxDiceNumber;
            quotient++; // for first element
            if (Constants.MaximumBoardLength % Constants.MaxDiceNumber > 0)
            {
                quotient += 1;
            }
            Assert.AreEqual(Constants.MinimumSquareValue * quotient, result, $"Should return multiplication of {Constants.MinimumSquareValue} and count of slices in input array");
        }

        [TestMethod]
        public void TwoPositive_ReturnsSum()
        {
            // Arrange
            var squares = new int[] { 1, 2 };

            // Act
            var result = new Solution().MaxScore(squares);

            // Assert
            Assert.AreEqual(3, result, "Should return 3");
        }

        [TestMethod]
        public void TwoNegative_ReturnsSum()
        {
            // Arrange
            var squares = new int[] { -1, -2 };

            // Act
            var result = new Solution().MaxScore(squares);

            // Assert
            Assert.AreEqual(-3, result, "Should return -3");
        }

        [TestMethod]
        public void TreePositive_ReturnsSumOfAll()
        {
            // Arrange
            var squares = new int[] { 1, 2, 3 };

            // Act
            var result = new Solution().MaxScore(squares);

            // Assert
            Assert.AreEqual(6, result, "Should return 6");
        }

        [TestMethod]
        public void TreeNegative_ReturnsSumWithoutMiddle()
        {
            // Arrange
            var squares = new int[] { -1, -2, -3 };

            // Act
            var result = new Solution().MaxScore(squares);

            // Assert
            Assert.AreEqual(-4, result, "Should return -4");
        }

        [TestMethod]
        public void LocalNegativeNonOptimal_ReturnsMinimumSum()
        {
            // Arrange
            var squares = new int[] { 0, -2, -10, -10, -3, -10, -10, -2, -10, -10, 0 };

            // Act
            var result = new Solution().MaxScore(squares);

            // Assert
            Assert.AreEqual(-3, result, "Should return -3");
        }
    }
}
