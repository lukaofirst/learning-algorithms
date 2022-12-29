function insertionSort<T>(arr: T[]): void {
    for (let i = 1; i < arr.length; i++) {
        const aux = arr[i];

        for (let j = i - 1; j >= 0 && arr[j] > aux; j--) {
            arr[j + 1] = arr[j];
            arr[j] = aux;
        }
    }
}

const numbers = [36, 12, 29, 42, 10, 83];

insertionSort(numbers);

numbers.forEach((number) => console.log(number));
