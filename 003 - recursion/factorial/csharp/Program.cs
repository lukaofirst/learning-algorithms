internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine(Factorial(8));
		Console.WriteLine(FactorialIterative(8));
	}

	internal static int Factorial(int n)
	{
		if (n <= 1) return 1;

		return n * Factorial(n - 1);
	}

	internal static int FactorialIterative(int n)
	{
		var product = 1;

		for (var i = 1; i <= n; i++)
		{
			product *= i;
		}

		return product;
	}
}