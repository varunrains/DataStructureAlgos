// --- Directions
// Write a program that console logs the numbers
// from 1 to n. But for multiples of three print
// “fizz” instead of the number and for the multiples
// of five print “buzz”. For numbers which are multiples
// of both three and five print “fizzbuzz”.
// --- Example
//   fizzBuzz(5);
//   1
//   2
//   fizz
//   4
//   buzz

function fizzBuzz(n) {
    for(let i = 1;i<=n;i++){
        let toPrint ='';
        if(i % 5 === 0 && i % 3 === 0){
            toPrint = "fizzbuzz";
            log(toPrint);
            
        }
        else if(i % 3 === 0){
            toPrint = "fizz";
            log(toPrint);
            
        }
        else if(i % 5 === 0){
            toPrint = "buzz";
            log(toPrint);
            
        }
        
        else{
            toPrint = i;
            log(toPrint);
        }
        
        //console.log(toPrint);
    }
}

function log(msg){
    console.log(msg);
}

module.exports = fizzBuzz;
