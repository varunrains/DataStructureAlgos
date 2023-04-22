var countOccurence = function (a, ele, i = 0, occurence = 0) {
  if (i === a.length) {
    return occurence;
  }

  if (a[i] === ele) {
    occurence++;
  }

  return countOccurence(a, ele, i + 1, occurence);
};

countOccurence([1, 2, 2, 2, 3, 4, 5, 5], 2);

//Dont use for or while loop

/*
Input 
countOccurence([1, 2, 2, 2, 3, 4, 5, 5], 2);

Output: 3 (Number of 2's in a given array)
*/