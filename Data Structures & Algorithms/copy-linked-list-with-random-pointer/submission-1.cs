/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) {
            return null;
        }
        
        var dict = new Dictionary<Node, Node>();
        var curr = head;
        while (curr != null) {
            dict[curr] = new Node(curr.val);
            curr = curr.next;
        }
        curr = head;
        while (curr != null) {
            if (curr.random == null) {
                dict[curr].random = null;
            }
            else {
                dict[curr].random = dict[curr.random];
            }
            if (curr.next == null) {
                dict[curr].next = null;
            }
            else {
                dict[curr].next = dict[curr.next];
            }
            curr = curr.next;
        }
        return dict[head];
    }
}
