using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_7312_Task_1_V1
{
	public class IDAreasSuccessChecker
	{
		public static bool CheckForMatchAndScore(KeyValuePair<string, string> selectedLeftItem, KeyValuePair<string, string> selectedRightItem,
			DataGridView leftDataGridView,
			DataGridView rightDataGridView,
			Label scoreLabel,
			Label lblAnswers)
		{

			if (selectedLeftItem.Key == selectedRightItem.Key && selectedLeftItem.Value == selectedRightItem.Value)
			{
				MessageBox.Show("Items match!");
				// Items match - increment the user's score
				int userScore = int.Parse(scoreLabel.Text);
				userScore++;

				// Remove matched items from both DataGridViews
				RemoveItemFromDataGridView(selectedLeftItem, leftDataGridView);
				RemoveItemFromDataGridView(selectedRightItem, rightDataGridView);
				AddItemsToLabel(selectedLeftItem, leftDataGridView, lblAnswers);
				AddItemsToLabel(selectedRightItem,rightDataGridView,lblAnswers);

				// Display the updated score
				scoreLabel.Text = userScore.ToString();

				

				return true; // Matched
			}
			else
			{
				MessageBox.Show("Items do not match.");
				return false; // Not matched
			}
		}

		private static void RemoveItemFromDataGridView(KeyValuePair<string, string> item, DataGridView dgv)
		{
			BindingList<KeyValuePair<string, string>> dataSource = (BindingList<KeyValuePair<string, string>>)dgv.DataSource;
			dataSource.Remove(item);
		}

		private static void AddItemsToLabel(KeyValuePair<string, string> item, DataGridView dgv, Label lblAnswers)
		{
			BindingList<KeyValuePair<string, string>> dataSource = (BindingList<KeyValuePair<string, string>>)dgv.DataSource;
			lblAnswers.Text= (item.Key) + " \n" +(item.Value);
		}
	}

}
