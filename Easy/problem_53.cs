/*
    Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
*/

public class Solution {
    public int MaxSubArray(int[] nums) {  
        int currSum;
        int maxSum;
        
        currSum = maxSum = nums[0];
        
        if (nums.Length == 1) {
            return nums[0];
        }
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > currSum + nums[i]) {
                currSum = nums[i];
            } else {
                currSum = currSum + nums[i];
            }

            if (currSum > maxSum) {
                maxSum = currSum;
            }
        }
        
        return maxSum;
    }
}