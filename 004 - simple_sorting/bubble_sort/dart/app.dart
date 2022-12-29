void main() {
  var numbers = [36, 12, 29, 42, 10, 83];

  bubbleSort(numbers);

  numbers.forEach((number) {
    print(number);
  });
}

void bubbleSort(List<int> arr) {
  for (var i = 0; i < arr.length - 1; i++) {
    var swapped = false;

    for (var j = 0; j < arr.length - 1; j++) {
      if (arr[j] > arr[j + 1]) {
        var aux = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = aux;

        swapped = true;
      }
    }

    if (!swapped) break;
  }
}

void bubbleSortRecursive(List<int> arr, int n) {
  if (n == 0 || n == 1) return;

  for (var i = 0; i < n - 1; i++) {
    if (arr[i] > arr[i + 1]) {
      var aux = arr[i];
      arr[i] = arr[i + 1];
      arr[i + 1] = aux;
    }
  }

  bubbleSortRecursive(arr, n - 1);
}
