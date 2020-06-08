using System.Linq;

namespace Auriga.Pebbles
{
    public class Solution
    {
        public int MaxScore(int[] squares)
        {
            // Idea behind solution is what we actually have deal with DAG - Directed Acyclic Graph
            // but for this particular problem linear representation of DAG already topographically sorted
            // and all we need is to find maximum path from beginning to each vertex.
            // Then path for last vertex is the answer
            // Time Complexity is O(N)
            // Space Complexity is O(N)

            var distances = Enumerable.Repeat(int.MinValue, squares.Length).ToArray();
            distances[0] = squares[0];

            for (int i = 0; i < squares.Length - 1; i++)
            {
                var lastInnerIndex = i + Constants.MaxDiceNumber < squares.Length - 1
                    ? i + Constants.MaxDiceNumber
                    : squares.Length - 1;
                for (int ii = i + 1; ii <= lastInnerIndex; ii++)
                {
                    if (distances[ii] < distances[i] + squares[ii])
                    {
                        distances[ii] = distances[i] + squares[ii];
                    }
                }
            }
            return distances[distances.Length - 1];
        }
    }
}
