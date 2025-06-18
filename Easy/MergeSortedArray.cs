// 88. Merge Sorted Array
// Approach: Start merging from the end of both arrays to avoid overwriting values in nums1.
// Time Complexity: O(m + n)
// Space Complexity: O(1)

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = m - 1;            // Pointer to last element in nums1's valid part
        int p2 = n - 1;            // Pointer to last element in nums2
        int p = m + n - 1;         // Pointer to last index in nums1

        // Compare from the end and place the larger one at the end of nums1
        while (p1 >= 0 && p2 >= 0) {
            if (nums1[p1] > nums2[p2]) {
                nums1[p--] = nums1[p1--];
            } else {
                nums1[p--] = nums2[p2--];
            }
        }

        // If any elements are left in nums2, copy them
        while (p2 >= 0) {
            nums1[p--] = nums2[p2--];
        }
    }
}
