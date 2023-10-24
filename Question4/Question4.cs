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
      
        GetParentNodesOfSingleLeavesRecursively(root, result);
      
        Console.WriteLine($"Parent nodes of single leaves: {string.Join(", ", result.Select(node => node.Value))}");

        return result;
    }
    
    private static void GetParentNodesOfSingleLeavesRecursively<T>(TreeNode<T>? node, ICollection<TreeNode<T>> result)
    {
        switch (node)
        {
            case null:
                return;
         
            case { Left: not null, Right: null } or { Left: null, Right: not null }:
            {
                // on 'node', either left or right exist, never both
                var child = node.Left ?? node.Right;

                // check if single 'child' is a leaf --> then parent (node) is a match
                if (child?.Left is null && child?.Right is null)
                    result.Add(node);

                break;
            }
        }

        GetParentNodesOfSingleLeavesRecursively(node.Left, result);
        GetParentNodesOfSingleLeavesRecursively(node.Right, result);
    }
}