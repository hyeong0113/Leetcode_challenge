public class Solution {
      /*
    * @title: Return maximum depth of tree
    * @precondition: Root node of tree
    * @postcondition: Return maximum depth of tree in integer greater than 0.
    * @description:
    *             Call MaxDepth with a root(root node of tree).
    *             Check base case whether the given node is null or not.
    *                 If current node is null, return 0.
    *             Add 1 since root exists and call recursive with left of current root. Go back to the second step.
    *             Add 1 since root exists and call recursive with right of current root. Go back to the second step.
    *             Check depth of left and right, then return greater one.
    * @param:
    *         root: TreeNode
    * @return:
    *         int
    * @time complexity:
    *         O(n): since it visits all nodes in a tree.
    * @space complexity:
    *         O(h): since two variables are created h(height of tree) times.
    */
    public int MaxDepth(TreeNode root) {
        int MaxDepth(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            int left = 1 + MaxDepth(root.left);
            int right = 1 + MaxDepth(root.right);
            return left > right ? left : right;
        }

        return MaxDepth(root);
    }
}