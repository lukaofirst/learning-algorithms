void main() {
  var numbers = [10, 80, 30, 90, 40, 50, 70];

  quicksort(numbers, 0, numbers.length - 1);

  numbers.forEach((number) {
    print(number);
  });
}

void quicksort(List<int> arr, int low, int high) {
  if (low < high) {
    var partIdx = partition(arr, low, high);

    quicksort(arr, low, partIdx - 1);
    quicksort(arr, partIdx + 1, high);
  }
}

int partition(List<int> arr, int low, int high) {
  var pivot = arr[high];

  var i = low - 1;

  for (var j = low; j <= high - 1; j++) {
    if (arr[j] < pivot) {
      i++;
      swap(arr, i, j);
    }
  }

  swap(arr, i + 1, high);

  return i + 1;
}

void swap(List<int> arr, int i, int j) {
  var aux = arr[i];
  arr[i] = arr[j];
  arr[j] = aux;
}
