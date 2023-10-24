using FluentAssertions;
using Xunit;
using TreeNode = Programming_Aptitude.Question4.Question4.TreeNode<int>;

namespace Programming_Aptitude.Question4;

public class Test
{
    [Fact]
    public void GivenNull_GetParentNodesOfSingleLeaves_ReturnsEmptyResult()
    {
        Question4.GetParentNodesOfSingleLeaves<int>(null)
            .Should()
            .BeEmpty();
    }
}