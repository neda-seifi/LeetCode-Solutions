# LeetCode Solutions in C#

This repository contains my solutions to LeetCode problems, categorized by difficulty.

| Problem                | Difficulty | Folder      | Solution File    |
|------------------------|------------|-------------|------------------|
| Two Sum                | Easy       | Easy        | [TwoSum.cs](Easy/TwoSum.cs) |
| Palindrome Number      | Easy       | Easy        | [PalindromeNumber.cs](Easy/PalindromeNumber.cs) |
| Roman to Integer       | Easy       | Easy        | [RomanToInteger.cs](Easy/RomanToInteger.cs)     |
| Longest Common Prefix  | Easy       | Easy        | [LongestCommonPrefix.cs](Easy/LongestCommonPrefix.cs) |
| Valid Parentheses      | Easy       | Easy        | [ValidParentheses.cs](Easy/ValidParentheses.cs) |
| Merge Two Sorted Lists | Easy       | Easy        | [MergeTwoSortedLists.cs](Easy/MergeTwoSortedLists.cs) |
| Remove Duplicates from Sorted Array | Easy | Easy | [RemoveDuplicates.cs](Easy/RemoveDuplicates.cs) |
| Find the Index of the First Occurrence in a String | Easy | Easy | [StrStr.cs](Easy/StrStr.cs) |
| Search Insert Position | Easy       | Easy        | [SearchInsert.cs](Easy/SearchInsert.cs) |
| Length of Last Word    | Easy       | Easy        | [LengthOfLastWord.cs](Easy/LengthOfLastWord.cs) |
| Plus One               | Easy       | Easy        | [PlusOne.cs](Easy/PlusOne.cs) |
| Add Binary             | Easy       | Easy        | [AddBinary.cs](Easy/AddBinary.cs) |
| Sqrt(x)                | Easy       | Easy        | [Sqrt.cs](Easy/Sqrt.cs) |
| Climbing Stairs        | Easy       | Easy        | [ClimbingStairs.cs](Easy/ClimbingStairs.cs) |
| Remove Duplicates from Sorted List  | Easy | Easy | [DeleteDuplicatesFromSortedList.cs](Easy/DeleteDuplicatesFromSortedList.cs) |
| Merge Sorted Array     | Easy       | Easy        | [MergeSortedArray.cs](Easy/MergeSortedArray.cs) |
| Binary Tree Inorder Traversal | Easy | Easy |  [InorderTraversal.cs](Easy/InorderTraversal.cs) |
| Same Tree              | Easy       | Easy        | [SameTree.cs](Easy/SameTree.cs) |
| Symmetric Tree         | Easy       | Easy        | [SymmetricTree.cs](Easy/SymmetricTree.cs) |
| Maximum Depth of Binary Tree        | Easy        | Easy   | [MaxDepthBinaryTree.cs](Easy/MaxDepthBinaryTree.cs) |
| Convert Sorted Array to Binary Search Tree       | Easy       | Easy   | [SortedArrayToBST.cs](Easy/SortedArrayToBST.cs) |
| Balanced Binary Tree         | Easy       | Easy        | [BalancedBinaryTree.cs](Easy/BalancedBinaryTree.cs) |
| Minimum Depth of Binary Tree | Easy | Easy | [MinimumDepth.cs](Easy/MinimumDepth.cs) |
| Path Sum               | Easy       | Easy        | [PathSum.cs](Easy/PathSum.cs) |
| Pascal's Triangle                 | Easy       | Easy        | [PascalsTriangle.cs](Easy/PascalsTriangle.cs) |
| Pascal's Triangle II              | Easy       | Easy        | [PascalsTriangleII.cs](Easy/PascalsTriangleII.cs) |
| Best Time to Buy and Sell Stock              | Easy       | Easy        | [PathSum.cs](Easy/PathSum.cs) |
 
---

## Explanation Notes

