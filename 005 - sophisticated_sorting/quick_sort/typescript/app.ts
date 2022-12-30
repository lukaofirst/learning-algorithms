function quicksort<T>(arr: T[], low: number, high: number): void {
    if (low < high) {
        var partIdx = partition(arr, low, high);

        quicksort(arr, low, partIdx - 1);
        quicksort(arr, partIdx + 1, high);
    }
}

function partition<T>(arr: T[], low: number, high: number): number {
    const pivot = arr[high];

    let i = low - 1;

    for (let j = low; j <= high - 1; j++) {
        if (arr[j] < pivot) {
            i++;
            swap(arr, i, j);
        }
    }

    swap(arr, i + 1, high);

    return i + 1;
}

function swap<T>(arr: T[], i: number, j: number): void {
    const aux = arr[i];
    arr[i] = arr[j];
    arr[j] = aux;
}

const numbers = [10, 80, 30, 90, 40, 50, 70];

quicksort(numbers, 0, numbers.length - 1);

numbers.forEach((number) => console.log(number));
