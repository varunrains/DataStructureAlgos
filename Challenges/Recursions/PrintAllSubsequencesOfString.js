var printSubsequence = function (input, output = "") {
  if (input.length === 0) {
    console.log(output);
    return;
  }

  printSubsequence(input.substring(1), output + input[0]);
  printSubsequence(input.substring(1), output);
};

printSubsequence("abc");


/*
Input: abc
Output:
""
a
b
c
ab
ac
bc
abc

*/