### 1. Two Sum
We use a dictionary to track visited numbers and their indices. For each number, we check if its complement (target - number) exists in the dictionary. If yes, we return the indices.  
**Time**: O(n), **Space**: O(n)  
[TwoSum.cs](Easy/TwoSum.cs)

### 9. Palindrome Number
We reverse the second half of the number and compare it to the first half to check if it's a palindrome. No string conversion is used.  
**Time**: O(log n), **Space**: O(1)  
[PalindromeNumber.cs](Easy/PalindromeNumber.cs)

### 13. Roman to Integer
We map Roman numerals to their integer values and iterate through the string. If a smaller value precedes a larger one, we subtract it; otherwise, we add it.  
**Time**: O(n), **Space**: O(1)  
[RomanToInteger.cs](Easy/RomanToInteger.cs)

### 14. Longest Common Prefix
We take the first string as a base and compare characters with all other strings. We stop at the first mismatch.  
**Time**: O(n * m), **Space**: O(1)  
[LongestCommonPrefix.cs](Easy/LongestCommonPrefix.cs)

### 20. Valid Parentheses
We use a stack to match opening brackets with their corresponding closing ones. If the stack is empty at the end, it's valid.  
**Time**: O(n), **Space**: O(n)  
[ValidParentheses.cs](Easy/ValidParentheses.cs)

### 21. Merge Two Sorted Lists
We use a dummy head and iterate both lists, linking nodes in order. We attach the remainder when one list ends.  
**Time**: O(n + m), **Space**: O(1)  
[MergeTwoSortedLists.cs](Easy/MergeTwoSortedLists.cs)

### 26. Remove Duplicates from Sorted Array
We use two pointers. One moves ahead to find unique elements; the other updates the position of those unique elements in-place.  
**Time**: O(n), **Space**: O(1)  
[RemoveDuplicates.cs](Easy/RemoveDuplicates.cs)

### 28. Find the Index of the First Occurrence in a String
We compare each substring of length `needle` in `haystack`. Return the first match.  
**Time**: O(n * m), **Space**: O(1)  
[StrStr.cs](Easy/StrStr.cs)

### 35. Search Insert Position
We use binary search to find the index of the target, or where it would be inserted.  
**Time**: O(log n), **Space**: O(1)  
[SearchInsert.cs](Easy/SearchInsert.cs)

### 58. Length of Last Word
We iterate from the end, skipping trailing spaces, and count the length of the last word.  
**Time**: O(n), **Space**: O(1)  
[LengthOfLastWord.cs](Easy/LengthOfLastWord.cs)

### 66. Plus One
We iterate from the end, incrementing digits. Carry over if needed. If all digits are 9, we add a new 1 at the front.  
**Time**: O(n), **Space**: O(1)  
[PlusOne.cs](Easy/PlusOne.cs)

### 67. Add Binary
We simulate binary addition from the end of both strings. Use a `StringBuilder` for performance and reverse the result.  
**Time**: O(n), **Space**: O(n)  
[AddBinary.cs](Easy/AddBinary.cs)

### 69. Sqrt(x)
We use binary search to find the integer square root. We avoid overflow by casting to long.  
**Time**: O(log x), **Space**: O(1)  
[Sqrt.cs](Easy/Sqrt.cs)

### 70. Climbing Stairs
We solve it using dynamic programming or Fibonacci approach. The number of ways to climb to step `n` equals the sum of ways to step `n-1` and `n-2`.  
**Time**: O(n), **Space**: O(1)  
[ClimbingStairs.cs](Easy/ClimbingStairs.cs)

### 83. Remove Duplicates from Sorted List
We iterate through the sorted list using one pointer. If two consecutive nodes have the same value, we skip the duplicate node by adjusting the next pointer.
Time: O(n), Space: O(1)  
[DeleteDuplicatesFromSortedList.cs](Easy/DeleteDuplicatesFromSortedList.cs)


