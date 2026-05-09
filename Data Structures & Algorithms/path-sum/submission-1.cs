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
    public bool HasPath;
    public bool HasPathSum(TreeNode root, int targetSum) {
        HasPath = false;
        dfs(root, targetSum);
        return HasPath;
        void dfs(TreeNode root, int targetSum) {
            if (root == null) return;
            targetSum -= root.val;
            if (root.right == null && root.left == null) {
                if (targetSum == 0) HasPath = true;
                return;
            }
            
            dfs(root.left, targetSum);
            dfs(root.right, targetSum);
        }
    }
}