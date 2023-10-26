namespace PROG_7312_Task_1_V1
{
	public static class CheckSorting
	{
		public static void PerformCheck(ListBox lbxDisplay, Label lblPoint, Label lblHeader, Label lblHeader2)
		{
			List<string> sortedValues = Sorting.BubbleSortValues(lbxDisplay);

			// Convert ListBox items to a List<string>
			List<string> lbxdisp = new List<string>();

			foreach (var item in lbxDisplay.Items)
			{
				lbxdisp.Add(item.ToString());
			}

			// Compare the contents
			bool isSorted = lbxdisp.SequenceEqual(sortedValues);

			// Update the label based on whether the list is sorted
			if (isSorted)
			{
				ResultConditions.PointInc(lblPoint);
				ResultConditions.HandleSortingSuccess(lbxDisplay, lblHeader, lblHeader2);
			}
			else
			{
				ResultConditions.PointDec(lblPoint);
				ResultConditions.HandleSortingFailure(lbxDisplay, lblHeader, lblHeader2);
			}
		}

	}
}
