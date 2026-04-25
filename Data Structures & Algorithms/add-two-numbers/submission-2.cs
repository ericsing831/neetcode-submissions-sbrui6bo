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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = new ListNode(0);
        var l3head = l3;
        int carry = 0;
        while (l1 != null || l2 != null) {
            int l2val = l2 == null ? 0 : l2.val;
            int l1val = l1 == null ? 0 : l1.val;
            l3.val += (l1val + l2val);
            carry = l3.val / 10;
            l3.val %= 10;
            if (l2 != null) l2 = l2.next;
            if (l1 != null) l1 = l1.next;
            if ((l1 != null || l2 != null) || carry != 0) {
                l3.next = new ListNode(0);
                l3 = l3.next;
            }
            l3.val += carry;
        }
        return l3head;
    }
}
