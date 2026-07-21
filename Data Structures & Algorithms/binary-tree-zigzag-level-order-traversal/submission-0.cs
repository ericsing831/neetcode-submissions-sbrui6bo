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
        int lv = 0;
        while (queue.Count != 0) {
            int len = queue.Count;
            var list = new List<int>();
            for (int i = 0; i < len; i++) {
                var curr = queue.Dequeue();
                list.Add(curr.val);
                if (curr.left != null) 
                    queue.Enqueue(curr.left);
                if (curr.right != null)
                    queue.Enqueue(curr.right);
            }
            // even level right to left
            if ((lv % 2) == 0)
                lists.Add(list);
            // odd level left to right
            else {
                list.Reverse();
                lists.Add(list);
            }
            lv++;
        }
        return lists;
    }
}