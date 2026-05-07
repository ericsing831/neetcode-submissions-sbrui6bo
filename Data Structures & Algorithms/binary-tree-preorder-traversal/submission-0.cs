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
    public List<int> PreorderTraversal(TreeNode root) {
        var list = new List<int>();
        Preorder(root, list);
        return list; 
    }
    public void Preorder(TreeNode root, List<int> list) {
        if (root == null) return;
        list.Add(root.val);
        Preorder(root.left, list);
        Preorder(root.right, list);
    }
}