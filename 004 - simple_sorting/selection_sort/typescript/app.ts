function selectionSort<T>(arr: T[]): void {
    for (let i = 0; i < arr.length; i++) {
        let smallestIndex = i;

        for (let j = i + 1; j < arr.length; j++) {
            if (arr[j] < arr[smallestIndex]) {
                smallestIndex = j;
            }
        }

        const aux = arr[smallestIndex];
        arr[smallestIndex] = arr[i];
        arr[i] = aux;
    }
}

const numbers = [36, 12, 29, 42, 10, 83];

selectionSort(numbers);

numbers.forEach((number) => console.log(number));
