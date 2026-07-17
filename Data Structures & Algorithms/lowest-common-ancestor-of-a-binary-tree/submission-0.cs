/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) return null;
        var leftN = LowestCommonAncestor(root.left, p, q);
        var rightN = LowestCommonAncestor(root.right, p, q);
        if (root == p || root == q) return root;
        else if (leftN == null && rightN != null) return rightN;
        else if (leftN != null && rightN == null) return leftN;
        else if (leftN != null && rightN != null) return root;
        else return null;
    }
}