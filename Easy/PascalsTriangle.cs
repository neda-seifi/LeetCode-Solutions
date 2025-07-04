public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var triangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++) {
            var row = new List<int>();

            for (int j = 0; j <= i; j++) {
                // First and last elements of the row are always 1
                if (j == 0 || j == i) {
                    row.Add(1);
                } else {
                    // Each number is the sum of the two numbers above it
                    int val = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    row.Add(val);
                }
            }

            triangle.Add(row);
        }

        return triangle;
    }
}
