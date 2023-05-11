/**
 * @param {number[]} numbers
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(numbers, target) {
    let startIndex = 0;
    let endIndex = numbers.length-1;

    while(startIndex<=endIndex){
        if(numbers[startIndex] + numbers[endIndex] === target) return [startIndex+1, endIndex+1];

        else if(numbers[startIndex] + numbers[endIndex] <= target){
            startIndex++;
        }
        else if(numbers[startIndex] + numbers[endIndex] >= target){
            endIndex--;
        }
    }
 };

/*
Source: https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

Two pointer can be applied in a sorted array case or else you can apply
Binary search also for searching the second element after finding the first element randomly
the time complexity would be O(n *log n) (logn for binary search)

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].

*/