using System;
using System.Collections.Generic;

namespace Easy
{
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class SymmetricTree
    {
        // Recursive Solution
        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsMirror(root.left, root.right);
        }

        private bool IsMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null || t1.val != t2.val) return false;
            return IsMirror(t1.left, t2.right) && IsMirror(t1.right, t2.left);
        }

        // Iterative Solution using Queue
        public bool IsSymmetricIterative(TreeNode root)
        {
            if (root == null) return true;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);

            while (queue.Count > 0)
            {
                TreeNode t1 = queue.Dequeue();
                TreeNode t2 = queue.Dequeue();

                if (t1 == null && t2 == null) continue;
                if (t1 == null || t2 == null || t1.val != t2.val) return false;

                queue.Enqueue(t1.left);
                queue.Enqueue(t2.right);
                queue.Enqueue(t1.right);
                queue.Enqueue(t2.left);
            }

            return true;
        }
    }
}
