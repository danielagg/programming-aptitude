using FluentAssertions;
using Xunit;

namespace MM_Guide_Programming_Aptitude.Question2;

public class TestRecursiveReversal
{
    [Fact]
    public void GivenNullAsLinkedList_ReverseLinkedListWithRecursion_ReturnsNull()
    {
        LinkedList<int>? input = default;
        
        Question2.ReverseLinkedListWithRecursion(input)
            .Should()
            .BeNull();
    }
}