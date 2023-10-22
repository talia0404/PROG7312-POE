using PROG_7312_Task_1_V1;
using System;
using System.Windows.Forms;

public static class ResultConditions
{
	public static void PerformSortingAndCheck(ListBox lbxDisplay, Label lblPoint, Label lblHeader, Label lblHeader2)
	{
		// Check if the list is sorted in ascending order
		bool isSorted = CheckSorting.SortCheck(lbxDisplay);

		// Update the label based on whether the list is sorted
		if (isSorted)
		{
			CheckSorting.PointInc(lblPoint);
			HandleSortingSuccess(lbxDisplay, lblHeader, lblHeader2);
		}
		else
		{
			CheckSorting.PointDec(lblPoint);
			HandleSortingFailure(lbxDisplay, lblHeader, lblHeader2);
		}
	}

	private static void HandleSortingSuccess(ListBox lbxDisplay, Label lblHeader, Label lblHeader2)
	{
		if (lbxDisplay.Items.Count > 0)
		{

			DialogResult result = MessageBox.Show("You scored a point!\n\nWould you like to try again?",
				"Sorted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				lblHeader.Text = "Order the numbers into";
				lblHeader2.Text = "ascending order:";

				// Generate 10 different random Dewey Decimal System call numbers
				RandomlyGenerated.GenerateRandomDDSNumbers(10);

				// Display the generated call numbers in the ListBox
				lbxDisplay.Items.Clear();
				lbxDisplay.Items.AddRange(RandomlyGenerated.GenerateRandomDDSNumbers(10).ToArray());
			}
			else
			{
				HandleExitRequest(lbxDisplay, lblHeader, lblHeader2);
			}

		}
		else
		{
			MessageBox.Show("Generate Values :)");
		}
	}

	private static void HandleSortingFailure(ListBox lbxDisplay, Label lblHeader, Label lblHeader2)
	{
		if (lbxDisplay.Items.Count > 0)
		{
			DialogResult result = MessageBox.Show("You've lost a point:( \n\nWould you like to try again?",
				"Sorted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				lblHeader.Text = "Order the numbers into";
				lblHeader2.Text = "ascending order:";

				// Generate 10 different random Dewey Decimal System call numbers
				RandomlyGenerated.GenerateRandomDDSNumbers(10);

				// Display the generated call numbers in the ListBox
				lbxDisplay.Items.Clear();
				lbxDisplay.Items.AddRange(RandomlyGenerated.GenerateRandomDDSNumbers(10).ToArray());
			}
			else
			{
				// Sort the items in lbxDisplay using the Bubble Sort method
				Sorting.BubbleSortValues(lbxDisplay);

				lblHeader.Text = "Correct Order:";
				lblHeader2.Visible = false;

				HandleExitRequest(lbxDisplay, lblHeader, lblHeader2);
			}
		}
		else
		{
			MessageBox.Show("Generate Values :)");

		}
	}

	private static void HandleExitRequest(ListBox lbxDisplay, Label lblHeader, Label lblHeader2)
	{
		DialogResult result = MessageBox.Show("Would you like to close the app?",
			"Sorted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (result == DialogResult.Yes)
		{
			Application.Exit();
		}else
		{
			lblHeader.Text = "Order the numbers into";
			lblHeader2.Text = "ascending order:";
			lbxDisplay.Items.Clear();
		}
	}
}

