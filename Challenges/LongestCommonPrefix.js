var longestCommonPrefix = function(strs) {
    let result ='';
     if(strs === null || strs.length === 0) return result;
    let min = strs[0].length;
  let minIndex=0;

for(let i = 1 ;i<strs.length;i++){
  if(min > strs[i].length){
    min= strs[i].length;
    minIndex = i;
  }
}
  
  
let minString = strs[minIndex];
   for(let i = 0;i<minString.length;i++){
       for(let j=0;j<strs.length;j++){
           if(minString[i] === strs[j][i]){
               if(j === strs.length-1){
                result += minString[i];
               }
           }else{
               return result;
           }
       }
   }
  return result;
};

/*
https://leetcode.com/problems/longest-common-prefix/description/
Input: strs = ["flower","flow","flight"]
Output: "fl"

*/