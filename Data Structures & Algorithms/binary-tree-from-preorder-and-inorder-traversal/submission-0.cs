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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0) return null;
        int pivot = preorder[0];
        int index;
        for (index = 0; index < inorder.Length; index++) {
            if (inorder[index] == pivot) break;
        }
        return new TreeNode(pivot, BuildTree(preorder[1..(index + 1)], inorder[0..index]), 
            BuildTree(preorder[(index + 1)..],inorder[(index + 1)..inorder.Length]));
    }
}
