using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace PROG_7312_Task_1_V1
{
	public static class MatchingItemsChecker
	{
		public static bool EnsureMatchingItems(BindingList<KeyValuePair<string, string>> leftDataSource, BindingList<KeyValuePair<string, string>> rightDataSource)
		{
			while (!HasMatchingItems(leftDataSource, rightDataSource))
			{
				// Repopulate dgvLeft and dvgValues
				RepopulateDataGridViews(leftDataSource, rightDataSource);
			}

			return true;
		}

		public static bool HasMatchingItems(BindingList<KeyValuePair<string, string>> leftDataSource, BindingList<KeyValuePair<string, string>> rightDataSource)
		{
			// Check if there is at least one matching item
			foreach (KeyValuePair<string, string> leftItem in leftDataSource)
			{
				foreach (KeyValuePair<string, string> rightItem in rightDataSource)
				{
					if (leftItem.Key == rightItem.Key && leftItem.Value == rightItem.Value)
					{
						return true; // Matching item found
					}
				}
			}
			return false; // No matching item found
		}

		private static void RepopulateDataGridViews(BindingList<KeyValuePair<string, string>> leftDataSource, BindingList<KeyValuePair<string, string>> rightDataSource)
		{
			// Shuffle and repopulate the BindingLists
			List<KeyValuePair<string, string>> matchingPairs = new List<KeyValuePair<string, string>>(leftDataSource.Concat(rightDataSource));
			ShuffleList.ShuffleListItems(leftDataSource);

			leftDataSource.Clear();
			rightDataSource.Clear();

			for (int i = 0; i < 4; i++)
			{
				leftDataSource.Add(matchingPairs[i]);
			}

			for (int i = 4; i < 11; i++)
			{
				rightDataSource.Add(matchingPairs[i]);
			}
		}
	}
}


