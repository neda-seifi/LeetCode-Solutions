public class Solution
{
    public int RomanToInt(string s)
    {
        var map = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int current = map[s[i]];
            int next = (i + 1 < s.Length) ? map[s[i + 1]] : 0;

            // If the next symbol is greater, subtract current (e.g., IV = -1 + 5)
            if (current < next)
                total -= current;
            else
                total += current;
        }

        return total;
    }
}
