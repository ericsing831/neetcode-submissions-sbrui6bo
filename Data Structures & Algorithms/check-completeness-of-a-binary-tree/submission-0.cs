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
    public bool IsCompleteTree(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool isNull = false;
        while (queue.Count > 0) {
            var curr = queue.Dequeue();
            if (curr.left != null) {
                if (isNull) return false;
                queue.Enqueue(curr.left);
            }
            else isNull = true;
            if (curr.right != null) {
                if (isNull) return false;
                queue.Enqueue(curr.right);
            }
            else isNull = true;
        }
        return true;
    }
}