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
    * @title: Return values in a tree by Inorder traversal
    * @precondition: Input must be a root of a tree
    * @postcondition: All values in a tree stored in result variable by Inorder traversal
    * @description:
    *             Check base case whether the given node is null or not. If null, return.
    *             Call a method itself with a left node of the root.
    *             Add a value of the current node to result.
    *             Call a method itself with a right node of the root.
    * @param:
    *         root: TreeNode
    * @return:
    *         void
    * @time complexity:
    *         O(n): since the recursive function for tree is T(n) = 2*T(n/2) + 1
    * @space complexity:
    *         O(n): for worst case e.g. skewed tree
    *         O(h): for average case with h(height of tree)
    */    
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();

        void InorderTraversalHelper(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            InorderTraversalHelper(root.left);
            result.Add(root.val);
            InorderTraversalHelper(root.right);

        }

        InorderTraversalHelper(root);
        return result;
    }

}