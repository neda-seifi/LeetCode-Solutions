// Easy/BinaryTreePreorderTraversal.cs

using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Solution {
    // Recursive preorder traversal
    public IList<int> PreorderTraversalRecursive(TreeNode root) {
        List<int> result = new List<int>();
        Preorder(root, result);
        return result;
    }

    private void Preorder(TreeNode node, List<int> result) {
        if (node == null) return;
        result.Add(node.val);
        Preorder(node.left, result);
        Preorder(node.right, result);
    }

    // Iterative preorder traversal
    public IList<int> PreorderTraversalIterative(TreeNode root) {
        List<int> result = new List<int>();
        if (root == null) return result;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0) {
            TreeNode current = stack.Pop();
            result.Add(current.val);

            // Push right first so left is processed first
            if (current.right != null) stack.Push(current.right);
            if (current.left != null) stack.Push(current.left);
        }

        return result;
    }
}
