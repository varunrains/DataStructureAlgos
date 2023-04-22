var findLength = function (a) {
  if (!a || a[0] === null || a[0] === undefined) {
    return 0;
  } else {
    return 1 + findLength(a.slice(1));
  }
};

findLength("abc");
