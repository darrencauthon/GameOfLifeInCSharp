using NUnit.Framework;
using Should;

namespace GameOfLife.Tests
{
    public class LifeCalculatorTests
    {
        [TestFixture]
        public class ShouldBeAlive
        {
            [SetUp]
            public void Setup()
            {
                lifeCalculator = new LifeCalculator();
            }

            private LifeCalculator lifeCalculator;

            //Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
            [Test]
            public void A_live_cell_with_no_live_neighbors_dies()
            {
                var cell = new Cell
                {
                    IsAlive = true,
                    Neighbors = new Cell[] { }
                };

                lifeCalculator.ShouldBeAlive(cell).ShouldBeFalse();
            }

            [Test]
            public void A_live_cell_with_one_dead_neighbor_dies()
            {
                var cell = new Cell
                {
                    IsAlive = true,
                    Neighbors = new[] {new Cell {IsAlive = false}}
                };

                lifeCalculator.ShouldBeAlive(cell).ShouldBeFalse();
            }

            [Test]
            public void A_live_cell_with_two_dead_neighbors_dies()
            {
                var cell = new Cell
                {
                    IsAlive = true,
                    Neighbors = new[] {new Cell {IsAlive = false}, new Cell {IsAlive = false}}
                };

                lifeCalculator.ShouldBeAlive(cell).ShouldBeFalse();
            }

            //Any live cell with two or three live neighbours lives on to the next generation.
            [Test]
            public void A_live_cell_with_two_neighbors_lives_on()
            {
                var cell = new Cell
                {
                    IsAlive = true,
                    Neighbors = new[] {new Cell {IsAlive = true}, new Cell {IsAlive = true}}
                };

                lifeCalculator.ShouldBeAlive(cell).ShouldBeTrue();
            }
        }
    }
}