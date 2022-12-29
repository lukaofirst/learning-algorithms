internal class Program
{
	private static void Main(string[] args)
	{
		var numbers = new int[] { 1, 90, 54, 209, 37 };

		var iterativeResult = SequentialSearch(numbers, 209);
		var recursiveResult = SequentialSearchRecursive(numbers, 37);

		Console.WriteLine($"iterative: index - {iterativeResult}");
		Console.WriteLine($"recursive: index - {recursiveResult}");
	}

	static int SequentialSearch(int[] arr, int searchValue)
	{
		for (var i = 0; i < arr.Length; i++)
		{
			if (arr[i] == searchValue)
				return i;
		}

		return -1;
	}

	static int SequentialSearchRecursive(int[] arr, int searchValue)
	{
		var size = arr.Length;

		if (size == 0)
			return -1;
		else if (arr[size - 1] == searchValue)
			return size - 1;
		else
			return SequentialSearchRecursive(arr, searchValue);
	}
}