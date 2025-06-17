// Problem: 70. Climbing Stairs
// Difficulty: Easy
// Tags: Dynamic Programming
// Explanation:
// This problem is a classic DP problem. At each step, you can climb either 1 or 2 steps.
// The total number of ways to reach step n is the sum of ways to reach step n-1 and step n-2.
// This follows the Fibonacci sequence pattern:
// dp[n] = dp[n - 1] + dp[n - 2]
// We can solve it using constant space optimization.

public class Solution {
    public int ClimbStairs(int n) {
        // Base cases
        if (n <= 2) return n;

        int oneStepBefore = 2; // Ways to reach step 2
        int twoStepsBefore = 1; // Ways to reach step 1
        int allWays = 0;

        // Calculate ways from step 3 to n
        for (int i = 3; i <= n; i++) {
            allWays = oneStepBefore + twoStepsBefore;
            twoStepsBefore = oneStepBefore;
            oneStepBefore = allWays;
        }

        return allWays;
    }
}
