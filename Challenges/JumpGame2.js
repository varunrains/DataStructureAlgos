var jump = function(nums) {
    
    let farthest = 0;
    let current = 0;
    let jump = 0;

    for(let i=0;i<nums.length-1;i++){
      farthest = Math.max(farthest, nums[i] + i);

      if(i===current){
        current = farthest;
        jump++;
      }
    }

    return jump;
};


/*
Source: https://leetcode.com/problems/jump-game-ii/

Solved using the help of youtube: https://youtu.be/wLPdkLM_BWo

Input: nums = [2,3,1,1,4]
Output: 2
Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.

Input: nums = [2,3,0,1,4]
Output: 2
*/