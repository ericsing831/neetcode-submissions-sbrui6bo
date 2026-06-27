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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if (root == null) return null;

        if (root.val > key) {
            root.left = DeleteNode(root.left, key);
        }
        else if (root.val < key) {
            root.right = DeleteNode(root.right, key);
        }
        else {
            if (root.right == null && root.left == null) {
                return null;
            }
            else if ((root.right != null && root.left == null) || (root.right == null && root.left != null)) {
                if (root.right == null) {
                    return root.left;
                }
                if (root.left == null) {
                    return root.right; 
                }
            }
            else {
                // replace node with smallest val in right subtree
                var minNode = MinValNode(root.right);
                root.val = minNode.val;
                root.right = DeleteNode(root.right, minNode.val);
                
            }
        }
        return root;
    }

    // find right subtree smallest root
    public TreeNode MinValNode(TreeNode curr) {
        while (curr != null && curr.left != null) {
            curr = curr.left;
        }
        return curr; 
    }
}