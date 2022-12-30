internal class Program
{
	private static void Main(string[] args)
	{
		var numbers = new int[] { 31, 10, 29, 42, 51, 19, 83, 7 };

		Sort(numbers, 0, numbers.Length - 1);

		foreach (var item in numbers)
		{
			Console.WriteLine(item);
		}
	}

	internal static void Sort(int[] arr, int left, int right)
	{
		if (left < right)
		{
			var mid = left + (right - left) / 2;

			Sort(arr, left, mid);
			Sort(arr, mid + 1, right);

			Merge(arr, left, mid, right);
		}
	}

	internal static void Merge(int[] arr, int left, int middle, int right)
	{
		var leftArrLength = middle - left + 1;
		var rightArrLength = right - middle;

		var leftTempArr = new int[leftArrLength];
		var rightTempArr = new int[rightArrLength];
		int i, j;

		for (i = 0; i < leftArrLength; i++)
			leftTempArr[i] = arr[left + i];

		for (j = 0; j < rightArrLength; j++)
			rightTempArr[j] = arr[middle + 1 + j];

		i = 0;
		j = 0;

		int k = left;

		while (i < leftArrLength && j < rightArrLength)
		{
			if (leftTempArr[i] <= rightTempArr[j])
			{
				arr[k++] = leftTempArr[i++];
			}
			else
			{
				arr[k++] = rightTempArr[j++];
			}
		}

		while (i < leftArrLength)
		{
			arr[k++] = leftTempArr[i++];
		}

		while (j < rightArrLength)
		{
			arr[k++] = rightTempArr[j++];
		}
	}
}