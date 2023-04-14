
var titleToNumber = function(columnTitle) {
    let count= 0;
    let multiplier = 1;
    for(let i =columnTitle.length-1;i>=0;i--){
       let val = getCharNumber(columnTitle[i]) * multiplier;
       count += val;
       multiplier *= 26;
    }
    return count;
};

var getCharNumber = function(char){
return char.charCodeAt() - 64;
};

titleToNumber("AAA");



/*
Source: https://leetcode.com/problems/excel-sheet-column-number/
Input: columnTitle = "AB"
Output: 28

Input: columnTitle = "ZY"
Output: 701

*/