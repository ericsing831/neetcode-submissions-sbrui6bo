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
    public bool IsValidBST(TreeNode root) {
        bool DFS(TreeNode root, int min, int max) {
            if (root == null) return true;
            // check left tree & right tree
            if (root.val <= min) return false;
            if (root.val >= max) return false; 
            return DFS(root.left, min, root.val) && DFS(root.right, root.val, max);
        }
        return DFS(root, int.MinValue, int.MaxValue);
    }
}
