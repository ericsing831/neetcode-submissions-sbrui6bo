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
    public int GoodNodes(TreeNode root) {
        int DFS(TreeNode root, int max) {
            if (root == null) return 0;
            if (Math.Max(root.val, max) == root.val) {
                max = root.val;
                return 1 + DFS(root.left, max) + DFS(root.right, max);
            }
            return 0 + DFS(root.left, max) + DFS(root.right, max);
        }
        if (root == null) return 0;
        return 1 + DFS(root.left, root.val) + DFS(root.right, root.val);
    }
}
