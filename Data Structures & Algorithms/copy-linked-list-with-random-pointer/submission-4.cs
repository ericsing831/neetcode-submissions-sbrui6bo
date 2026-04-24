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
            dict[curr].random = curr.random == null ? null : dict[curr.random];
            dict[curr].next = curr.next == null ? null : dict[curr.next];
            curr = curr.next;
        }
        return dict[head];
    }
}
