var convertFromStringToInteger = function(str, length = str.length){
//let integerValue=0;
    if(length === 0){
        return 0;
    }

  let smallAns = convertFromStringToInteger(str.slice(0,str.length-1), str.length -1);

  //calculation
  let integerValue = smallAns * 10 + str[str.length-1];
  return integerValue;

}