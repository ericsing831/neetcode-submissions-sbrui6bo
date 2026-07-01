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
    public List<int> RightSideView(TreeNode root) {
        var list = new List<int>();
        void DFS(TreeNode root, int depth) {
            if (root == null) return; 
            if (depth == list.Count) {
                list.Add(root.val);
            }
            DFS(root.right, depth + 1);
            DFS(root.left, depth + 1);
        }
        DFS(root, 0);
        return list; 
    }
}