### 88. Merge Sorted Array
We merge two sorted arrays in-place starting from the end to avoid overwriting elements in `nums1`. We use three pointers: one for the end of the valid part of `nums1`, one for the end of `nums2`, and one at the end of `nums1`'s total capacity.
Time: O(m + n), Space: O(1)  
[MergeSortedArray.cs](Easy/MergeSortedArray.cs)


### 94. Binary Tree Inorder Traversal
Return the inorder traversal of a binary tree (Left → Root → Right).

- **Recursive**: Uses function call stack.
  - Time: O(n), Space: O(n)
- **Iterative**: Uses an explicit stack to simulate recursion.
  - Time: O(n), Space: O(n)

[BinaryTreeInorderTraversal.cs](Easy/BinaryTreeInorderTraversal.cs)


### 100. Same Tree
Checks whether two binary trees are structurally identical and have the same node values.

We use recursion:
- If both nodes are null, return true.
- If only one is null or values don't match, return false.
- Recursively compare left and right subtrees.

- Time: O(n), Space: O(n)
[SameTree.cs](Easy/SameTree.cs)



### 101. Symmetric Tree
Checks if a binary tree is a mirror of itself.

**Recursive Approach:**
- Recursively compare left and right subtrees in mirrored positions.

**Iterative Approach:**
- Use a queue to compare nodes in pairs from outer to inner levels.

Time: O(n), Space: O(n)  
[SymmetricTree.cs](Easy/SymmetricTree.cs)

### 104. Maximum Depth of Binary Tree
We solve this in two ways:

- **Recursive:** Use DFS (Depth First Search) to explore left and right children. The maximum depth is `1 + max(left, right)`.
- **Iterative:** Use BFS (Breadth First Search) with a queue to count levels.

**Time Complexity:** O(n)  
**Space Complexity:** O(h) for recursion, O(n) for BFS  
[MaxDepthBinaryTree.cs](Easy/MaxDepthBinaryTree.cs)

### 108. Convert Sorted Array to Binary Search Tree
We use a recursive divide-and-conquer approach. At each step, we take the middle element of the current subarray as the root node and recursively construct left and right subtrees from the remaining halves. This ensures the tree is height-balanced.
- Time: O(n), Space: O(log n)
[SortedArrayToBST.cs](Easy/SortedArrayToBST.cs)

### 110. Balanced Binary Tree
We use DFS recursion to get the height of each subtree. If the height difference exceeds 1, we return -1 and bubble up the failure.
Time: O(n), Space: O(n)
[BalancedBinaryTree.cs](Easy/BalancedBinaryTree.cs)

### 111. Minimum Depth of Binary Tree
We use DFS recursion to find the shortest path from root to any leaf node. If one subtree is null, we take the depth of the other.
Time: O(n), Space: O(n)
[MinimumDepth.cs](Easy/MinimumDepth.cs)

### 112. Path Sum  
We use recursion to check whether a root-to-leaf path exists where the sum of the node values equals the target.  
At each step, we subtract the node's value from `targetSum` and recurse left and right.  
If we reach a leaf and the remaining sum is zero, we return true.  
Time: O(n), Space: O(n)  
[PathSum.cs](Easy/PathSum.cs)


### 118. Pascal's Triangle  
We build each row iteratively. Every element (except the edges) is the sum of the two elements directly above it.  
Time: O(numRows²), Space: O(numRows²)  
[PascalsTriangle.cs](Easy/PascalsTriangle.cs)


### 119. Pascal's Triangle II  
We build only one row at a time using a single list. From each previous row, we update the list in reverse to compute the next row. This saves space.  
Time: O(n²), Space: O(n)  
[PascalsTriangleII.cs](Easy/PascalsTriangleII.cs)


### 121. Best Time to Buy and Sell Stock  
We track the minimum price as we iterate and calculate profit at each step. This one-pass solution keeps updating the max profit seen so far.  
Time: O(n), Space: O(1)  
[BestTimeToBuyAndSellStock.cs](Easy/BestTimeToBuyAndSellStock.cs)
