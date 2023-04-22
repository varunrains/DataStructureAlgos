var palindrome = function (str, start = 0, end = str.length - 1) {
  if (start > end) {
    return true;
  }

  if (str[start] !== str[end]) {
    return false;
  }

  return palindrome(str, start + 1, end - 1);
};

palindrome("aba");
