/*
    Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
*/
public class Solution {
    public int MaxSubArray(int[] nums) {  
        int[] currSum = new int[nums.Length - 1];
        int[] seenSum = new int[nums.Length - 1];
        
        if (nums.Length == 1) {
            return nums[0];
        }
        
        currSum[0] = 
        for (int i = 1; i < nums.Length - 1; i++) {
            
        }
        
        int sum = int32.MinValue;
        for (int j = 0; j < seenSum.Length - 1; j++) {
            if (seenSum[j] > sum) {
                sum = seenSum[j];
            }
        } 
        
        return sum;
    }
}