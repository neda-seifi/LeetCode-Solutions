public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> row = new List<int>();
        row.Add(1); // The first row is always [1]

        for (int i = 1; i <= rowIndex; i++) {
            row.Add(0); // Add a dummy value to increase size
            for (int j = i; j > 0; j--) {
                row[j] = row[j] + row[j - 1];
            }
        }

        return row;
    }
} // Example usage: new Solution().GetRow(3) -> [1, 3, 3, 1]
