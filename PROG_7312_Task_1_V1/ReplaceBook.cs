using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace PROG_7312_Task_1_V1
{
	public partial class ReplaceBook : Form
	{
		private List<string> generatedDDS;
		private int point = 0;



		public ReplaceBook()
		{
			InitializeComponent();
			generatedDDS = new List<string>();
		


		}

		private void ReplaceBook_Load(object sender, EventArgs e)
		{
			// Generate 10 different random Dewey Decimal System call numbers
			generatedDDS = generateRandomDDSNumbers(10);

			// Display the generated call numbers in the ListBox
			lbxDisplay.Items.Clear();
			lbxDisplay.Items.AddRange(generatedDDS.ToArray());
			

		}

		private List<string> generateRandomDDSNumbers(int count)
		{
			Random randomNumbers = new Random();
			List<string> stringNumbers = new List<string>();

			while (stringNumbers.Count < count)
			{
				// Generate a random Dewey Decimal System call number (adjust as needed)
				string callNumber = $"{randomNumbers.Next(0, 1000):000}.{randomNumbers.Next(0, 100):00} {GenerateRandomLetters(randomNumbers)}";

				// Check if the call number is not already in the list
				if (!stringNumbers.Contains(callNumber))
				{
					stringNumbers.Add(callNumber);
				}
			}

			return stringNumbers;
		}

		private string GenerateRandomLetters(Random randomL)
		{
			const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			char[] randomLetters = new char[3];

			for (int i = 0; i < 3; i++)
			{
				randomLetters[i] = letters[randomL.Next(letters.Length)];
			}

			return new string(randomLetters);
		}

		private bool AreFirstThreeCharactersInAscendingOrder(ListBox listBox)
		{
			List<string> items = listBox.Items.Cast<string>().ToList();

			if (items.Count <= 1)
			{
				return true; // If there's only one item or none, it's considered in ascending order.
			}

			for (int i = 0; i < items.Count - 1; i++)
			{
				string currentItem = items[i].Substring(0, 3); // Get the first 3 characters of the current item
				string nextItem = items[i + 1].Substring(0, 3); // Get the first 3 characters of the next item

				if (string.Compare(currentItem, nextItem) > 0)
				{
					return false; // If any item's first 3 characters are greater than the next one, it's not in ascending order
				}
			}

			return true; // All items have first 3 characters in ascending order
		}

		private void PointIncrement()
		{
			// Increment the counter and update the label
			point++;
			lblPoint.Text = $"{point}";
		}

		private void PointDecrement()
		{
			// Increment the counter and update the label
			point--;
			lblPoint.Text = $"{point}";
		}


		private void btnCheckOrder_Click(object sender, EventArgs e)
		{

			if (lbxSort.Items.Count==10) 
			{

				bool areFirstThreeCharsAscending = AreFirstThreeCharactersInAscendingOrder(lbxSort);

				if (areFirstThreeCharsAscending)
				{
					PointIncrement();

					//Inform user they've gained a point
					MessageBox.Show("Well done! You've gained a point!");

					// Generate 10 different random Dewey Decimal System call numbers
					generatedDDS = generateRandomDDSNumbers(10);
					// Display the generated call numbers in the ListBox
					lbxDisplay.Items.Clear();
					lbxDisplay.Items.AddRange(generatedDDS.ToArray());

					//Clear Items in Answer Listbox
					lbxSort.Items.Clear();
				}

				else
				{
					PointDecrement();
					MessageBox.Show("Sorry! You've lost a point.");
				}
			}
			else
			{
				MessageBox.Show("Please fill in all numbers.");
			}

		}

		

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (tbxReOrder.Text.Length == 9)
			{
				// Get the user's input from the TextBox
				string userInput = tbxReOrder.Text;

				// Split the user input into an array of strings
				string[] userNumbers = userInput.Split(new char[] { '\r', '\n', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

				lbxSort.Items.AddRange(userNumbers.ToArray());

				tbxReOrder.Text = "";
			}
			else
			{
				MessageBox.Show("Please enter 9 characters.");
			}
			
		}

		private void tbxReOrder_TextChanged(object sender, EventArgs e)
		{
		//	MessageBox.Show("Only leave spaces an add characters after each number!");

		}

		private void btnRegen_Click(object sender, EventArgs e)
		{
			// Generate 10 different random Dewey Decimal System call numbers
			generatedDDS = generateRandomDDSNumbers(10);

			// Display the generated call numbers in the ListBox
			lbxDisplay.Items.Clear();
			lbxDisplay.Items.AddRange(generatedDDS.ToArray());
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			lbxSort.Items.Clear();

		}

		private void btnGenClear_Click(object sender, EventArgs e)
		{
			lbxDisplay.Items.Clear();
		}

		private void lblInstruct1_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lbxSort.SelectedIndex != -1) // Check if an item is selected
			{
				lbxSort.Items.RemoveAt(lbxSort.SelectedIndex); // Remove the selected item
			}
			else
			{
				MessageBox.Show("Item not selected.");
			}
		}
	}
}
