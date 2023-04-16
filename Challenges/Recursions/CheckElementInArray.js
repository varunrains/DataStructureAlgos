var checkElement = function (a, num, n = a.length - 1) {
  if (n === 0) {
    return false;
  }

  if (a[n] === num) {
    return true;
  }

  return checkElement(a.slice(0, n), num, n - 1);
};

//One more approach without using the slice
//This could save some space and the space complexity would be better
/*
The below approach is almost same as for loop keep in mind
var checkElement = function(a,num,n = a.length,i=0){
    if (n === i) {
        return false;
      }
    
      if (a[i] === num) {
        return true;
      }

      return checkElement(a, num, n,i+1);
}

*/

checkElement([1, 2, 3], 3);
