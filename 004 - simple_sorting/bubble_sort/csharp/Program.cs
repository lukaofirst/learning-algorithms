internal class Program
{
	private static void Main(string[] args)
	{
		var numbers = new int[] { 36, 12, 29, 42, 10, 83 };

		BubbleSort(numbers);

		foreach (var item in numbers)
		{
			Console.WriteLine(item);
		}
	}

	internal static void BubbleSort(int[] arr)
	{
		for (var i = 0; i < arr.Length - 1; i++)
		{
			var swapped = false;

			for (var j = 0; j < arr.Length - 1; j++)
			{
				if (arr[j] > arr[j + 1])
				{
					var aux = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = aux;

					swapped = true;
				}
			}

			if (!swapped) break;
		}
	}

	internal static void BubbleSortRecursive(int[] arr, int n)
	{
		if (n == 0 || n == 1) return;

		for (var i = 0; i < n - 1; i++)
		{
			if (arr[i] > arr[i + 1])
			{
				var aux = arr[i];
				arr[i] = arr[i + 1];
				arr[i + 1] = aux;
			}
		}

		BubbleSortRecursive(arr, n - 1);
	}
}