using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PROG_7312_Task_1_V1
{
	public class DataGridViewManager
	{
		public BindingList<KeyValuePair<string, string>> LeftDataSource { get; private set; }
		public BindingList<KeyValuePair<string, string>> RightDataSource { get; private set; }

		public DataGridViewManager(Dictionary<string, string> data, DataGridView leftDataGridView, DataGridView rightDataGridView)
		{
			LeftDataSource = new BindingList<KeyValuePair<string, string>>(data.ToList());
			RightDataSource = new BindingList<KeyValuePair<string, string>>(data.ToList());

			ShuffleListItems(LeftDataSource);
			ShuffleListItems(RightDataSource);

			LeftDataSource = new BindingList<KeyValuePair<string, string>>(LeftDataSource.Take(4).ToList());
			RightDataSource = new BindingList<KeyValuePair<string, string>>(RightDataSource.Take(7).ToList());

			leftDataGridView.DataSource = LeftDataSource;
			rightDataGridView.DataSource = RightDataSource;

			// Set the visibility of columns
			leftDataGridView.Columns["Key"].Visible = true;
			leftDataGridView.Columns["Value"].Visible = false;
			rightDataGridView.Columns["Key"].Visible = false;
			rightDataGridView.Columns["Value"].Visible = true;
		}

		private void ShuffleListItems<T>(BindingList<T> list)
		{
			Random rand = new Random();
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rand.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}
	}
}
