internal class Program
{
	private static void Main(string[] args)
	{
		var numbers = new int[] { 36, 12, 29, 42, 10, 83 };

		SelectionSort(numbers);

		foreach (var item in numbers)
		{
			Console.WriteLine(item);
		}
	}

	internal static void SelectionSort(int[] arr)
	{
		for (var i = 0; i < arr.Length; i++)
		{
			var smallestIndex = i;

			for (var j = i + 1; j < arr.Length; j++)
			{
				if (arr[j] < arr[smallestIndex])
				{
					smallestIndex = j;
				}
			}

			var aux = arr[smallestIndex];
			arr[smallestIndex] = arr[i];
			arr[i] = aux;
		}
	}
}