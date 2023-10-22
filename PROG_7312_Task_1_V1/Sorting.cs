using System;
using System.Windows.Forms;

public static class Sorting
{
	public static void BubbleSortValues(ListBox listBox)
	{
		int n = listBox.Items.Count;
		bool swapped;

		do
		{
			swapped = false;
			for (int i = 1; i < n; i++)
			{
				if (string.Compare(listBox.Items[i - 1].ToString(), listBox.Items[i].ToString(), StringComparison.Ordinal) > 0)
				{
					// Swap the items
					object temp = listBox.Items[i - 1];
					listBox.Items[i - 1] = listBox.Items[i];
					listBox.Items[i] = temp;
					swapped = true;
				}
			}
			n--;
		} while (swapped);
	}
	

}

