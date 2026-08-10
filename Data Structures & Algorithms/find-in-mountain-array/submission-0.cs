/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int globalLeft = 0;
        int globalRight = mountainArr.Length() - 1;
        int res = -1;
        int left = globalLeft;
        int right = globalRight;

        while (left < right) {
            int mid = (left + right) / 2;
            int cur = mountainArr.Get(mid);
            int next = mountainArr.Get(mid + 1);
            if (cur > next) {
                right = mid;
            }
            else if (cur < next) {
                left = mid + 1;
            }
        }
        int peakIndex = right;

        left = 0;
        right = peakIndex;

        while (left < right) {
            int mid = (left + right) / 2;
            int cur = mountainArr.Get(mid);
            if (cur < target) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        if (mountainArr.Get(right) == target) 
            return right;

        left = peakIndex + 1;
        right = globalRight;
        while (left < right) {
            int mid = (left + right) / 2;
            int cur = mountainArr.Get(mid);
            if (cur > target)
                left = mid + 1;
            else {
                right = mid;
            }
        }
        if (mountainArr.Get(right) == target) 
            return right;
        else return -1;
    }
}