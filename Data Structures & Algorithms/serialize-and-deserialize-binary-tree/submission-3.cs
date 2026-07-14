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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        var queue = new Queue<TreeNode>();
        var strList = new List<string>();

        queue.Enqueue(root);
        while (queue.Count != 0) {
            var curr = queue.Dequeue();

            if (curr == null) {
                strList.Add("N");
                continue;
            }

            strList.Add(curr.val.ToString());
            queue.Enqueue(curr.left);
            queue.Enqueue(curr.right);
        }

        return string.Join("|", strList);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        string[] dataArr = data.Split("|");

        var queue = new Queue<TreeNode>();
        if (dataArr[0] == "N") return null;

        TreeNode root = new TreeNode(int.Parse(dataArr[0]));
        queue.Enqueue(root);
        int traversed = 1;

        while (queue.Count != 0 && traversed < dataArr.Length) {
            var curr = queue.Dequeue();

            if (dataArr[traversed] != "N") {
                curr.left = new TreeNode(int.Parse(dataArr[traversed]));
                queue.Enqueue(curr.left);
            }
            traversed++;

            if (dataArr[traversed] != "N") {
                curr.right = new TreeNode(int.Parse(dataArr[traversed]));
                queue.Enqueue(curr.right);
            }
            traversed++;
        }
        return root;
    }
}
