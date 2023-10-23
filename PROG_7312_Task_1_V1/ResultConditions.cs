public static class ResultConditions
{
	public static void PointInc(Label label)
	{
		int currentValue = int.Parse(label.Text);
		currentValue++;
		label.Text = currentValue.ToString();
	}

	public static void PointDec(Label label)
	{
		int currentValue = int.Parse(label.Text);
		currentValue--;
		label.Text = currentValue.ToString();
	}


	public static void HandleSortingSuccess(ListBox lbxDisplay, Label lblHeader, Label lblHeader2)
	{
		if (lbxDisplay.Items.Count > 0)
		{

			DialogResult result = MessageBox.Show("You scored a point!\n\nWould you like to try again?",
				"Sorted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				lblHeader.Text = "Order the numbers into";
				lblHeader2.Visible = true;
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

	public static void HandleSortingFailure(ListBox lbxDisplay, Label lblHeader, Label lblHeader2)
	{
		if (lbxDisplay.Items.Count > 0)
		{
			DialogResult result = MessageBox.Show("You've lost a point:( \n\nWould you like to try again?",
				"Sorted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				lblHeader.Text = "Order the numbers into";
				lblHeader2.Visible = true;
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

	public static void HandleExitRequest(ListBox lbxDisplay, Label lblHeader, Label lblHeader2)
	{
		DialogResult result = MessageBox.Show("Would you like to close the app?",
			"Sorted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (result == DialogResult.Yes)
		{
			Application.Exit();
		}
		else
		{
			lblHeader.Text = "Order the numbers into";
			lblHeader2.Text = "ascending order:";
			lbxDisplay.Items.Clear();
		}
	}
}

