var isValid = function(s) {
    let res = [];

    for(let i =0;i<s.length;i++){
        if(s[i] === '(' || s[i] === '[' || s[i] === '{'){
            res.push(s[i]);
        }else{
            let popItem = res.pop();
            if(!popItem) return false;
            //let popPrevious = res.pop();
            if((popItem === '(' && s[i] === ')') || (popItem === '[' && s[i] === ']') || (popItem === '{' && s[i] === '}')){
                continue;
            }else{
                res.push(popItem,s[i]);
            }
        }
    }

   return !res.length;
};


/*
Source: https://leetcode.com/problems/valid-parentheses/description/
Input: s = "()[]{}"
Output: true

Input: s = "(]"
Output: false
*/