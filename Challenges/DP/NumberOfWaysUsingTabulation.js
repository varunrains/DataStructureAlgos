const countConstruct = (target, wordBank) => {
  const table = Array(target.length + 1).fill(0);
  table[0] = 1;

  for (let i = 0; i <= target.length; i++) {
    for (let word of wordBank) {
      if (table[i] !== 0) {
        if (target.slice(i, i + word.length) === word) {
          table[i + word.length] += table[i];
        }
      }
    }
  }

  return table[target.length];
};

console.log(countConstruct("purple", ["purp", "p", "ur", "le", "purpl"]));

/*

Please go throught this DP video from Youtube
https://www.youtube.com/watch?v=oBt53YbR9Kk&t=12934s&ab_channel=freeCodeCamp.org

Very important to know recursive approach to solve and then the tabulation approach to solve these problems

*/
