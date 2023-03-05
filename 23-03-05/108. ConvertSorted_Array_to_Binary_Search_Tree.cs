/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    /*
    * @title: Return a tree converted from a given array
    * @precondition: Input must be an array of integer and all elements are ascending order
    * @postcondition: A tree should be returned
    * @description:
    *             Initialize nodeList(List of TreeNode)
    *             Call a recursive function with the given array, start index,0, and end index, n-1(length or array -1)
    *               Check start index is greater than end index. If start > end, return null.
    *               If not, get the middle element of array and created node.
    *               Call the recursive function with the array, start index, and mid - 1 for end index.
    *               Call the recursive function with the array, mid + 1 for start index, and end index.
    *               Return the node.
    * @param:
    *         nums: int[]
    * @return:
    *         TreeNode
    * @time complexity:
    *         O(n): since traversing all elements in the array.
    * @space complexity:
    *         O(n): since keep traversing and create same number of nodes as a length of the array.
    */   
    List<TreeNode> nodeList = new List<TreeNode>();
    public TreeNode SortedArrayToBST(int[] nums) {
        return ConvertToTree(nums, 0, nums.Length-1);
    }

    public TreeNode ConvertToTree(int[] nums, int start, int end)
    {
        if(start > end)
        {
            return null;
        }
        int mid = (end + start)/2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = ConvertToTree(nums, start, mid-1);
        node.right = ConvertToTree(nums, mid+1, end);
        return node;
    }
}