using Zapper.Assessment.Question1;

namespace Zapper.Assessment.Tests.Question1;

public class SearchUnitTests
{
    [Fact]
    public void SearchHappyCase()
    {
        int[] input = [1, 3, 5, 6];
        Assert.True(Search.BinarySearch(input, 3));
    }
    
    
    [Fact]
    public void SearchEmptyArray()
    {
        int[] input = [];
        Assert.False(Search.BinarySearch(input, 3));
    }
    
    
    [Fact]
    public void SearchNotFound()
    {
        int[] input = [1,2,3,4,5,6,6,7,7,9,12,30];
        Assert.False(Search.BinarySearch(input, 59));
    }
}