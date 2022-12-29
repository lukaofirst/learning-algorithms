function sequentialSearch<T>(arr: T[], searchValue: T): number {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === searchValue) return i;
    }

    return -1;
}

function sequentialSearchRecursive<T>(arr: T[], searchValue: T): number {
    const size = arr.length;

    if (size == 0) return -1;
    else if (arr[size - 1] === searchValue) return size - 1;
    else return sequentialSearchRecursive(arr, searchValue);
}

const numbers = [1, 90, 54, 209, 37];

const iterativeResult = sequentialSearch(numbers, 209);
const recursiveResult = sequentialSearchRecursive(numbers, 37);

console.log(`iterative: index - ${iterativeResult}`);
console.log(`recursive: index - ${recursiveResult}`);
