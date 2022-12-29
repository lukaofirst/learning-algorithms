function factorial(n: number): number {
    if (n <= 1) return 1;

    return n * factorial(n - 1);
}

function factorialIterative(n: number): number {
    var product = 1;

    for (let i = 1; i <= n; i++) {
        product *= i;
    }

    return product;
}

const recursiveResult = factorial(8);
const iterativeResult = factorialIterative(8);

console.log(recursiveResult);
console.log(iterativeResult);
