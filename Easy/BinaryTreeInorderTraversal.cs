using System.Collections.Generic;

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

    public class BinaryTreeInorderTraversal
    {
        /// <summary>
        /// Recursive Inorder Traversal
        /// Time: O(n), Space: O(n) due to recursion stack
        /// </summary>
        public IList<int> InorderTraversalRecursive(TreeNode root)
        {
            List<int> result = new List<int>();
            Inorder(root, result);
            return result;
        }

        private void Inorder(TreeNode node, List<int> result)
        {
            if (node == null) return;
            Inorder(node.left, result);      // Visit left subtree
            result.Add(node.val);           // Visit root
            Inorder(node.right, result);     // Visit right subtree
        }

        /// <summary>
        /// Iterative Inorder Traversal using Stack
        /// Time: O(n), Space: O(n)
        /// </summary>
        public IList<int> InorderTraversalIterative(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = root;

            while (current != null || stack.Count > 0)
            {
                // Reach the leftmost node of the current node
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }

                // Current must be null at this point
                current = stack.Pop();
                result.Add(current.val);     // Visit root

                // Visit the right subtree
                current = current.right;
            }

            return result;
        }
    }
}
