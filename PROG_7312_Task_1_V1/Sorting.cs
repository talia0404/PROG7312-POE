public static class Sorting
{
	public static List<string> BubbleSortValues(ListBox listBox)
	{
		int n = listBox.Items.Count;
		bool swapped;
		var sortedList = new List<string>();

		foreach (var item in listBox.Items)
		{
			sortedList.Add(item.ToString());
		}

		do
		{
			swapped = false;
			for (int i = 1; i < n; i++)
			{
				if (string.Compare(sortedList[i - 1], sortedList[i], StringComparison.Ordinal) > 0)
				{
					// Swap the items
					string temp = sortedList[i - 1];
					sortedList[i - 1] = sortedList[i];
					sortedList[i] = temp;
					swapped = true;
				}
			}
			n--;
		} while (swapped);

		return sortedList;
	}


}

