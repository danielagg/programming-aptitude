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
}