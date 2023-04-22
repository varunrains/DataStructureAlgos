var countWays = function(numberOfWays){
if(n===0 || n===1){
    return 1;
}

if(n < 0){
    return 0;
}

return countWays(n-1) + countWays(n-2) + countWays(n-3);
}

/*
You can jump maximum of 3 steps hence n-1 to n-3
Number of ways to reach 3rd step is 4 ways

*/