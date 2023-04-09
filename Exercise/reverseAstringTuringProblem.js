function reverseOnlyLetters(s) {
  let result = "";
  let finalResult = "";
  var pattern = /[a-zA-Z]/;

  for (let i = 0 ;i< s.length;i++) {
     
    if (pattern.test(s[i])) {
      result = s[i] + result;
    }
  }
    let counter = 0;
   for(let i = 0 ;i< s.length;i++){
       if(pattern.test(s[i].toLowerCase())){
           finalResult += result[counter];
           counter++;
       }
       else{
           finalResult += s[i];
       }
   }
    
  
    return finalResult;
}

reverseOnlyLetters("a-bC-dEf=ghlJ!!");