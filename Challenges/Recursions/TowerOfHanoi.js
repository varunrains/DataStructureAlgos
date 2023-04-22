var toh = function (n) {
  if (n === 0 || n === 1) {
    return 1;
  }

  return toh(n - 1) + 1 + toh(n - 1);
};

//To print the steps in the tower of hanoi

var printSteps = function (n, source, destination, helper) {
  if (n === 0) {
    return;
  }

  printSteps(n - 1, "A", "B", "C");
  console.log(
    "Moving disk from source:",
    source,
    " to Destination: ",
    destination
  );
  printSteps(n - 1, "B", "C", "A");
};
