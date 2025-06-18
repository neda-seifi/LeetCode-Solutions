using System;

namespace Easy
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class SameTree
    {
        /// <summary>
        /// Recursively compares two binary trees.
        /// Trees are the same if:
        /// - Both are null, or
        /// - Both are not null, have the same value, and their left/right subtrees are also the same.
        /// Time: O(n), Space: O(n) in worst case due to recursion stack.
        /// </summary>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;         // Both null: same
            if (p == null || q == null) return false;        // One null: different
            if (p.val != q.val) return false;                // Different value: not same

            // Recursively check left and right subtrees
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
