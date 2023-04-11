var lengthOfLastWord = function(s) {
    s = s.trim();
    let arr = s.split(' ');
    return arr[arr.length-1].length;
};

lengthOfLastWord("   fly me   to   the moon  ");

/*
SOURCE: https://leetcode.com/problems/length-of-last-word/description/
Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
*/