using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_7312_Task_1_V1
{
	public class IDAreasSuccessChecker
	{
		public static bool CheckForMatchAndScore(
			KeyValuePair<string, string> selectedLeftItem, KeyValuePair<string, string> selectedRightItem,
			DataGridView leftDataGridView, DataGridView rightDataGridView,
			Label scoreLabel, Label lblAnswers, Button btnMatch, PictureBox pictureBox, Label lblWin,Label lblHeader)
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

				// Display the updated score
				scoreLabel.Text = userScore.ToString();

				lblAnswers.Font = new Font(lblAnswers.Font.FontFamily, 14);

				// List the removed items in lblAnswers
				lblAnswers.Text += $"Matched: \n{selectedLeftItem.Key} - \n{selectedLeftItem.Value}\n\n";

				if(scoreLabel.Text == 4.ToString())
				{
					btnMatch.Visible = false;
					lblAnswers.Visible=false; 
					pictureBox.SizeMode=PictureBoxSizeMode.StretchImage;
					pictureBox.Visible = true;
					lblWin.Visible = true;
					lblHeader.Visible = false;
				}

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
	}
}
