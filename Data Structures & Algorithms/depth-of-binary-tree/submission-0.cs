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
    public int maxDepth;
    public int MaxDepth(TreeNode root) {
        maxDepth = 0;
        DFS(root, 0);
        return maxDepth;
    }
    public void DFS(TreeNode root, int depth) {
        if (root == null) {
            return;
        }
        else {
            depth++;
            maxDepth = Math.Max(depth, maxDepth);
        }
        DFS(root.left, depth);
        DFS(root.right, depth);
    }
}
