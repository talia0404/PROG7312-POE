using PROG_7312_Task_1_V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROG_7312_Task_1_V1
{
	public partial class btnLevel1ARepop : Form
	{

		public btnLevel1ARepop()
		{
			InitializeComponent();
			PopulateTreeView("C:\\VC 2023\\Semester 6\\PROG\\CallNumbers.txt");

		}

		private void FindCallNumber_Load(object sender, EventArgs e)
		{
			RandomizeQuestionLevel1();
			Level1Options();
			Level2Options();
		}

		private void PopulateTreeView(string filePath)
		{
			if (File.Exists(filePath))
			{
				treeView.Nodes.Clear();

				Dictionary<string, TreeNode> level2Nodes = new Dictionary<string, TreeNode>();
				Dictionary<string, TreeNode> level3Nodes = new Dictionary<string, TreeNode>();

				foreach (string line in File.ReadLines(filePath))
				{
					string[] seperatedParts = line.Split(',');
					if (seperatedParts.Length == 2)
					{
						string level = seperatedParts[0];
						string description = seperatedParts[1];

						TreeNode node = new TreeNode(description);

						if (level.StartsWith("Level1"))
						{
							treeView.Nodes.Add(node);
						}
						else if (level.StartsWith("Level2"))
						{
							string parentKey = level.Substring(0, 6);
							if (level2Nodes.ContainsKey(parentKey))
							{
								level2Nodes[parentKey].Nodes.Add(node);
							}
							else
							{
								TreeNode parentNode = new TreeNode(parentKey);
								treeView.Nodes.Add(parentNode);
								level2Nodes.Add(parentKey, parentNode);
								parentNode.Nodes.Add(node);
							}
						}
						else if (level.StartsWith("Level3"))
						{
							string parentKey = level.Substring(0, 6);
							if (level3Nodes.ContainsKey(parentKey))
							{
								level3Nodes[parentKey].Nodes.Add(node);
							}
							else
							{
								string grandparentKey = parentKey.Substring(0, 6);
								if (level2Nodes.ContainsKey(grandparentKey))
								{
									level2Nodes[grandparentKey].Nodes.Add(node);
								}
								else
								{
									TreeNode grandparentNode = new TreeNode(grandparentKey);
									treeView.Nodes.Add(grandparentNode);
									level2Nodes.Add(grandparentKey, grandparentNode);
									grandparentNode.Nodes.Add(node);
								}

								level3Nodes.Add(parentKey, node);
							}
						}
					}
				}
			}
			else
			{
				MessageBox.Show("File not found in file path: " + filePath);
			}


		}

		private void RandomizeQuestionLevel1()
		{
			List<string> thirdLevelDescriptions = new List<string>();

			foreach (TreeNode grandparentNode in treeView.Nodes)
			{
				foreach (TreeNode parentNode in grandparentNode.Nodes)
				{
					foreach (TreeNode thirdLevelNode in parentNode.Nodes)
					{
						// Assuming the description is separated from the call number by a dot
						string[] parts = thirdLevelNode.Text.Split(' ');
						if (parts.Length > 1)
						{
							// Get the description
							string description1 = parts[2].Trim();
							thirdLevelDescriptions.Add(description1 + " ");
						}
					}
				}
			}

			if (thirdLevelDescriptions.Count > 0)
			{
				Random random = new Random();
				string selectedDescription = thirdLevelDescriptions[random.Next(thirdLevelDescriptions.Count)];
				cmbLevel1Q.Text = selectedDescription;
				cmbLevel1Q.Items.Add(selectedDescription);
			}
			else
			{
				cmbLevel1Q.Text = "No third-level entries found.";
			}
		}

		private void Level1Options()
		{
			List<string> topLevels = new List<string>();

			foreach (TreeNode grandparentNode in treeView.Nodes)
			{
				// Include both call numbers and descriptions for top-level choices
				topLevels.Add(grandparentNode.Text);
			}

			if (topLevels.Count >= 4)
			{
				Random random = new Random();

				// Select one correct option
				string correctOption = topLevels[random.Next(topLevels.Count)];
				cmbLevel1A.Items.Add(correctOption);

				// Select three random incorrect options
				List<string> incorrectOptions = topLevels.Except(new[] { correctOption }).ToList();
				for (int i = 0; i < 3; i++)
				{
					string incorrectOption = incorrectOptions[random.Next(incorrectOptions.Count)];
					cmbLevel1A.Items.Add(incorrectOption);
					incorrectOptions.Remove(incorrectOption);
				}

				// Sorting combobox
				cmbLevel1A.Sorted = true;

				// Randomising options
				List<string> shuffledOptions = cmbLevel1A.Items.Cast<string>().OrderBy(x => random.Next()).ToList();

				//Clear combobox before adding items
				cmbLevel1A.Items.Clear();
				cmbLevel1A.Items.AddRange(shuffledOptions.ToArray());

				// Default selection
				cmbLevel1A.SelectedIndex = 0;
			}
			else
			{
				cmbLevel1A.Items.Add("Not enough top-level entries for multiple-choice options.");
				cmbLevel1A.SelectedIndex = 0;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			// Return to the main menu
			PROG7312_V1 actChoice = new PROG7312_V1();
			actChoice.Show();
			this.Close();
		}

		private void btnQRepopLevel1_Click(object sender, EventArgs e)
		{
			cmbLevel1Q.Items.Clear();
			RandomizeQuestionLevel1();
		}

		private int score = 0;

		private void cmbLevel1A_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnCheck1_Click(object sender, EventArgs e)
		{
			// Check for correct option
			string selectedOption = cmbLevel1A.SelectedItem.ToString();

			// Assuming the correct option is the first one (index 0)
			string correctOption = cmbLevel1A.Items[0].ToString();

			if (selectedOption == correctOption)
			{
				MessageBox.Show("Correct! You selected the right option.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				// Increment the score
				score++;
				lblScore.Text = score.ToString();
				lblLevel2.Visible = true;
				cmbLevel2A.Visible = true;
				btnRepopLevel2A.Visible = true;
			}
			else
			{
				MessageBox.Show("Incorrect! Please try again.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				score--;
				lblScore.Text = score.ToString();
			}
		}

		/*// Check if the value in cmbLevel1A corresponds with cmbLevel1Q
		if (cmbLevel1Q.SelectedItem != null && cmbLevel1A.SelectedItem != null)
		{
			string selectedValueA = cmbLevel1A.SelectedItem.ToString();
			string selectedValueQ = cmbLevel1Q.SelectedItem.ToString();

			// Assuming the call numbers are separated from descriptions by a space
			string callNumberA = GetFirstDigitOfCallNumber(selectedValueA);
			string callNumberQ = GetFirstDigitOfCallNumber(selectedValueQ);

			if (callNumberA == callNumberQ)
			{
				MessageBox.Show("Correct! The selected values match.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Incorrect! The selected values do not match.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

	private string GetFirstDigitOfCallNumber(string value)
	{
		// Extract the call number and return its first digit
		string[] parts = value.Split(' ');
		if (parts.Length > 0 && !string.IsNullOrEmpty(parts[0]))
		{
			return parts[0][0].ToString();
		}
		return null; // Return null if the call number is not found or is empty
	}*/

		private void btnRepopL1A_Click(object sender, EventArgs e)
		{
			cmbLevel1A.Items.Clear();
			Level1Options();
			lblLevel2.Visible = false;
			cmbLevel2A.Visible = false;
			btnRepopLevel2A.Visible = false;
		}

		private void Level2Options()
		{
			List<string> level2Options = GetLevel2Options();

			if (level2Options.Count >= 4)
			{
				Random random = new Random();

				// Select one correct option
				string correctOption = level2Options[random.Next(level2Options.Count)];
				cmbLevel2A.Items.Add(correctOption);

				// Select three random incorrect options
				List<string> incorrectOptions = level2Options.Except(new[] { correctOption }).ToList();
				for (int i = 0; i < 3; i++)
				{
					string incorrectOption = incorrectOptions[random.Next(incorrectOptions.Count)];
					cmbLevel2A.Items.Add(incorrectOption);
					incorrectOptions.Remove(incorrectOption);
				}

				// Shuffle the options
				List<string> shuffledOptions = cmbLevel2A.Items.Cast<string>().OrderBy(x => random.Next()).ToList();
				cmbLevel2A.Items.Clear();
				cmbLevel2A.Items.AddRange(shuffledOptions.ToArray());

				// Select the first option by default
				cmbLevel2A.SelectedIndex = 0;
			}
			else
			{
				cmbLevel2A.Items.Add("Not enough level 2 options found.");
				cmbLevel2A.SelectedIndex = 0;
			}
		}

		private List<string> GetLevel2Options()
		{
			List<string> level2Options = new List<string>();

			foreach (TreeNode grandparentNode in treeView.Nodes)
			{
				foreach (TreeNode parentNode in grandparentNode.Nodes)
				{
					// Assuming the Level 2 option has both call numbers and descriptions
					level2Options.Add(parentNode.Text);
				}
			}

			return level2Options;
		}

		private void btnRepopLevel2A_Click(object sender, EventArgs e)
		{
			cmbLevel2A.Items.Clear();
			Level2Options();
		}
	}

}
