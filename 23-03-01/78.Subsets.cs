public class Solution {
    /*
    * @title: Return all possible subsets from a given integer array
    * @precondition: Input must be an integer array.
    * @postcondition: List of subsets of the given array.
    * @description:
    *             Declare results to store all possible subsets.
    *             Run for loop n+1(number of elements in array + 1) times. During for loop,
    *               Create current(List of integer) to store a current subset of the array.
    *               Call a recursive function.
    *                 Check size of current subset and a given size. If they are same, add current subset to results.
    *                 If not, run for loop from start index to length of the array.
    *                   Add a current element to current subset.
    *                   Call recursive function with increased start index.
    *                   Remove the last element from the current.
    *             Return all subsets.
    * @param:
    *         nums: int[]
    * @return:
    *         IList<IList<int>>
    * @time complexity:
    *         O(n*2^n): (n+1)(for loop) * 2^n(backtracking 2^n subsets by recursive)
    * @space complexity:
    *         O(n): n(input) + n(maintaining creating current).
    */   
    IList<IList<int>> results = new List<IList<int>>();

    public IList<IList<int>> Subsets(int[] nums) {
        for(int i = 0; i < nums.Length+1; i++)
        {
            List<int> current = new List<int>();
            SubsetsHelper(0, current, nums, i);
        }
        return results;
    }

    public void SubsetsHelper(int start, List<int> current, int[] nums, int size) {
        if(current.Count() == size)
        {
            results.Add(new List<int>(current));
            return;
        }

        for(int i = start; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            SubsetsHelper(i+1, current, nums, size);
            current.RemoveAt(current.Count() - 1);
        }
    }
}