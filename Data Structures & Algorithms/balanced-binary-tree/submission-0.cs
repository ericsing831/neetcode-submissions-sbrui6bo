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
    public bool IsBalanced(TreeNode root) {
        return dfs(root) != -1;
    }
    // look for height
    public int dfs(TreeNode root) {
        if (root == null) return 0;

        int left = dfs(root.left);
        if (left == -1) return -1;

        int right = dfs(root.right);
        if (right == -1) return -1;

        if (Math.Abs(left - right) > 1) return -1;
        return Math.Max(left, right) + 1;
    }
}
