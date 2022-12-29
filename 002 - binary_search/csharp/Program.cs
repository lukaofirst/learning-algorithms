internal class Program
{
	private static void Main(string[] args)
	{
		var numbers = new int[] { 1, 37, 54, 90, 209 };

		var iterativeResult = BinarySearch(numbers, 209);
		var recursiveResult = BinarySearchRecursive(numbers, 0, numbers.Length - 1, 37);

		Console.WriteLine($"iterative: index - {iterativeResult}");
		Console.WriteLine($"recursive: index - {recursiveResult}");
	}

	static int BinarySearch(int[] arr, int searchValue)
	{
		var low = 0;
		var high = arr.Length - 1;

		while (low <= high)
		{
			var mid = (low + high) / 2;

			var guess = arr[mid];

			if (guess == searchValue) return mid;

			if (guess > searchValue)
				high = mid - 1;
			else
				low = mid + 1;
		}

		return -1;
	}

	static int BinarySearchRecursive(int[] arr, int low, int high, int searchValue)
	{

		if (low <= high)
		{
			var mid = (low + high) / 2;

			var guess = arr[mid];

			if (guess == searchValue) return mid;

			if (guess > searchValue)
				return BinarySearchRecursive(arr, low, mid - 1, searchValue);
			else
				return BinarySearchRecursive(arr, mid + 1, high, searchValue);
		}

		return -1;
	}
}