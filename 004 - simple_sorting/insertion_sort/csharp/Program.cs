internal class Program
{
	private static void Main(string[] args)
	{
		var numbers = new int[] { 36, 12, 29, 42, 10, 83 };

		InsertionSort(numbers);

		foreach (var item in numbers)
		{
			Console.WriteLine(item);
		}
	}

	internal static void InsertionSort(int[] arr)
	{
		for (var i = 1; i < arr.Length; i++)
		{
			var aux = arr[i];

			for (var j = i - 1; j >= 0 && arr[j] > aux; j--)
			{
				arr[j + 1] = arr[j];
				arr[j] = aux;
			}
		}
	}
}