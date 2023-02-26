public class Solution {
    /*
    * @title: Return all permutaions of an integer list
    * @precondition: Input must be an integer array
    * @postcondition: All possible permutations of the given integer array
    * @description:
    *             Run PermuteHelper with a start index 0.
    *             Check base case whether the given index is equal to length of array or not.
    *             During for loop from start to n(length of array) with index i,
    *                     Swap element at i and element at start.
    *                     Get into recursive method with start increased by 1.
    *                         When start = n, meet the base case, store current array into results.
    *                     Swap element at i and element at start to reorder back to initial array.
    *             Return results.
    * @param:
    *         nums: Integer array
    * @return:
    *         IList<IList<int>>
    * @time complexity:
    *         O(n!): since it iterates over n! with increasing start.
    * @space complexity:
    *         O(n*n!): since all possible values are stored, n!, with size of array, n.
    */

    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> results = new List<IList<int>>();
        int n = nums.Length;

        void Swap(int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
        void PermuteHelper(int start)
        {
            if(n == start)
            {
                results.Add(new List<int>(nums));
                return;
            }
            
            for(int i = start; i < n; i++)
            {
                Swap(i, start);
                PermuteHelper(start+1);
                Swap(i, start);
            }
        }

        PermuteHelper(0);
        return results;
    }
}