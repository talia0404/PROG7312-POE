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
	public partial class FindCallNumber : Form
	{

		public FindCallNumber()
		{
			InitializeComponent();
			PopulateTreeView("C:\\VC 2023\\Semester 6\\PROG\\CallNumbers.txt");

		}

		private void FindCallNumber_Load(object sender, EventArgs e)
		{
			// Specify the file path
			//string filePath = "C:\\VC 2023\\Semester 6\\PROG\\CallNumbers.txt";
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

		private void btnBack_Click(object sender, EventArgs e)
		{
			// Return to the main menu
			PROG7312_V1 actChoice = new PROG7312_V1();
			actChoice.Show();
			this.Close();
		}

	}

}
