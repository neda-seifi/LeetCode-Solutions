// File: Easy/LengthOfLastWord.cs

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int length = 0;
        int i = s.Length - 1;

        // Skip trailing spaces
        while (i >= 0 && s[i] == ' ')
        {
            i--;
        }

        // Count the characters of the last word
        while (i >= 0 && s[i] != ' ')
        {
            length++;
            i--;
        }

        return length;
    }
}
