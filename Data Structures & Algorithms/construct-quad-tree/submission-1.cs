/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    public Node Construct(int[][] grid) {
        Node DFS(int n,int row, int col) {
            bool isSame = true;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (grid[row][col] != grid[row + i][col + j]) {
                        isSame = false; 
                        break;
                    }
                }
            }
            if (isSame) {
                return new Node((grid[row][col] == 1) , true); 
            }

            n = n / 2;
            Node topLeft = DFS(n, row, col);  
            Node topRight = DFS(n, row, col + n);
            Node bottomLeft = DFS(n, row + n, col);
            Node bottomRight = DFS(n, row + n, col + n);
            return new Node(false, false, topLeft, topRight, bottomLeft, bottomRight);
        }
        return DFS(grid.Length, 0, 0);
    }
}