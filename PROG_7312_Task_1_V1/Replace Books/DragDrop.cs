using System;
using System.Windows.Forms;

public class DragDrop
{
	private ListBox listBox;
	private string draggedItem = null;

	public DragDrop(ListBox listBox)
	{
		this.listBox = listBox;
		this.listBox.MouseDown += new MouseEventHandler(lbxDisplay_MouseDown);
		this.listBox.DragEnter += new DragEventHandler(lbxDisplay_DragEnter);
		this.listBox.DragDrop += new DragEventHandler(lbxDisplay_DragDrop);
	}

	private void lbxDisplay_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			int index = listBox.IndexFromPoint(e.X, e.Y);
			if (index != ListBox.NoMatches)
			{
				draggedItem = listBox.Items[index].ToString();
				listBox.DoDragDrop(draggedItem, DragDropEffects.Move);
			}
		}
	}

	private void lbxDisplay_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.StringFormat))
		{
			e.Effect = DragDropEffects.Move;
		}
	}

	private void lbxDisplay_DragDrop(object sender, DragEventArgs e)
	{
		int index = listBox.IndexFromPoint(listBox.PointToClient(new System.Drawing.Point(e.X, e.Y)));
		if (index != ListBox.NoMatches)
		{
			listBox.Items.Insert(index, draggedItem);
			listBox.Items.Remove(draggedItem);
			draggedItem = null;
		}
	}
}

