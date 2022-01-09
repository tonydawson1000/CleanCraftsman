using System.Collections.Generic;
using CleanCraftsman;
using FluentAssertions;
using Xunit;

namespace CleanCraftsmanTests
{
    public class BubbleSortTest
    {
        [Fact]
        public void SortTest()
        {
            //Arrange
            var bubbleSort = new BubbleSort();

            bubbleSort.Sort(new List<int>()).Should().BeEmpty();

            bubbleSort.Sort(new List<int>() { 1 }).Should().Equal(new[] { 1 });

            bubbleSort.Sort(new List<int>() { 1, 2 }).Should().Equal(new[] { 1, 2 });

            //First 2 elements swapped
            bubbleSort.Sort(new List<int>() { 2, 1 }).Should().Equal(new[] { 1, 2 });

            bubbleSort.Sort(new List<int>() { 1, 2, 3 }).Should().Equal(new[] { 1, 2, 3 });

            //First 2 elements swapped
            bubbleSort.Sort(new List<int>() { 2, 1, 3 }).Should().Equal(new[] { 1, 2, 3 });

            //Last 2 elements swapped
            bubbleSort.Sort(new List<int>() { 1, 3, 2 }).Should().Equal(new[] { 1, 2, 3 });

            //Reverse Order
            bubbleSort.Sort(new List<int>() { 3, 2, 1 }).Should().Equal(new[] { 1, 2, 3 });

            bubbleSort.Sort(new List<int>() { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9, 3 })
                .Should()
                .Equal(new[] { 1, 1, 2, 3, 3, 3, 4, 5, 5, 5, 6, 7, 8, 9, 9, 9 });
        }
    }
}