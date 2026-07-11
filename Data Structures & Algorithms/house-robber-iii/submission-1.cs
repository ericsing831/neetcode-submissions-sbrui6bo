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
    public int Rob(TreeNode root) {
        int[] DFS(TreeNode root) {
            if (root == null) return new int[2] {0,0};
            var left = DFS(root.left);
            var right = DFS(root.right);

            int rob = root.val + left[0] + right[0];
            int skip = Math.Max(left[1], left[0]) + Math.Max(right[1], right[0]);

            return new int[2] {skip, rob};
        }
        var result = DFS(root);
        return result.Max();
    }
}