/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    /*
    * @title: Delete a node in a linked list
    * @precondition: One of node in a linked list, not a tail node
    * @postcondition:
    *                The given node is deleted.
    *                Order of other nodes are same.
    *                Size of the linked list decrease by 1.
    * @description:
    *             Copy value from next of the given node and paste into the given node
    *             Set next pointer of the given node to next node of its adjacent node
    * @param:
    *         node: ListNode
    * @return:
    *         void
    * @time complexity:
    *         O(1): It does not use loop or recursive method. It takes constant time
    * @space complexity:
    *         O(1): It does not use any extra variables to solve this problem.
    */ 
    public void DeleteNode(ListNode node) {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}