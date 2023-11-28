using System;

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

		}

		private void btnReplace_Click(object sender, EventArgs e)
		{
			ReplaceBook form2 = new ReplaceBook();

			form2.Show();

			this.Hide();
		}

		private void btnIdentify_Click(object sender, EventArgs e)
		{
			IdentifyArea form3 = new IdentifyArea();

			form3.Show();

			this.Hide();
		}

		private void btnNumbers_Click(object sender, EventArgs e)
		{
			FindCallNumbers form4 = new FindCallNumbers();

			form4.Show();

			this.Hide();
		}
	}
}