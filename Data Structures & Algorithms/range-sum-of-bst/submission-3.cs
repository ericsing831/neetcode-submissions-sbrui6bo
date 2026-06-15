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
    public int RangeSumBST(TreeNode root, int low, int high) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int sum = 0;

        if (root != null) queue.Enqueue(root);

        while (queue.Count > 0) {
            TreeNode curr = queue.Dequeue();
            if (curr.val >= low && curr.val <= high) sum += curr.val;
            
            if (curr.val > low && curr.left != null) queue.Enqueue(curr.left);
            if (curr.val < high && curr.right != null) queue.Enqueue(curr.right);
        }
        return sum;
    }
}