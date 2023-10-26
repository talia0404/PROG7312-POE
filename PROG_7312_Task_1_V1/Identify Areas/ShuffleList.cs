using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PROG_7312_Task_1_V1
{
	public static class ShuffleList

	{
		public static void ShuffleListItems<T>(BindingList<T> list)
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

