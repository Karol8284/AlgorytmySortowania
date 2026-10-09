using AlgorytmySortowania.SortingAlgorithms;

namespace Test.UnitTests;
public class BubbleSortTest
{
    [Fact]
    public void Sort_EmptyArray_ReturnsEmptyArray()
    {
        List<int> input = new();

        BubbleSort.Sort(input, out List<int> sortedList);

        Assert.Empty(sortedList);
    }

    [Fact]
    public void Sort_SingleElement_ReturnsSameElement()
    {
        // Arrange

        List<int> input = new() { 42 };

        // Act
        BubbleSort.Sort(input, out List<int> sortedList);

        // Assert
        Assert.Single(sortedList);
        Assert.Equal(42, sortedList[0]);
    }

    [Fact]
    public void Sort_UnsortedArray_ReturnsSortedArray()
    {
        // Arrange
        List<int> input = new() { 5, 3, 8, 1, 2 };

        // Act
        BubbleSort.Sort(input, out List<int> sortedList);

        // Assert
        Assert.Equal(new List<int> { 1, 2, 3, 5, 8 }, sortedList);
    }

    [Fact]
    public void Sort_AlreadySortedArray_LeavesOrderUnchanged()
    {
        // Arrange
        List<int> input = new() { 1, 2, 3, 4, 5 };

        // Act
        BubbleSort.Sort(input, out List<int> sortedList);

        // Assert
        Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, sortedList);
    }

    [Fact]
    public void Sort_ReverseSortedArray_ReturnsSortedArray()
    {
        // Arrange
        List<int> input = new() { 5, 4, 3, 2, 1 };
        // Act
        BubbleSort.Sort(input, out List<int> sortedList);
        // Assert
        Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, sortedList);
    }

    [Fact]
    public void Sort_ArrayWithDuplicates_SortsAllElements()
    {
        // Arrange
        List<int> input = new() { 3, 1, 2, 3, 1 };
        // Act
        BubbleSort.Sort(input, out List<int> sortedList);
        // Assert
        Assert.Equal(new List<int> { 1, 1, 2, 3, 3 }, sortedList);
    }

    [Fact]
    public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
    {
        // Arrange
        List<int> input = new() { -1, -3, 2, 0, -2 };
        // Act
        BubbleSort.Sort(input, out List<int> sortedList);
        // Assert
        Assert.Equal(new List<int> { -3, -2, -1, 0, 2 }, sortedList);
    }

    [Fact]
    public void Sort_ArrayWithIdenticalElements_LeavesElementsUnchanged()
    {
        // Arrange
        List<int> input = new() { 1, 1, 1, 1, 1 };
        // Act
        BubbleSort.Sort(input, out List<int> sortedList);
        // Assert
        Assert.Equal(new List<int> { 1, 1, 1, 1, 1 }, sortedList);
    }

    [Fact]
    public void InputListStayTheSameAfterSorting()
    {
        // Arrange
        List<int> input = new() { 5, 3, 8, 1, 2 };

        // Act
        BubbleSort.Sort(input, out List<int> sortedList);

        // Assert
        Assert.Equal(new List<int> { 5, 3, 8, 1, 2 }, input);
    }
}
