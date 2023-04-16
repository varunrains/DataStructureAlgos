var multiply = function(m,n){

    //base case
    if(n===0) return 0;


    //recursive case
    let smallAns = multiply(m, n-1);

    //calculation
    return smallAns + m;
}


/*
Didn't find in the leet code
This should be solved using recursion without for / while loop / with '*' operator
Input = 5 * 10 (m* n)
Output = 50

Input = 2 * 2 (m* n)
Ouput = 4

Basically we should multiply the given two numbers without multiplying but with recursion
*/