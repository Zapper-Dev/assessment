using Zapper.Assessment.Question2;

namespace Zapper.Assessment.Tests.Question2;

public class SortUnitTests
{
    [Fact]
    public void SortTest()
    {
        int[] input = [8,3,5,6,3,1];
        
        Sort.BubbleSort(input);
        
        Assert.Equal([1, 3, 3, 5, 6, 8], input);
    }
}