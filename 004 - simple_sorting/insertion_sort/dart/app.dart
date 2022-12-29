void main() {
  var numbers = [36, 12, 29, 42, 10, 83];

  insertionSort(numbers);

  numbers.forEach((number) {
    print(number);
  });
}

void insertionSort(List<int> arr) {
  for (var i = 1; i < arr.length; i++) {
    var aux = arr[i];

    for (var j = i - 1; j >= 0 && arr[j] > aux; j--) {
      arr[j + 1] = arr[j];
      arr[j] = aux;
    }
  }
}
