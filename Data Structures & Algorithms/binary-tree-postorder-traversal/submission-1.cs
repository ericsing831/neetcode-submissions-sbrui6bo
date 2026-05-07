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
    public List<int> PostorderTraversal(TreeNode root) {
        var list = new List<int>();
        Postorder(root, list);
        return list; 

        void Postorder(TreeNode root, List<int> list) {
            if (root == null) return;
            Postorder(root.left, list);
            Postorder(root.right, list);
            list.Add(root.val);
        }    

    }
    
}