void main() {
  var numbers = [36, 12, 29, 42, 10, 83];

  selectionSort(numbers);

  numbers.forEach((number) {
    print(number);
  });
}

void selectionSort(List<int> arr) {
  for (var i = 0; i < arr.length; i++) {
    var smallestIndex = i;

    for (var j = i + 1; j < arr.length; j++) {
      if (arr[j] < arr[smallestIndex]) {
        smallestIndex = j;
      }
    }

    var aux = arr[smallestIndex];
    arr[smallestIndex] = arr[i];
    arr[i] = aux;
  }
}
