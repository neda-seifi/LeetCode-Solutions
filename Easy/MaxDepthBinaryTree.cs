// Recursive DFS Solution for LeetCode 104
public class Solution {
    // This function returns the maximum depth of a binary tree.
    // It uses a recursive depth-first search algorithm.
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0; // Base case: if tree is empty

        // Recursively calculate the depth of left and right subtrees
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);

        // Return 1 (for the current node) plus the greater depth
        return 1 + Math.Max(left, right);
    }
} 

/*
Time Complexity: O(n), where n is the number of nodes in the tree.
Space Complexity: O(h), where h is the height of the tree (recursion stack).
*/


// Iterative BFS Solution for LeetCode 104
using System.Collections.Generic;

public class SolutionIterative {
    // This function uses a queue to perform level-order traversal.
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int depth = 0;

        while (queue.Count > 0) {
            int levelSize = queue.Count; // Number of nodes at current level
            for (int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            depth++; // Increase depth after each level
        }

        return depth;
    }
}

/*
Time Complexity: O(n)
Space Complexity: O(n) — due to queue storage of nodes in the widest level of the tree
*/
