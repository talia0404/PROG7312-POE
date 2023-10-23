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

		private void btnRegen_Click(object sender, EventArgs e)
		{
			generatedDDS = RandomlyGenerated.GenerateRandomDDSNumbers(10);
			lbxDisplay.Items.Clear();
			lbxDisplay.Items.AddRange(generatedDDS.ToArray());
		}


		private void btnCheckOrder_Click(object sender, EventArgs e)
		{
			CheckSorting.PerformCheck(lbxDisplay, lblPoint, lblHeader, lblHeader2);
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