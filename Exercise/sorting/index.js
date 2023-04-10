// --- Directions
// Implement bubbleSort, selectionSort, and mergeSort

function bubbleSort(arr) {
for(let i = 0;i<arr.length;i++){
    for(let j=0;j<arr.length-i;j++){
        if(arr[j+1] < arr[j]){
            let temp = arr[j];
            arr[j] = arr[j+1];
            arr[j+1] = temp;
        }
    }
}
return arr;
}

function selectionSort(arr) {
    let minIndex = 0;
    for(let i = 0;i<arr.length;i++){
        minIndex = i;
        for(let j=i+1;j<arr.length;j++){
            if(arr[j] < arr[minIndex]){
               minIndex = j;
            }
        }
        if(minIndex !== i){
        let temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
        }
    }
    return arr;
}

function mergeSort(arr) {
    if(arr.length ===1) return arr;
let midpoint = Math.floor(arr.length/2);
let left = arr.slice(0,midpoint);
let right= arr.slice(midpoint, arr.length);
return merge(mergeSort(left), mergeSort(right));
}

// function merge(left, right) {
// let i =0;
// let j = 0;
// let combined = [];

// while(i<left.length && j<right.length){
// if(left[i] < right[j]){
// combined.push(left[i]);
// i++;
// }else{
//     combined.push(right[j]);
//     j++;
// }
// }

// while(i<left.length){
//     combined.push(left[i]);
//     i++;
// }
// while(j<right.length){
//     combined.push(right[j]);
//     j++;
// }

// return combined;

// }
//short implementation of merge sort algorithm
function merge(left, right) {
let combined = [];

while(left.length && right.length){
    if(left[0] < right[0]){
        combined.push(left.shift());
    }else{
        combined.push(right.shift());
    }
}

return [...combined, ...left, ...right];

}

module.exports = { bubbleSort, selectionSort, mergeSort, merge };
