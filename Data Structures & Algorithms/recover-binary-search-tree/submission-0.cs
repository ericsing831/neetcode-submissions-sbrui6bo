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
    public void RecoverTree(TreeNode root) {
        TreeNode prev = null;
        TreeNode first = null;
        TreeNode second = null;
        void dfs(TreeNode curr) {
            if (curr == null)
                return;

            dfs(curr.left);
            if (prev != null && curr.val < prev.val) {
                if (first == null) {
                    first = prev;
                }
                second = curr;
            }
            prev = curr;
            dfs(curr.right);
            return;
        }
        dfs(root);
        int temp = first.val;
        first.val = second.val;
        second.val = temp;
    }
}