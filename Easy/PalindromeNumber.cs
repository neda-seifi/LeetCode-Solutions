public class Solution
{
    public bool IsPalindrome(int x)
    {
        // Negative numbers and numbers ending in 0 (but not 0 itself) are not palindromes
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        int reversed = 0;
        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        // If the length is even, x == reversed
        // If the length is odd, reversed has one extra digit at the end, so we compare with reversed / 10
        return x == reversed || x == reversed / 10;
    }
}
