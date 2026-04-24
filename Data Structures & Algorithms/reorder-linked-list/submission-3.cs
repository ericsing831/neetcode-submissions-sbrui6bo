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
    public void ReorderList(ListNode head) {
        // find the first half and the second half of list 
        ListNode fast;
        if (head != null) fast = head.next;
        else return;
        ListNode slow = head;

        while (fast != null && fast.next != null) {
            fast = fast.next.next;
            slow = slow.next;
        } 

        ListNode list1 = head;
        ListNode list2 = slow.next;
        // split the list 
        slow.next = null;

        // reversed linked list list2
        ListNode prev = null;
        ListNode curr = list2;
        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        list2 = prev;

        // merge 2 lists
        while (list1 != null && list2 != null) {
            ListNode temp1 = list1.next;
            ListNode temp2 = list2.next;
            list1.next = list2;
            list2.next = temp1;
            list1 = temp1;
            list2 = temp2;
        }
        if (list1 != null) {
            list2 = list1;
        } 
    }
}
