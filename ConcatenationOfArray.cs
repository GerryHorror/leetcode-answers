public class Solution {
    public int[] GetConcatenation(int[] nums) {
        // Store original length
        int n = nums.Length;

        // Result array will contain nums twice
        int[] ans = new int[n * 2];

        // Fill both the first and second half
        for (int i = 0; i < n; i++) {
            // Copy current value into original position
            ans[i] = nums[i];

            // Copy current value into duplicated position
            ans[i + n] = nums[i];
        }

        // Return concatenated array
        return ans;
    }
}
