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
    public List<List<int>> ZigzagLevelOrder(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var lists = new List<List<int>>();
        if (root != null) 
            queue.Enqueue(root);
        bool leftToRight = true;
        while (queue.Count > 0) {
            int len = queue.Count;
            int[] arr = new int[len];
            for (int i = 0; i < len; i++) {
                var curr = queue.Dequeue();
                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
                if (leftToRight) {
                    arr[i] = curr.val;
                }
                else {
                    arr[len - i - 1] = curr.val;
                }
            }
            lists.Add(arr.ToList());
            leftToRight = !leftToRight;
        }
        return lists;
    }
}