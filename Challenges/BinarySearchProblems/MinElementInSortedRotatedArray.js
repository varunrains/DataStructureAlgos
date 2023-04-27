/**
 * @param {number[]} nums
 * @return {number}
 */
var findMin = function(nums) {
    let start = 0;
    let len = nums.length;
    let end = len-1;

    while(start<= end){
        let mid = Math.floor((start + end)/2);

        let next = (mid + 1)% len;
        let prev = (mid - 1+ len) %len;

        if(nums[mid] <= nums[next] && nums[mid]<= nums[prev]){
            //If you return the index then it will
            //tell you the number of times the array is rotated (One more way of the same question)
            return nums[mid];
            //Please go through this logic one more time
            //I have not understood this (Only for rotated array makes sense.!)
        }else if(nums[mid] <= nums[end]){
            end = mid - 1;
        }else if(nums[mid] >= nums[start]){
            start = mid + 1;
        }

    }
    return -1;
};



/*
Source:  https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/

Input: nums = [3,4,5,1,2]
Output: 1
Explanation: The original array was [1,2,3,4,5] rotated 3 times.

Input: nums = [4,5,6,7,0,1,2]
Output: 0
Explanation: The original array was [0,1,2,4,5,6,7] and it was rotated 4 times.

*/