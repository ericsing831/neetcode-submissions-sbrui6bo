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
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode res = null;
        if (lists == null || lists.Length == 0) return res;
        for (int i = 0; i < lists.Length; i++) {
            res = MergeList(res, lists[i]);
        }
        return res;
    }
    public ListNode MergeList(ListNode node1, ListNode node2) {
        ListNode dummy = new ListNode(int.MinValue);
        var curr = dummy;
        while (node1 != null && node2 != null) {
            if (node1.val > node2.val) {
                curr.next = node2;
                node2 = node2.next;
            }
            else {
                curr.next = node1;
                node1 = node1.next;
            }
            curr = curr.next;
        }
        curr.next = node1 == null ? node2 : node1;
        return dummy.next;
    }
}
