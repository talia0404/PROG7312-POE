using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PROG_7312_Task_1_V1
{
	public static class MatchingItemsChecker
	{
		public static void EnsureMatchingItems(BindingList<KeyValuePair<string, string>> leftDataSource, BindingList<KeyValuePair<string, string>> rightDataSource,
			 Dictionary<string, string> deweyCategories)
		{
			while (HasMatchingItems(leftDataSource, rightDataSource)==false)
			{
				// Repopulate dgvLeft and dvgValues
				RepopulateDataGridViews(leftDataSource, rightDataSource, deweyCategories);
			}
		}

		public static bool HasMatchingItems(BindingList<KeyValuePair<string, string>> leftDataSource, BindingList<KeyValuePair<string, string>> rightDataSource)
		{
			
			if (leftDataSource.Count != rightDataSource.Count)
			{
				return false; // If the counts are not the same, there cannot be a full match.
			}

			foreach (KeyValuePair<string, string> leftItem in leftDataSource)
			{
				if (!rightDataSource.Any(rightItem => leftItem.Key == rightItem.Key && leftItem.Value == rightItem.Value))
				{
					return false; // At least one left item does not have a matching item in rightDataSource.
				}
			}

			return true; // All left items have matching items in rightDataSource.
		}

		private static void RepopulateDataGridViews(BindingList<KeyValuePair<string, string>> leftDataSource, 
			BindingList<KeyValuePair<string, string>> rightDataSource, 
			Dictionary<string, string> deweyCategories)
		{
			leftDataSource.Clear();
			rightDataSource.Clear();

			List<KeyValuePair<string, string>> matchingItems = new List<KeyValuePair<string, string>>();

			// Create a list of matching items based on the dictionary
			foreach (var item in leftDataSource)
			{
				if (deweyCategories.TryGetValue(item.Key, out var category))
				{
					matchingItems.Add(new KeyValuePair<string, string>(item.Key, category));
				}
			}

			// Shuffle the matching items
			ShuffleList.ShuffleListItems(leftDataSource);

			

			// Add matching items to both DataGridViews
			for (int i = 0; i < 5; i++)
			{
				leftDataSource.Add(matchingItems[i]);
			}

			for (int i = 0; i < 8; i++)
			{
				rightDataSource.Add(matchingItems[i]);
			}
		}

	}

	}
