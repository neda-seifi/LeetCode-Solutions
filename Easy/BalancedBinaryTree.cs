public class Solution {
    public bool IsBalanced(TreeNode root) {
        return CheckHeight(root) != -1;
    }

    // Returns the height of the subtree if it's balanced, otherwise -1
    private int CheckHeight(TreeNode node) {
        if (node == null) return 0;

        int left = CheckHeight(node.left);
        if (left == -1) return -1; // left subtree not balanced

        int right = CheckHeight(node.right);
        if (right == -1) return -1; // right subtree not balanced

        if (Math.Abs(left - right) > 1) return -1; // current node not balanced

        return 1 + Math.Max(left, right); // return height if balanced
    }
}
