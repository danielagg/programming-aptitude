namespace Programming_Aptitude.Question4;

public static class Question4
{
    public record TreeNode<T>(T Value)
    {
        public TreeNode<T>? Left { get; init; }
        public TreeNode<T>? Right { get; init; }
    }
    
    public static List<TreeNode<T>> GetParentNodesOfSingleLeaves<T>(TreeNode<T>? root)
    {
        var result = new List<TreeNode<T>>();
      
        if (root is null)
            return result;

        return new List<TreeNode<T>>();
    }
}