var removeChar = function (str, ele, res = "") {
  if (!str || str.length === 0) {
    return res;
  }
  if (str[0] !== ele) {
    res += str[0];
  }

  return removeChar(str.slice(1), ele, res);
};



removeChar("abc", "c");
