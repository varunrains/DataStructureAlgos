var permutate = function(str, index = 0){
if(!str[index]){
    console.log(str);
    return;
}

for(let j =index;j<str.length;j++){
swap(str,index,j);
permutate(str.slice(1), index++);
swap(str, index,j);
}
}

var swap = function(str, srcIndex, destIndex){
    let temp = str[srcIndex];
    str[srcIndex] = str[destIndex];
    str[destIndex] = temp;
}

//Look into the above solution which is not correct