internal partial class Program
{
	private static void Main(string[] args)
	{
		var numbers = new int[] { 10, 80, 30, 90, 40, 50, 70 };

		QuickSort(numbers, 0, numbers.Length - 1);

		foreach (var item in numbers)
		{
			Console.WriteLine(item);
		}
	}

	internal static void Swap(int[] arr, int i, int j)
	{
		var aux = arr[i];
		arr[i] = arr[j];
		arr[j] = aux;
	}

	internal static int Partition(int[] arr, int low, int high)
	{
		var pivot = arr[high];

		var i = low - 1;

		for (var j = low; j <= high - 1; j++)
		{
			if (arr[j] < pivot)
			{
				i++;
				Swap(arr, i, j);
			}
		}

		Swap(arr, i + 1, high);

		return (i + 1);
	}

	internal static void QuickSort(int[] arr, int low, int high)
	{
		if (low < high)
		{
			var partIdx = Partition(arr, low, high);

			QuickSort(arr, low, partIdx - 1);
			QuickSort(arr, partIdx + 1, high);
		}
	}
}