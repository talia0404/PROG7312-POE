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
		// Dictionary containing Dewey Decimal System categories
		Dictionary<string, string> deweyCategories = new Dictionary<string, string>
		{
			{ "000-099", "Generalities" },
			{ "100-199", "Philosophy and Psychology" },
			{ "200-299", "Religion" },
			{ "300-399", "Social Sciences" },
			{ "400-499", "Language" },
			{ "500-599", "Natural Sciences and Mathematics" },
			{ "600-699", "Technology (Applied Sciences)" },
			{ "700-799", "Arts and Recreation" },
			{ "800-899", "Literature" },
			{ "900-999", "History and Geography" },
		};

		DataGridViewManager dgvManager; // Manager for DataGridViews

		public IdentifyArea()
		{
			InitializeComponent();
		}

		private void frmIDAreas_Load(object sender, EventArgs e)
		{
			// Create a BindingList for each DataGridView
			BindingList<KeyValuePair<string, string>> leftDataSource = new BindingList<KeyValuePair<string, string>>(deweyCategories.ToList());
			BindingList<KeyValuePair<string, string>> rightDataSource = new BindingList<KeyValuePair<string, string>>(deweyCategories.ToList());

			// Initialize DataGridViewManager with data sources and DataGridViews
			dgvManager = new DataGridViewManager(deweyCategories, dvgKey, dvgValues);

			// Ensure matching items in DataGridViews
			MatchingItemsChecker.EnsureMatchingItems(leftDataSource, rightDataSource);

		}

		private void btnMatch_Click(object sender, EventArgs e)
		{
			// Get the selected items from DataGridViews
			KeyValuePair<string, string> selectedLeftItem = (KeyValuePair<string, string>)dvgKey.CurrentRow.DataBoundItem;
			KeyValuePair<string, string> selectedRightItem = (KeyValuePair<string, string>)dvgValues.CurrentRow.DataBoundItem;

			// Check for a match and update the score
			bool isMatched = IDAreasSuccessChecker.CheckForMatchAndScore(
				selectedLeftItem,
				selectedRightItem,
				dvgKey,
				dvgValues,
				lblPoint,
				lblAnswers);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			// Return to the main menu
			PROG7312_V1 actChoice = new PROG7312_V1();
			actChoice.Show();
			this.Close();
		}

		private void btnIdentifyAreas_Click(object sender, EventArgs e)
		{
			// Open the 'ReplaceBook' form
			ReplaceBook replaceForm = new ReplaceBook();
			replaceForm.Show();
			this.Close();
		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{

			lblPoint.Text = 0.ToString();

			// Create a BindingList for each DataGridView
			BindingList<KeyValuePair<string, string>> leftDataSource = new BindingList<KeyValuePair<string, string>>(deweyCategories.ToList());
			BindingList<KeyValuePair<string, string>> rightDataSource = new BindingList<KeyValuePair<string, string>>(deweyCategories.ToList());

			// Initialize DataGridViewManager with data sources and DataGridViews
			dgvManager = new DataGridViewManager(deweyCategories, dvgKey, dvgValues);

			// Ensure matching items in DataGridViews
			MatchingItemsChecker.EnsureMatchingItems(leftDataSource, rightDataSource);
		}
	}
}
