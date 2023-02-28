public class Solution {
    /*
    * @title: Return a single, or not duplicated, number in a given array
    * @precondition: Input must be an array of integer and all other elements are duplicate in pairs except for one element
    * @postcondition: A single number should be returned
    * @description:
    *             Store the first element of the given array to single(integer variable).
    *             Run for loop from the second element to the last element of the array. During for loop,
    *               Use bitwise exclusive operator to single and current value of the array, then store to single.
    *               If two numbers are duplicate, single will store 0. If not, single store a specific number.
    *             Return single
    * @param:
    *         nums: int[]
    * @return:
    *         int
    * @time complexity:
    *         O(n): since run for loop n-1 times, it is O(n).
    * @space complexity:
    *         O(n): since the given input is integer array.
    */ 
    public int SingleNumber(int[] nums) {
        int single = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            single = single ^ nums[i];
        }
        return single;
    }
}