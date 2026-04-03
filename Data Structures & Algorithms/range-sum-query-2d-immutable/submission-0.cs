public class NumMatrix {
    private int[][] _NumMatrix;
    private int[][] _prefixMatrix;
    public NumMatrix(int[][] matrix) {
        _NumMatrix = matrix;
        _prefixMatrix = new int[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            _prefixMatrix[i] = PrefixSum(matrix[i]);
        } 
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int totalSum = 0;
        for (int i = row1; i < row2+1; i++)
        {
            totalSum += SumRange(_prefixMatrix[i], col1, col2);
        }
        return totalSum;
    }

    public int[] PrefixSum(int[] arr)
    {
        var prefixArr = new int[arr.Length];
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            prefixArr[i] = sum;
        }
        return prefixArr;
    }

    public int SumRange(int[] arr,int L, int R)
    {
        int Lsum = L > 0 ? arr[L - 1] : 0;
        int Rsum = arr[R];
        return Rsum - Lsum;
    }
}
/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */