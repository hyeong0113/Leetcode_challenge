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
    * @title: List of the level order traversal of nodes' values in a tree.
    * @precondition: A root of tree should be given.
    * @postcondition: Return the list of the level order traversal of nodes' values in a tree.
    * @description:
    *             Declare a Dictionary set which key is a level of a node and value is list of nodes in the same level.
    *             Declare a level(int) with 0.
    *             Call the recursive function with the root of tree and the level.
    *             Check a base case whether the current node is null or not. If null, return.
    *               Check the current level is stored in the set. If not, insert an element with the current level and a list of nodes' value.
    *                 If exists, insert a node's value into the list at the current level.
    *               Call the recursive function with the left of root and the level+1.
    *               Call the recursive function with the right of root and the level+1.
    *             Return values of the set.
    * @param:
    *         root: TreeNode
    * @return:
    *         IList<IList<int>>
    * @time complexity:
    *         O(n): since traversing all nodes in a tree.
    * @space complexity:
    *         O(k): since the set stores k(height of the tree) elements.
    */    
    Dictionary<int, IList<int>> set = new Dictionary<int, IList<int>>();
    public IList<IList<int>> LevelOrder(TreeNode root) {
        int level = 0;
        LevelOrderRecursive(root, level);
        return (IList<IList<int>>)set.Values.ToList();
    }

    public void LevelOrderRecursive(TreeNode root, int level)
    {
        if(root == null)
        {
            return;
        }
        if(!set.ContainsKey(level))
        {
            IList<int> temp = new List<int>();
            temp.Add(root.val);
            set.Add(level, temp);
        }
        else
        {
            set[level].Add(root.val);
        }
        LevelOrderRecursive(root.left, level+1);
        LevelOrderRecursive(root.right, level+1);
    }
}