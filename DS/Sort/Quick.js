function pivot(array, pivotIndex = 0, endIndex = array.length - 1) {
  let swapIndex = pivotIndex;
  for (let i = pivotIndex + 1; i < endIndex; i++) {
    if (array[pivotIndex] > array[i]) {
      swapIndex++;
      swap(array, i, swapIndex);
    }
  }
  swap(array, pivotIndex, swapIndex);
  return swapIndex;
}

function swap(array, sourceIndex, destIndex) {
  let temp = array[sourceIndex];
  array[sourceIndex] = array[destIndex];
  array[destIndex] = temp;
}

function quickSort(array, left = 0, right = array.length - 1) {
  if (left < right) {
    let pivotIndex = pivot(array, left, rigth);
    quickSort(array, left, pivotIndex - 1);
    quickSort(array, pivotIndex + 1, right);
  }
  return array;
}
