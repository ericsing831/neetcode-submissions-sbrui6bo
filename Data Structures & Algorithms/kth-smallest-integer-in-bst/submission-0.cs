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
    public int KthSmallest(TreeNode root, int k) {
        int val = 0;
        int count = 0;
        DFS(root, k, ref count, ref val);
        return val;
    }
    public void DFS(TreeNode root, int k, ref int c, ref int val) {
        if (root == null) return;
        DFS(root.left, k, ref c, ref val);
        c++;
        if (c == k) {
            val = root.val;
            return;
        }
    
        DFS(root.right, k, ref c, ref val);
    }
}
