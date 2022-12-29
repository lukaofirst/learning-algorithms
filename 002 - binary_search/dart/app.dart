void main() {
  var numbers = [1, 37, 54, 90, 209];

  var iterativeResult = binarySearch(numbers, 209);
  var recursiveResult =
      binarySearchRecursive(numbers, 0, numbers.length - 1, 37);

  print("iterative: index - $iterativeResult");
  print("recursive: index - $recursiveResult");
}

int binarySearch(List<int> arr, int searchValue) {
  var low = 0;
  var high = arr.length - 1;

  while (low <= high) {
    var mid = (low + high) ~/ 2;

    var guess = arr[mid];

    if (guess == searchValue) return mid;

    if (guess > searchValue)
      high = mid - 1;
    else
      low = mid + 1;
  }

  return -1;
}

int binarySearchRecursive(List<int> arr, int low, int high, int searchValue) {
  while (low <= high) {
    var mid = (low + high) ~/ 2;

    var guess = arr[mid];

    if (guess == searchValue) return mid;

    if (guess > searchValue)
      return binarySearchRecursive(arr, low, mid - 1, searchValue);
    else
      return binarySearchRecursive(arr, mid + 1, high, searchValue);
  }

  return -1;
}
