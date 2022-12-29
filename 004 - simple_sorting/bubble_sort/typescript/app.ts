function bubbleSort<T>(arr: T[]): void {
    for (let i = 0; i < arr.length - 1; i++) {
        let swapped = false;

        for (let j = 0; j < arr.length - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                const aux = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = aux;

                swapped = true;
            }
        }

        if (!swapped) break;
    }
}

function bubbleSortRecursive<T>(arr: T[], n: number): void {
    if (n == 0 || n == 1) return;

    for (let i = 0; i < n - 1; i++) {
        if (arr[i] > arr[i + 1]) {
            var aux = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = aux;
        }
    }

    bubbleSortRecursive(arr, n - 1);
}

const numbers = [36, 12, 29, 42, 10, 83];

bubbleSort(numbers);

numbers.forEach((number) => console.log(number));
