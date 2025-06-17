// LeetCode 69. Sqrt(x)
// https://leetcode.com/problems/sqrtx/
// This solution uses Binary Search to find the integer part of the square root of x.
// Time Complexity: O(log x), Space Complexity: O(1)

public class Solution {
    public int MySqrt(int x) {
        // Edge case: square root of 0 and 1 is the number itself
        if (x < 2) return x;

        int left = 1, right = x / 2;
        int result = 0;

        // Binary Search between 1 and x/2
        while (left <= right) {
            int mid = left + (right - left) / 2;

            // Use long to prevent integer overflow
            long square = (long)mid * mid;

            if (square == x) {
                return mid; // Exact square root found
            } else if (square < x) {
                result = mid;   // Store the current best answer
                left = mid + 1; // Try to find a bigger value
            } else {
                right = mid - 1; // mid is too big
            }
        }

        // Return the integer part of the square root
        return result;
    }
}
