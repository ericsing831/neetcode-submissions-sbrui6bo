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
        int sum = 0;

        void InOrder(TreeNode root) {
            if (root == null) return;
            if (root.val < low) InOrder(root.right);
            if (root.val > high) InOrder(root.left); 
            if (root.val >= low && root.val <= high) {
                sum += root.val;
                InOrder(root.left);
                InOrder(root.right);
            }
        }
        InOrder(root);
        return sum;
    }
}