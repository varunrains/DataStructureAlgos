var geoMetricSum = function (k) {
  //base case
  if (k == 0) return 1;

  //recursion
  let smallAns = geoMetricSum(k - 1);

  //calculation
  return smallAns + 1 / Math.pow(2, k);
};

geoMetricSum(3);

/*
Didn't find in the leet code
This should be solved using recursion without for / while loop 
Input = K = 3
Output = 1 + 1/2 + 1/(2 pow 2) + 1/(2 pow 3) [As k is 3 stop here]

Input = 1
Ouput = 1 + 1/2


*/
