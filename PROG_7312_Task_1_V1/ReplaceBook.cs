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

namespace PROG_7312_Task_1_V1
{
	public partial class ReplaceBook : Form
	{
		private List<string> generatedDDS;
		//private List<string> userOrder;



		public ReplaceBook()
		{
			InitializeComponent();
			generatedDDS = new List<string>();
		//	userOrder = new List<string>();


		}

		private void ReplaceBook_Load(object sender, EventArgs e)
		{
			// Generate 10 different random Dewey Decimal System call numbers
			generatedDDS = generateRandomDDSNumbers(10);

			// Display the generated call numbers in the ListBox
			lbxDisplay.Items.Clear();
			lbxDisplay.Items.AddRange(generatedDDS.ToArray());
			lblInstruct1.Text = "Only add spaces or ',' after each number!";

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


		private void btnCheckOrder_Click(object sender, EventArgs e)
		{
			j
		}

		private bool CheckOrder(string[] userOrderedNumbers)
		{
			// Check if the user's ordering matches the generated numbers
			if (userOrderedNumbers.Length != generatedDDS.Count)
			{
				return false;
			}

			for (int i = 0; i < userOrderedNumbers.Length; i++)
			{
				if (userOrderedNumbers[i] != generatedDDS[i])
				{
					return false;
				}
			}

			return true;
		}

		

		private void btnAdd_Click(object sender, EventArgs e)
		{

			// Get the user's input from the TextBox
			string userInput = tbxReOrder.Text;

			// Split the user input into an array of strings
			string[] userNumbers = userInput.Split(new char[] { '\r', '\n', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

			lbxSort.Items.AddRange(userNumbers.ToArray());

			
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
	}
}
