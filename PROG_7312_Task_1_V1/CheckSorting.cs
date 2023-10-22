using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_7312_Task_1_V1
{
	internal class CheckSorting
	{
		public static bool SortCheck(ListBox listBox)
		{
			for (int i = 1; i < listBox.Items.Count; i++)
			{
				if (string.Compare(listBox.Items[i - 1].ToString(), listBox.Items[i].ToString(), StringComparison.Ordinal) > 0)
				{
					return false;
				}
			}
			return true;
		}
		public static void PointInc(Label label)
		{
			int currentValue = int.Parse(label.Text);
			currentValue++;
			label.Text = currentValue.ToString();
		}

		public static void PointDec(Label label)
		{
			int currentValue = int.Parse(label.Text);
			currentValue--;
			label.Text = currentValue.ToString();
		}
	}
}
