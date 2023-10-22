using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PROG_7312_Task_1_V1 //ST10083706
{
	public partial class ReplaceBook : Form
	{
		private List<string> generatedDDS;
		private int point = 0;

		// Create an instance of the DragDrop class
		private DragDrop dragDropHandler;

		public ReplaceBook()
		{
			InitializeComponent();
			generatedDDS = new List<string>();

			// Initialize the DragDrop class with lbxDisplay ListBox
			dragDropHandler = new DragDrop(lbxDisplay);

		}


		private void ReplaceBook_Load(object sender, EventArgs e)
		{
			// Generate 10 different random Dewey Decimal System call numbers
			generatedDDS = RandomlyGenerated.GenerateRandomDDSNumbers(10);

			// Display the generated call numbers in the ListBox
			lbxDisplay.Items.Clear();
			lbxDisplay.Items.AddRange(generatedDDS.ToArray());

			// Enable drag-and-drop in the ListBox
			lbxDisplay.AllowDrop = true;

		}

		
		private bool ThreeCharsAscOrder(ListBox listBox)
		{
			List<string> items = listBox.Items.Cast<string>().ToList();

			if (items.Count <= 1)
			{
				return true; // If there's only one item or none, it's considered in ascending order.
			}

			for (int i = 0; i < items.Count - 1; i++)
			{
				string currentItem = items[i].Substring(0, 3);
				string nextItem = items[i + 1].Substring(0, 3);

				if (string.Compare(currentItem, nextItem) > 0)
				{
					return false; 
					// If any item's first 3 characters are greater than the next one, it's not in ascending order
				}
			}

			return true; 
			// All items have first 3 characters in ascending order
		}

		private void PointInc()
		{
			point++;
			lblPoint.Text = $"{point}";
		}

		private void PointDec()
		{
			point--;
			lblPoint.Text = $"{point}";
		}

		private void btnCheckOrder_Click(object sender, EventArgs e)
		{
			bool areFirstThreeCharsAscending = ThreeCharsAscOrder(lbxDisplay);

			if (areFirstThreeCharsAscending)
			{
				PointInc();
				MessageBox.Show("Well done! You've gained a point!");

				DialogResult result = MessageBox.Show("Try again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					generatedDDS = RandomlyGenerated.GenerateRandomDDSNumbers(10);
					lbxDisplay.Items.Clear();
					lbxDisplay.Items.AddRange(generatedDDS.ToArray());
				}
			}
			else
			{
				PointDec();
				MessageBox.Show("Sorry! You've lost a point.");
			}
		}

		private void btnRegen_Click(object sender, EventArgs e)
		{
			generatedDDS = RandomlyGenerated.GenerateRandomDDSNumbers(10);
			lbxDisplay.Items.Clear();
			lbxDisplay.Items.AddRange(generatedDDS.ToArray());
		}

		private void btnGenClear_Click(object sender, EventArgs e)
		{
			lbxDisplay.Items.Clear();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lbxDisplay.SelectedIndex != -1)
			{
				lbxDisplay.Items.RemoveAt(lbxDisplay.SelectedIndex);
			}
			else
			{
				MessageBox.Show("Item not selected.");
			}
		}
	}
}



/*
 Website Name: ChatGPT (2023). ChatGPT. [online] chat.openai.com. 
Available at: https://chat.openai.com/.

Website Name: Educative. (n.d.). Educative Answers - Trusted Answers to Developer Questions. [online] 
Available at: https://www.educative.io/answers/how-to-generate-random-numbers-in-c-sharp [Accessed 27 Sep. 2023].

Website Name:www.tutorialsteacher.com. (n.d.). C# List Collection. [online] 
Available at: https://www.tutorialsteacher.com/csharp/csharp-list.

Website Name:‌‌GeeksforGeeks. (2019). How to sort a list in C# | List.Sort() Method Set -1. [online] 
Available at: https://www.geeksforgeeks.org/how-to-sort-list-in-c-sharp-set-1/#:~:text=List. [Accessed 27 Sep. 2023].

‌
 
 */