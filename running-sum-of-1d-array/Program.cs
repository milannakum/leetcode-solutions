﻿// Link: https://leetcode.com/problems/running-sum-of-1d-array/
// Name: 1480. Running Sum of 1d Array
int[] RunningSum(int[] nums)
{
    for (int i = 1; i < nums.Length; i++) nums[i] += nums[i - 1];
    return nums;
}
