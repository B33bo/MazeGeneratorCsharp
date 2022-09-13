using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maze;

namespace MazeGenerationTesting
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void NoNullSquares()
        {
            MazeGenerator m = new(100, 100, 1);
            m.Generate();

            for (int i = 0; i < m.grid.GetLength(0); i++)
            {
                for (int j = 0; j < m.grid.GetLength(1); j++)
                {
                    if (m.grid[i, j].links is null)
                        Assert.Fail("Unvisited tile at", i, j);
                }
            }
        }

        [TestMethod]
        public void OneByOne()
        {
            MazeGenerator m = new(1, 1, 1);
            m.Generate();
        }

        [TestMethod]
        public void ZeroByZero()
        {
            MazeGenerator m = new(0, 0, 1);
            m.Generate();
        }

        [TestMethod]
        public void Negative()
        {
            MazeGenerator m = new(-16, -16, 1);
            m.Generate();
        }
    }
}
