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
    public int res;
    public int MaxPathSum(TreeNode root) {
        int DFS(TreeNode root) {
            if (root == null) return 0;
            int leftMax = DFS(root.left);
            int rightMax = DFS(root.right);
            leftMax = Math.Max(leftMax, 0);
            rightMax = Math.Max(rightMax, 0);
            // carry the sum by not splitting left and right
            res = Math.Max(res, root.val + leftMax + rightMax);
            // return sum by splitting left and right
            return root.val + Math.Max(leftMax, rightMax);
        }
        res = root.val;
        DFS(root);
        return res;
    }
}
