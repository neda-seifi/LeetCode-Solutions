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

## Explanation Notes

### 1. Two Sum
We use a dictionary to track visited numbers and their indices. For each number, we check if its complement (target - number) exists in the dictionary. If yes, we return the indices.
Time: O(n), Space: O(n)
[TwoSum.cs](Easy/TwoSum.cs)

### 9. Palindrome Number
We reverse the second half of the number and compare it to the first half to check if it's a palindrome. No string conversion is used.
Time: O(log n), Space: O(1)
[PalindromeNumber.cs](Easy/PalindromeNumber.cs)

### 13. Roman to Integer
We map Roman numerals to their integer values and iterate through the string. If a smaller value precedes a larger one, we subtract it; otherwise, we add it.
Time: O(n), Space: O(1)
[RomanToInteger.cs](Easy/RomanToInteger.cs)

### 14. Longest Common Prefix
We take the first string as a base and compare characters with all other strings. We stop at the first mismatch.
Time: O(n * m), Space: O(1)
[LongestCommonPrefix.cs](Easy/LongestCommonPrefix.cs)

### 20. Valid Parentheses
We use a stack to match opening brackets with their corresponding closing ones. If the stack is empty at the end, it's valid.
Time: O(n), Space: O(n)
[ValidParentheses.cs](Easy/ValidParentheses.cs)

### 21. Merge Two Sorted Lists
We use a dummy head and iterate both lists, linking nodes in order. We attach the remainder when one list ends.
Time: O(n + m), Space: O(1)
[MergeTwoSortedLists.cs](Easy/MergeTwoSortedLists.cs)

### 26. Remove Duplicates from Sorted Array
We use two pointers. One moves ahead to find unique elements; the other updates the position of those unique elements in-place.
Time: O(n), Space: O(1)
[RemoveDuplicates.cs](Easy/RemoveDuplicates.cs)

### 28. Find the Index of the First Occurrence in a String
We compare each substring of length needle in haystack. Return the first match.
Time: O(n * m), Space: O(1)
[StrStr.cs](Easy/StrStr.cs)

### 35. Search Insert Position
We use binary search to find the index of the target, or where it would be inserted.
Time: O(log n), Space: O(1)
[SearchInsert.cs](Easy/SearchInsert.cs)

### 58. Length of Last Word
We iterate from the end, skipping trailing spaces, and count the length of the last word.
Time: O(n), Space: O(1)
[LengthOfLastWord.cs](Easy/LengthOfLastWord.cs)

### 66. Plus One
We iterate from the end, incrementing digits. Carry over if needed. If all digits are 9, we add a new 1 at the front.
Time: O(n), Space: O(1)
[PlusOne.cs](Easy/PlusOne.cs)

### 67. Add Binary
We simulate binary addition from the end of both strings. Use a StringBuilder for performance and reverse the result.
Time: O(n), Space: O(n)
[AddBinary.cs](Easy/AddBinary.cs)

### 69. Sqrt(x)
We use binary search to find the integer square root. We avoid overflow by casting to long.
Time: O(log x), Space: O(1)
[Sqrt.cs](Easy/Sqrt.cs)
