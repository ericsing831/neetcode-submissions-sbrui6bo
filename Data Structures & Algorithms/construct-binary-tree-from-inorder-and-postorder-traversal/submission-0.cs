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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        var hashmap = new Dictionary<int, int>();
        for (int idx = 0; idx < inorder.Length; idx++) {
            hashmap[inorder[idx]] = idx;
        }
        var postStack = new Stack<int>(postorder); 
        TreeNode dfs(int l ,int r) {
            if (l > r) 
                return null;
            TreeNode root = new TreeNode(postStack.Pop());
            int idx = hashmap[root.val];
            root.right = dfs(idx + 1, r);
            root.left = dfs(l, idx - 1);
            return root;
        }
        return dfs(0, postorder.Length - 1);
    }
}