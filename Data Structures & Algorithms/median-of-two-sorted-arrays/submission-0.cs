public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int half = (nums1.Length + nums2.Length) / 2;
        int right;
        
        int left = 0;

        int[] A, B;
        int Aright, Aleft;
        int Bleft, Bright;
        
        if (nums1.Length <= nums2.Length) {
            A = nums1;
            B = nums2;
            right = nums1.Length;
        }
        else {
            A = nums2;
            B = nums1;
            right = nums2.Length;
        }

        while (left <= right) {
            int mid = (left + right) / 2;

            int x = mid, y = half - x;
            if (x == 0) Aleft = int.MinValue;
            else Aleft = A[x - 1];
            if (x == A.Length) Aright = int.MaxValue;
            else Aright = A[x];
            if (y == 0) Bleft = int.MinValue;
            else Bleft = B[y - 1];
            if (y == B.Length) Bright = int.MaxValue;
            else Bright = B[y];

            int value = isPartitionValid();
            if (value == 1) {
                left = mid + 1;
            }
            else if (value == -1) {
                right = mid - 1;
            }
            else {
                if ((A.Length + B.Length)%2 > 0) {
                    return (double)Math.Min(Bright, Aright);
                }
                else {
                    return (double)(Math.Max(Bleft, Aleft) + Math.Min(Bright, Aright)) / 2; 
                }
            } 
        }
        return 0;

        int isPartitionValid() {

            if (Bleft > Aright) {
                return 1;
            }
            else if (Aleft > Bright) {
                return -1;
            }
            else {
                return 0;
            }
        }
    }
}
