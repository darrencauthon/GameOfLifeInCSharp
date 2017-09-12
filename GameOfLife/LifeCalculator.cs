using System.Linq;

namespace GameOfLife
{
    public class LifeCalculator
    {
        public bool ShouldBeAlive(Cell cell)
        {
            var liveNeighbors = cell.Neighbors.Count(x => x.IsAlive);
            return liveNeighbors >= 2 && liveNeighbors != 4;
        }
    }
}