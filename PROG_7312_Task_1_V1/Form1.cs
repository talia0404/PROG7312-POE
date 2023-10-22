namespace PROG_7312_Task_1_V1
{
	public partial class PROG7312_V1 : Form
	{
		public PROG7312_V1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btnNumbers.Enabled = false;
		}

		private void btnReplace_Click(object sender, EventArgs e)
		{
			ReplaceBook form2 = new ReplaceBook(); // Replace "Form2" with the actual name of your target form

			// Show the new form
			form2.Show();

			// Optionally, hide the current form if you want to close it
			//this.Hide();


		}
	}
}