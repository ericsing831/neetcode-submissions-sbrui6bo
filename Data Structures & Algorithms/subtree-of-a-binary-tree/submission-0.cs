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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        bool dfs(TreeNode root, TreeNode subRoot) {
            if (root == null) return false;
            return subDfs(root, subRoot) || dfs(root.left, subRoot) || dfs(root.right, subRoot);
        }
        bool subDfs(TreeNode n1, TreeNode n2) {
            if (n1 == null && n2 == null) return true;

            if ((n1 != null && n2 != null) && (n1.val == n2.val)) {
                return subDfs(n1.left, n2.left) && subDfs(n1.right, n2.right);
            } 
            else return false;
        }
        return dfs(root, subRoot);
    }
}
