// LeetCode 112 - Path Sum
// Algorithm: Recursive DFS
// Time Complexity: O(n) | Space Complexity: O(h)
// We check if there exists a root-to-leaf path such that the sum of the node values equals targetSum.

public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        // Base case: if tree is empty
        if (root == null) return false;

        // If it's a leaf node and its value equals targetSum
        if (root.left == null && root.right == null && root.val == targetSum)
            return true;

        // Subtract current node's value and recurse left and right
        int remaining = targetSum - root.val;
        return HasPathSum(root.left, remaining) || HasPathSum(root.right, remaining);
    }
}
