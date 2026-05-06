/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        var queue = new Queue<(TreeNode n1, TreeNode n2)>();
        queue.Enqueue((p, q));
        while (queue.Count > 0) {
            var (curr1, curr2) = queue.Dequeue();
            if (curr1 == null && curr2 == null) continue; 
            if (curr1 == null) return false; 
            if (curr2 == null) return false;

            if (curr1.val != curr2.val) return false;

            queue.Enqueue((curr1.left, curr2.left));
            queue.Enqueue((curr1.right, curr2.right));
        }
        return true;
    }
}
