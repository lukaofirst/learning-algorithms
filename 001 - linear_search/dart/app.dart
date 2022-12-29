void main() {
  var numbers = [1, 90, 54, 209, 37];

  var iterativeResult = sequentialSearch(numbers, 209);
  var recursiveResult = sequentialSearchRecursive(numbers, 37);

  print("iterative: index - $iterativeResult");
  print("recursive: index - $recursiveResult");
}

int sequentialSearch(List<int> arr, int searchValue) {
  for (var i = 0; i < arr.length; i++) {
    if (arr[i] == searchValue) {
      return i;
    }
  }

  return -1;
}

int sequentialSearchRecursive(List<int> arr, int searchValue) {
  var size = arr.length;

  if (size == 0)
    return -1;
  else if (arr[size - 1] == searchValue)
    return size - 1;
  else
    return sequentialSearchRecursive(arr, searchValue);
}
