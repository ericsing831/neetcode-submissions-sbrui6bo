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
    public int DiameterOfBinaryTree(TreeNode root) {
        res = 0;
        HeightOfBinaryTree(root);
        return res;
    }
    public int HeightOfBinaryTree(TreeNode root) {
        if (root == null) return 0;
        int left = HeightOfBinaryTree(root.left);
        int right = HeightOfBinaryTree(root.right);

        res = Math.Max(res, left + right);
        return Math.Max(left, right) + 1;
    }
}
