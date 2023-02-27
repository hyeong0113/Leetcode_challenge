/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    /*
    * @title: Return reversed linked list
    * @precondition: Input must be a head of the linked list
    * @postcondition: Order of linked list should be reversed
    * @description:
    *             Set prev(previous node) to null.
    *             Set current(current node) to the head of the linked list. 
    *             Set next(next node) to null.
    *             Run while loop until current is null.
    *               Set next to next node of current.
    *               Set next node of current to prev to connect to prev.
    *               Set prev to current.
    *               Set current to next.
    *             Return prev where tail of the original linked list.
    * @param:
    *         root: ListNode
    * @return:
    *         ListNode
    * @time complexity:
    *         O(n): since it iterates all nodes in the linked list.
    * @space complexity:
    *         O(1): since it creates only three nodes before loop.
    */   
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;

        while(current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}