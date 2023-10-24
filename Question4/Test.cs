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
    
    [Fact]
    public void GivenSingleNode_GetParentNodesOfSingleLeaves_ReturnsEmptyResult()
    {
        Question4.GetParentNodesOfSingleLeaves(new TreeNode(50))
            .Should()
            .BeEmpty();
    }
    
    [Fact]
    public void GivenOneParentOneLeafNode_GetParentNodesOfSingleLeaves_ReturnsRootNode()
    {
        Question4.GetParentNodesOfSingleLeaves(new TreeNode(50) { Right = new TreeNode(51) })
            .Should()
            .BeEquivalentTo(new[] { new TreeNode(50) { Right = new TreeNode(51) } }.ToList());
    }
    
    [Fact]
    public void GivenOneParentTwoLeafNodes_GetParentNodesOfSingleLeaves_ReturnsEmptyResult()
    {
        var root = new TreeNode(50)
        {
            Left = new TreeNode(51),
            Right = new TreeNode(52)
        };
        
        Question4.GetParentNodesOfSingleLeaves(root)
            .Should()
            .BeEmpty();
    }
    
    [Fact]
    public void GivenExample1BinaryTree_GetParentNodesOfSingleLeaves_ReturnsParentNodesOfSingleLeaves()
    {
        var root = new TreeNode(50)
        {
            Left = new TreeNode(17)
            {
                Left = new TreeNode(9)
                {
                    Right = new TreeNode(14)
                    {
                        Left = new TreeNode(12)
                    }
                },
                Right = new TreeNode(23)
                {
                    Right = new TreeNode(19)
                }
            },
            Right = new TreeNode(76)
            {
                Left = new TreeNode(54)
                {
                    Right = new TreeNode(72)
                    {
                        Left = new TreeNode(67)
                    }
                }
            }
        };

        Question4.GetParentNodesOfSingleLeaves(root)
            .Should()
            .BeEquivalentTo(new[]
            {
                new TreeNode(14) { Left = new TreeNode(12) },
                new TreeNode(23) { Right = new TreeNode(19) },
                new TreeNode(72) { Left = new TreeNode(67) },
            }.ToList());
    }
    
    [Fact]
    public void GivenExample2BinaryTree_GetParentNodesOfSingleLeaves_ReturnsParentNodesOfSingleLeaves()
    {
        var root = new TreeNode(1)
        {
            Left = new TreeNode(2)
            {
                Left = new TreeNode(4),
                Right = new TreeNode(5)
                {
                    Left = new TreeNode(6)
                    {
                        Left = new TreeNode(8)
                    },
                    Right = new TreeNode(7)
                    {
                        Right = new TreeNode(9)
                    }
                }
            },
            Right = new TreeNode(3)
            {
                Left = new TreeNode(10)
            }
        };
        
        Question4.GetParentNodesOfSingleLeaves(root)
            .Should()
            .BeEquivalentTo(new[]
            {
                new TreeNode(6) { Left = new TreeNode(8) },
                new TreeNode(7) { Right = new TreeNode(9) },
                new TreeNode(3) { Left = new TreeNode(10) }
            });
    }
    
    [Fact]
    public void GivenExample3BinaryTree_GetParentNodesOfSingleLeaves_ReturnsParentNodesOfSingleLeaves()
    {
        var root = new TreeNode(1)
        {
            Left = new TreeNode(5),
            Right = new TreeNode(6)
            {
                Left = new TreeNode(7),
                Right = new TreeNode(8)
                {
                    Left = new TreeNode(9),
                    Right = new TreeNode(10)
                    {
                        Left = new TreeNode(11),
                        Right = new TreeNode(12)
                    }
                }
            }
        };
        
        Question4.GetParentNodesOfSingleLeaves(root)
            .Should()
            .BeEmpty();
    }
    
    [Fact]
    public void GivenExample4BinaryTree_GetParentNodesOfSingleLeaves_ReturnsParentNodesOfSingleLeaves()
    {
        var root = new TreeNode(1)
        {
            Left = new TreeNode(5),
            Right = new TreeNode(6)
            {
                Left = new TreeNode(7),
                Right = new TreeNode(8)
                {
                    Left = new TreeNode(9),
                    Right = new TreeNode(10)
                    {
                        Left = new TreeNode(11),
                        Right = new TreeNode(12)
                        {
                            Right = new TreeNode(13)
                        }
                    }
                }
            }
        };
        
        Question4.GetParentNodesOfSingleLeaves(root)
            .Should()
            .BeEquivalentTo(new[]
            {
                new TreeNode(12) { Right = new TreeNode(13) }
            }.ToList());
    }
}