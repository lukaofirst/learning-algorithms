function binarySearch<T>(arr: T[], searchValue: T): number {
    let low = 0;
    let high = arr.length - 1;

    while (low <= high) {
        const mid = Math.floor((low + high) / 2);

        const guess = arr[mid];

        if (guess === searchValue) return mid;

        if (guess > searchValue) high = mid - 1;
        else low = mid + 1;
    }

    return -1;
}

function binarySearchRecursive<T>(
    arr: T[],
    low: number,
    high: number,
    searchValue: T
): number {
    while (low <= high) {
        const mid = Math.floor((low + high) / 2);

        const guess = arr[mid];

        if (guess === searchValue) return mid;

        if (guess > searchValue)
            return binarySearchRecursive(arr, low, mid - 1, searchValue);
        else return binarySearchRecursive(arr, mid + 1, high, searchValue);
    }

    return -1;
}

const numbers = [1, 37, 54, 90, 209];

const iterativeResult = binarySearch(numbers, 209);
const recursiveResult = binarySearchRecursive(
    numbers,
    0,
    numbers.length - 1,
    37
);

console.log(`iterative: index - ${iterativeResult}`);
console.log(`recursive: index - ${recursiveResult}`);
