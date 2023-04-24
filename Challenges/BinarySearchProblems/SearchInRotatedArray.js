

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function(nums, target) {
    let start = 0;
    let end = nums.length-1;

    while(start <= end){
        let mid = Math.floor((start+end)/2);

        if(nums[mid] === target){
            return mid;
        }

        if(nums[start] <= nums[mid]){
           if(target >= nums[start] && target <= nums[mid]){
               end = mid -1;
           }else{
               start = mid + 1;
           }
        }
        else {
            if(target >= nums[mid] && target <= nums[end]){
              start = mid + 1;
           }else{
               end = mid -1;
           }
        }

    }

    return -1;
};

/*
Source: https://leetcode.com/problems/search-in-rotated-sorted-array/

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4

Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1


*/