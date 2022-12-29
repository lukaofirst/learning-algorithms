void main() {
  final recursiveResult = factorial(8);
  final iterativeResult = factorialIterative(8);

  print(recursiveResult);
  print(iterativeResult);
}

int factorial(int n) {
  if (n <= 1) return 1;

  return n * factorial(n - 1);
}

int factorialIterative(int n) {
  var product = 1;

  for (var i = 1; i <= n; i++) {
    product *= i;
  }

  return product;
}
