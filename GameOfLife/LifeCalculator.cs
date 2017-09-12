using System.Linq;

namespace GameOfLife
{
    public class LifeCalculator
    {
        public bool ShouldBeAlive(Cell cell)
        {
            return cell.Neighbors.Count(x => x.IsAlive) == 2;
        }
    }
}