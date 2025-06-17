public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;
                return digits;
            }
            digits[i] = 0; // Carry the 1
        }

        // If we are here, all digits were 9: e.g., [9,9,9] -> [1,0,0,0]
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}
