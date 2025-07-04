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

public class Solution {
    // Main function that starts the recursive conversion
    public TreeNode SortedArrayToBST(int[] nums) {
        return BuildBST(nums, 0, nums.Length - 1);
    }

    // Helper function using divide and conquer
    private TreeNode BuildBST(int[] nums, int left, int right) {
        // Base case: return null if no elements to process
        if (left > right) return null;

        // Always choose the middle element to maintain balance
        int mid = left + (right - left) / 2;
        TreeNode root = new TreeNode(nums[mid]);

        // Recursively build the left and right subtrees
        root.left = BuildBST(nums, left, mid - 1);
        root.right = BuildBST(nums, mid + 1, right);

        return root;
    }
}
