var isSorted = function (a, n) {
  if (n == 0 || n == 1) {
    return true;
  }
  if (a[0] > a[1]) {
    return false;
  }

  let isSmallerSorted = isSorted(a.slice(1), n - 1);
  return isSmallerSorted;
}; 



isSorted([1, 3, 2, 4], 4);

/*
Dont use for or while loop
*/
