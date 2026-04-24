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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count = 0;
        ListNode curr = head;
        ListNode curr1 = head;
        while (curr != null) {
            curr = curr.next;
            count++;
        }
        count = count - n;
        if (count == 0) {
            return head.next;
        }
        while (count != 1) {
            curr1 = curr1.next;
            count--;
        }
        curr1.next = curr1.next.next;
        return head;
    }
}
