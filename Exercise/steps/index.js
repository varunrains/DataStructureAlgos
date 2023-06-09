// --- Directions
// Write a function that accepts a positive number N.
// The function should console log a step shape
// with N levels using the # character.  Make sure the
// step has spaces on the right hand side!
// --- Examples
//   steps(2)
//       '# '
//       '##'
//   steps(3)
//       '#  '
//       '## '
//       '###'
//   steps(4)
//       '#   '
//       '##  '
//       '### '
//       '####'

//You can solve this by recursion also
function steps(n) {
    let toPrint;
    for(let i = 1;i<=n; i ++){
      //you can just use string 
      //By string concatenation also you can reduce the space complexity of this problem
        toPrint = new Array(n);
        for(let j=1;j<=n;j++){
          if(j<=i){
            toPrint.push("#");
          }else{
            toPrint.push(" ")
          }
        }
        console.log(toPrint.join(''));
    }
}

module.exports = steps;
