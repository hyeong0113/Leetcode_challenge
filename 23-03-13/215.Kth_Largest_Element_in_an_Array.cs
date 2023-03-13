public class Solution {
    /*
    * @title: Return a kth largest element in a given integer array.
    * @precondition: Array of int, nums, and integer k should be given.
    * @postcondition: Return the kth largest element in the given array.
    * @description:
    *             Declare a queue which is priorityQueue which element has an intege key and an integer element.
    *             Declare a i for indexing inside the array.
    *             Run while until i is smaller than the length of the array.
    *               Enqueue the element which key and element are current number.
    *               Compare the current size of the queue and k.
    *               If the size is bigger than k, dequeue the first element in the queue.
    *             Increase i by 1.
    *             Return the head of the queue.
    * @param:
    *         nums: int[]
    *         k   : int
    * @return:
    *         int
    * @time complexity:
    *         O(n): since running a while loop with a length of nums, n.
    * @space complexity:
    *         O(n): since the queue may store all elements in the nums.
    */   
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        int i = 0;
        while(i < nums.Length)
        {
            queue.Enqueue(nums[i], nums[i]);
            if(queue.Count > k)
            {
                queue.Dequeue();
            }
            i++;
        }
        return queue.Peek();    
    }
}