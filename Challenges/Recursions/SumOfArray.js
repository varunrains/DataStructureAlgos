
/*
var sumOfArray = function (a, n) {
  if (n == 1) {
    return a[0];
  }

  if (n == 0) {
    return 0;
  }

  //Recursion

  return sumOfArray(a.slice(1), n - 1) + a[0];
  // return smallAns;

  //calculation
};

*/

//Sum of array using a simple approach without slice

var sumOfArray = function(a, n, i=0){
    if(i === n){
        return 0;
    }

    return a[i] + sumOfArray(a, n, i+1);
}

sumOfArray([1, 2, 3, 4], 4);

/*

INput: [1,2,3,4] len = 4
Output: 10
Dont use for/while loop


*/
