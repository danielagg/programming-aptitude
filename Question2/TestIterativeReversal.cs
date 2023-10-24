using FluentAssertions;
using Xunit;

namespace MM_Guide_Programming_Aptitude.Question2;

public class TestIterativeReversal
{
    [Fact]
    public void GivenNullAsLinkedList_ReverseLinkedListWithIteration_ReturnsNull()
    {
        LinkedList<int>? input = default;
        
        Question2.ReverseLinkedListWithIteration(input)
            .Should()
            .BeNull();
    }
    
    [Fact]
    public void GivenLinkedListWithSingleEntry_ReverseLinkedListWithIteration_ReturnsLinkedListWithSameSingleEntry()
    {
        var input = new LinkedList<int>(new[] { 1 });
        var expectedOutput = new LinkedList<int>(new[] { 1 });
        
        Question2.ReverseLinkedListWithIteration(input)
            .Should()
            .BeEquivalentTo(expectedOutput);
    }
    
    [Fact]
    public void GivenLinkedListWithMultipleEntries_ReverseLinkedListWithIteration_ReturnsReversedLinkedList()
    {
        var input = new LinkedList<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        var expectedOutput = new LinkedList<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
        
        Question2.ReverseLinkedListWithIteration(input)
            .Should()
            .BeEquivalentTo(expectedOutput);
    }
}