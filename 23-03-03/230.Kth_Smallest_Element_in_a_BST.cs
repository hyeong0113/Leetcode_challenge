public class Solution {
    /*
    * @title: Return a kth smallest element from the given tree.
    * @precondition: Tree and index k should be given.
    * @postcondition: Intger which is kth smallest number in the tree.
    * @description:
    *             Declare elements(integer array) to store values from tree.
    *             Call a recursive function with the given root.
    *               Check current root is null or not. If null, return.
    *               If not,
    *                 Call the recursive function with the left of the root.
    *                 Store a value of the current root to elements.
    *                 Call the recursive function with the right of the root.
    *             Return kth elemen from elements.
    * @param:
    *         n: int
    * @return:
    *         int
    * @time complexity:
    *         O(n): since building a traversal over the tree.
    * @space complexity:
    *         O(n): since keep an inorder traversal.
    */  
    List<int> elements = new List<int>();
    public int KthSmallest(TreeNode root, int k) {
        KthSmallestHelper(root);
        return elements[k-1];
    }

    public void KthSmallestHelper(TreeNode root) {
        if (root == null)
        {
            return;
        }
        KthSmallestHelper(root.left);
        elements.Add(root.val);
        KthSmallestHelper(root.right);
    }
}