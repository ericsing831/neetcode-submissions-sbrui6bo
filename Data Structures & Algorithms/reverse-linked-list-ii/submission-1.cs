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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if (head.next == null) return head;
        ListNode lConn = null;
        ListNode prev = null;
        ListNode curr = head;   
        int index = 1;
        // read left position
        while (left > index) {
            lConn = curr;
            curr = curr.next;
            index++;
        }

        ListNode rConn = null;
        ListNode leftNode = null;
        rConn = curr;
        while (index <= right) {
            leftNode = curr.next;
            curr.next = prev;
            prev = curr;
            curr = leftNode;
            index++;
        }
        rConn.next = curr;
        if (lConn == null) {
            return prev;
        }
        else {
            lConn.next = prev;
            return head;
        }
    }
}