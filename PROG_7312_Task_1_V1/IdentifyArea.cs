using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_7312_Task_1_V1
{
	public partial class IdentifyArea : Form

	{

		public IdentifyArea()
		{
			InitializeComponent();
		}

		private void frmIDAreas_Load(object sender, EventArgs e)
		{


		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			PROG7312_V1 actChoice = new PROG7312_V1();
			actChoice.Show();
			this.Close();
		}

		private void btnIdentifyAreas_Click(object sender, EventArgs e)
		{
			ReplaceBook replaceForm = new ReplaceBook();

			replaceForm.Show();

			this.Close();
		}
	}
}
