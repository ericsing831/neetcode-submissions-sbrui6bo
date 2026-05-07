/*
// Definition for a Node.
public class Node {
    public int val;
    public List<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public List<int> Postorder(Node root) {
        void order(Node root, List<int> list) {
            if (root == null) return;
            if (root.children != null) {
                foreach (Node node in root.children) {
                    order(node, list);
                }
            }
            list.Add(root.val);
        }
        var list = new List<int>();
        order(root, list);
        return list; 
    }
}