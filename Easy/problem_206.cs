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
    public ListNode ReverseList(ListNode head) {
        ListNode iter;
        ListNode prev;
        
        if (head is null) {
            return head;
        }
        
        iter = head.next;
        prev = head.next;
        head.next = null;
        
        while (iter != null) {
            iter = iter.next;
            prev.next = head;
            head = prev;
            prev = iter;
        }
        
        return head;
    }
}