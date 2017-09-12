using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMoq.Helpers;
using GameOfLife;
using NUnit.Framework;
using Should;

namespace GameOfLife.Tests
{
    public class LifeCalculatorTests
    {
        [TestFixture]
        public class ShouldBeAlive
        {
            private LifeCalculator lifeCalculator;

            [SetUp]
            public void Setup()
            {
                lifeCalculator = new LifeCalculator();
            }

            //Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
            [Test]
            public void A_live_cell_with_no_live_neighbors_dies()
            {
                var cell = new Cell
                {
                    IsAlive = true,
                    Neighbors = new Cell[] {}
                };

                lifeCalculator.ShouldBeAlive(cell).ShouldBeFalse();
            }
            
        }
    }
}
