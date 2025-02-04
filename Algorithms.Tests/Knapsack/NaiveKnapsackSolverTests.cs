﻿using System.Linq;
using Algorithms.Knapsack;
using NUnit.Framework;

namespace Algorithms.Tests.Knapsack
{
    public class NaiveKnapsackSolverTests
    {
        [Test]
        public void TakesHalf([Random(0, 1000, 100)]int length)
        {
            //Arrange
            var solver = new NaiveKnapsackSolver<int>();
            var items = Enumerable.Repeat(42, 2 * length).ToArray();
            var expectedResult = Enumerable.Repeat(42, length);

            //Act
            var result = solver.Solve(items, length, x => 1, x => 1);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
