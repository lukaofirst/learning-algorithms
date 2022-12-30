function sort<T>(arr: T[], left: number, right: number): void {
    if (left < right) {
        const mid = Math.floor(left + (right - left) / 2);

        sort(arr, left, mid);
        sort(arr, mid + 1, right);

        merge(arr, left, mid, right);
    }
}

function merge<T>(arr: T[], left: number, middle: number, right: number): void {
    const leftArrLength = middle - left + 1;
    const rightArrLength = right - middle;

    const leftTempArr: T[] = [];
    const rightTempArr: T[] = [];
    let i: number, j: number;

    for (i = 0; i < leftArrLength; i++) leftTempArr.push(arr[left + i]);

    for (j = 0; j < rightArrLength; j++) rightTempArr.push(arr[middle + 1 + j]);

    i = 0;
    j = 0;

    let k: number = left;

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

const numbers = [31, 10, 29, 42, 51, 19, 83, 7];

sort(numbers, 0, numbers.length - 1);

numbers.forEach((number) => console.log(number));
