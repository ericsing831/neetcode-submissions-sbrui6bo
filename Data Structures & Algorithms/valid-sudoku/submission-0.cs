public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // construct hashMap
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>(); 
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>(); 
        Dictionary<(int,int), HashSet<char>> boxes = new Dictionary<(int,int), HashSet<char>>();  

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') continue;

                if (!rows.ContainsKey(r))
                    rows[r] = new HashSet<char>();

                if (!cols.ContainsKey(c))
                    cols[c] = new HashSet<char>();

                if (!boxes.ContainsKey((r / 3, c / 3)))
                    boxes[(r / 3, c / 3)] = new HashSet<char>();

                if (rows[r].Contains(board[r][c]) || 
                    cols[c].Contains(board[r][c]) ||
                    boxes[(r/3, c/3)].Contains(board[r][c])) 
                {
                    return false;
                }
                rows[r].Add(board[r][c]);
                cols[c].Add(board[r][c]);
                boxes[(r/3, c/3)].Add(board[r][c]);
            }
        }   
        return true;
    }
}
