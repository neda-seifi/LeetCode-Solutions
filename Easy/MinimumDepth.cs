// 111. Minimum Depth of Binary Tree
// We use DFS (recursive) to find the shortest path from root to any leaf node.

public class Solution {
    public int MinDepth(TreeNode root) {
        if (root == null) return 0;

        if (root.left == null && root.right == null)
            return 1;

        if (root.left == null)
            return MinDepth(root.right) + 1;

        if (root.right == null)
            return MinDepth(root.left) + 1;

        return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
    }
}
