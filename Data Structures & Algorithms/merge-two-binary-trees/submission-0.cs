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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        TreeNode root3 = dfs(root1, root2);
        return root3;
        TreeNode dfs(TreeNode root1, TreeNode root2) {
            if (root1 == null && root2 == null) return null;
            var v1 = root1 != null ? root1.val : 0;
            var v2 = root2 != null ? root2.val : 0;
            var tempNode = new TreeNode(v1 + v2);

            tempNode.left = dfs(root1 != null ? root1.left : null, root2 != null ? root2.left : null);
            tempNode.right = dfs(root1 != null ? root1.right : null, root2 != null ? root2.right : null);
            return tempNode;
        }
    }
}