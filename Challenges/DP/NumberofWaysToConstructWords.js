let canConstruct = (target, wB, memo = {}) => {
  if (target in memo) return memo[target];
  if (target === "") return 1;
  let count = 0;
  for (let word of wB) {
    if (target.indexOf(word) === 0) {
      let nt = target.slice(word.length);
      let nOfWays = canConstruct(nt, wB);
      count += nOfWays;
    }
  }
  memo[target] = count;
  return count;
};

console.log(canConstruct("purple", ["purp", "p", "ur", "le", "purpl"]));
