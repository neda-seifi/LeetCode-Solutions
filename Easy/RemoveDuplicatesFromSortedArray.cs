// LeetCode Problem 26: Remove Duplicates from Sorted Array
// Time Complexity: O(n), Space Complexity: O(1)
// Explanation:
// Since the array is sorted, duplicates are adjacent. 
// We use a slow pointer `i` to track the position of the last unique element, 
// and a fast pointer `j` to scan the array. 
// Whenever nums[j] != nums[i], we move `i` forward and copy nums[j] to nums[i].

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int i = 0;

        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] != nums[i])
            {
                i++;
                nums[i] = nums[j];
            }
        }

        return i + 1; // number of unique elements
    }
}
