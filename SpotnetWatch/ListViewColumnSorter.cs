using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SpotnetWatch
{
	public class ListViewColumnSorter : IComparer
	{
		private int ColumnToSort;

		private SortOrder OrderOfSort;

		private CaseInsensitiveComparer ObjectCompare;

		public int SortColumn
		{
			get
			{
				return ColumnToSort;
			}
			set
			{
				ColumnToSort = value;
			}
		}

		public SortOrder Order
		{
			get
			{
				return OrderOfSort;
			}
			set
			{
				OrderOfSort = value;
			}
		}

		public ListViewColumnSorter()
		{
			ColumnToSort = 0;
			OrderOfSort = SortOrder.None;
			ObjectCompare = new CaseInsensitiveComparer();
		}

		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			int num = ((ColumnToSort != 4) ? ObjectCompare.Compare(listViewItem.SubItems[ColumnToSort].Text, listViewItem2.SubItems[ColumnToSort].Text) : ObjectCompare.Compare(Conversions.ToDate(listViewItem.SubItems[ColumnToSort].Text), Conversions.ToDate(listViewItem2.SubItems[ColumnToSort].Text)));
			if (OrderOfSort == SortOrder.Ascending)
			{
				return num;
			}
			if (OrderOfSort == SortOrder.Descending)
			{
				return checked(-num);
			}
			return 0;
		}

		int IComparer.Compare(object x, object y)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Compare
			return this.Compare(x, y);
		}
	}
}
