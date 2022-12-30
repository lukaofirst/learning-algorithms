void main() {
  var numbers = [31, 10, 29, 42, 51, 19, 83, 7];

  sort(numbers, 0, numbers.length - 1);

  numbers.forEach((number) {
    print(number);
  });
}

void sort(List<int> arr, int left, int right) {
  if (left < right) {
    var mid = left + (right - left) ~/ 2;

    sort(arr, left, mid);
    sort(arr, mid + 1, right);

    merge(arr, left, mid, right);
  }
}

void merge(List<int> arr, int left, int middle, int right) {
  var leftArrLength = middle - left + 1;
  var rightArrLength = right - middle;

  var leftTempArr = <int>[];
  var rightTempArr = <int>[];
  int i, j;

  for (i = 0; i < leftArrLength; i++) leftTempArr.add(arr[left + i]);

  for (j = 0; j < rightArrLength; j++) rightTempArr.add(arr[middle + 1 + j]);

  i = 0;
  j = 0;

  int k = left;

  while (i < leftArrLength && j < rightArrLength) {
    if (leftTempArr[i] <= rightTempArr[j]) {
      arr[k++] = leftTempArr[i++];
    } else {
      arr[k++] = rightTempArr[j++];
    }
  }

  while (i < leftArrLength) {
    arr[k++] = leftTempArr[i++];
  }

  while (j < rightArrLength) {
    arr[k++] = rightTempArr[j++];
  }
}
