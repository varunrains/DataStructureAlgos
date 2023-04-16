
var numberOfDigits = function(n){
   
    if(n ===0) return 0;

    return numberOfDigits(Math.floor(n/10)) + 1;
}

/*
Didn't find in the leet code
This should be solved using recursion
Input = 1235
Output = 4

Input = 2
Ouput = 1

Basically we should count the number of digits in a given number
*/