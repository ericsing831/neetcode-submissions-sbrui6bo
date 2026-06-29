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
    public List<List<int>> LevelOrder(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var list = new List<List<int>>();
        if (root == null) return list; 
        queue.Enqueue(root);
        while (queue.Count() != 0) {
            var sublist = new List<int>();
            int count = queue.Count();
            for (int i = 0; i < count; i++) {
                var curr = queue.Dequeue();
                sublist.Add(curr.val);            
                if (curr.left != null) queue.Enqueue(curr.left);
                if (curr.right != null) queue.Enqueue(curr.right);
            }
            list.Add(sublist);
        }

        return list;
    }
}
