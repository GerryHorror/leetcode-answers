using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Save number and index
        var map = new Dictionary<int, int>();

        // Check each number
        for (int i = 0; i < nums.Length; i++) {
            // Number needed to reach target
            int needed = target - nums[i];

            // If needed number was seen before, return both indices
            if (map.ContainsKey(needed)) {
                return new int[] { map[needed], i };
            }

            // Save current number and its index
            map[nums[i]] = i;
        }

        // Fallback return
        return new int[0];
    }
}
