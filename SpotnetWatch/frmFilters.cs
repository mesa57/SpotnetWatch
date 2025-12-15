using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SpotnetWatch
{
	[DesignerGenerated]
	public partial class frmFilters : Form
	{

		public frmFilters()
		{
			base.Activated += frmFilters_Activated;
			base.FormClosing += frmFilters_FormClosing;
			base.Load += frmFilters_Load;
			InitializeComponent();
			lvwColumnSorter = new ListViewColumnSorter();
			lstFilters.ListViewItemSorter = lvwColumnSorter;
		}

		private void frmFilters_Activated(object sender, EventArgs e)
		{
			TopMost = appModule.APP_ON_TOP;
		}

		private void frmFilters_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		private void frmFilters_Load(object sender, EventArgs e)
		{
			if (!loadFilterFile(lstFilters))
			{
				MessageBox.Show("Het laden van het filter bestand " + appModule.PATH_FILTER_FILE + " is mislukt.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			loadCategories();
			frmDisable();
		}

		private void btnVerwijderen_Click(object sender, EventArgs e)
		{
			if (lstFilters.SelectedItems.Count <= 0)
			{
				return;
			}
			DialogResult dialogResult = MessageBox.Show("Weet u zeker dat het geselecteerde filter verwijderd kan worden?", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult != DialogResult.Yes)
			{
				return;
			}
			foreach (ListViewItem selectedItem in lstFilters.SelectedItems)
			{
				selectedItem.Remove();
			}
		}

		private void btnToevoegen_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem("NIEUW FILTER");
			listViewItem.BackColor = Color.Yellow;
			lstFilters.Items.Add(listViewItem).Tag = "NIEUW FILTER||0|+++||";
		}

		private void btnOpslaan_Click(object sender, EventArgs e)
		{
			if (!saveFilterFile(lstFilters))
			{
				MessageBox.Show("Het opslaan van het filter bestand is mislukt.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (appModule.APP_SCAN_ON_FILTER_EXIT)
			{
				appModule.APP_LAST_SCAN = Conversions.ToDate("01-01-1900 00:00:00");
			}
			Dispose();
		}

		private void btnAnnuleren_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void lstFilters_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == lvwColumnSorter.SortColumn)
			{
				if (lvwColumnSorter.Order == SortOrder.Ascending)
				{
					lvwColumnSorter.Order = SortOrder.Descending;
				}
				else
				{
					lvwColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				lvwColumnSorter.SortColumn = e.Column;
				lvwColumnSorter.Order = SortOrder.Ascending;
			}
			lstFilters.Sort();
		}

		private void lstFilters_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				btnVerwijderen_Click(null, null);
			}
		}

		private void lstFilters_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstFilters.SelectedItems.Count > 0)
			{
				frmEnable();
				frmReset();
				lstFilters.FocusedItem.BackColor = Color.White;
				string text = Conversions.ToString(lstFilters.Items[lstFilters.FocusedItem.Index].Tag);
				string[] array = text.Split('|');
				txtFilterNaam.Text = array[0];
				txtFilterText.Text = array[1];
				chkFilterOptie.CheckState = (CheckState)Conversions.ToInteger(array[2]);
				string[] array2 = array[3].Split(',');
				txtFilterSpotter.Text = array[4];
				txtFilterTag.Text = array[5];
				int lowerBound = array2.GetLowerBound(0);
				int upperBound = array2.GetUpperBound(0);
				for (int i = lowerBound; i <= upperBound; i = checked(i + 1))
				{
					string left = array2[i];
					if (Operators.CompareString(left, Conversions.ToString(100), false) >= 0 && Operators.CompareString(left, Conversions.ToString(110), false) <= 0)
					{
						foreach (ListViewItem item in lstFiltersBeeld.Items)
						{
							if (Operators.CompareString(lstFiltersBeeld.Items[item.Index].Tag.ToString(), array2[i].ToString(), false) == 0)
							{
								item.Checked = true;
							}
						}
					}
					else if (Operators.CompareString(left, Conversions.ToString(200), false) >= 0 && Operators.CompareString(left, Conversions.ToString(208), false) <= 0)
					{
						foreach (ListViewItem item2 in lstFiltersMuziek.Items)
						{
							if (Operators.CompareString(lstFiltersMuziek.Items[item2.Index].Tag.ToString(), array2[i].ToString(), false) == 0)
							{
								item2.Checked = true;
							}
						}
					}
					else if (Operators.CompareString(left, Conversions.ToString(300), false) >= 0 && Operators.CompareString(left, Conversions.ToString(315), false) <= 0)
					{
						foreach (ListViewItem item3 in lstFiltersSpellen.Items)
						{
							if (Operators.CompareString(lstFiltersSpellen.Items[item3.Index].Tag.ToString(), array2[i].ToString(), false) == 0)
							{
								item3.Checked = true;
							}
						}
					}
					else if (Operators.CompareString(left, Conversions.ToString(400), false) >= 0 && Operators.CompareString(left, Conversions.ToString(407), false) <= 0)
					{
						foreach (ListViewItem item4 in lstFiltersSoftware.Items)
						{
							if (Operators.CompareString(lstFiltersSoftware.Items[item4.Index].Tag.ToString(), array2[i].ToString(), false) == 0)
							{
								item4.Checked = true;
							}
						}
					}
					else if (Operators.CompareString(left, Conversions.ToString(500), false) >= 0 && Operators.CompareString(left, Conversions.ToString(505), false) <= 0)
					{
						foreach (ListViewItem item5 in lstFiltersBoeken.Items)
						{
							if (Operators.CompareString(lstFiltersBoeken.Items[item5.Index].Tag.ToString(), array2[i].ToString(), false) == 0)
							{
								item5.Checked = true;
							}
						}
					}
					else if (Operators.CompareString(left, Conversions.ToString(600), false) >= 0 && Operators.CompareString(left, Conversions.ToString(610), false) <= 0)
					{
						foreach (ListViewItem item6 in lstFiltersSeries.Items)
						{
							if (Operators.CompareString(lstFiltersSeries.Items[item6.Index].Tag.ToString(), array2[i].ToString(), false) == 0)
							{
								item6.Checked = true;
							}
						}
					}
					else
					{
						if (Operators.CompareString(left, Conversions.ToString(900), false) < 0 || Operators.CompareString(left, Conversions.ToString(903), false) > 0)
						{
							continue;
						}
						foreach (ListViewItem item7 in lstFiltersErotiek.Items)
						{
							if (Operators.CompareString(lstFiltersErotiek.Items[item7.Index].Tag.ToString(), array2[i].ToString(), false) == 0)
							{
								item7.Checked = true;
							}
						}
					}
				}
			}
			else
			{
				frmReset();
				frmDisable();
			}
		}

		private void frmReset()
		{
			txtFilterNaam.Text = string.Empty;
			txtFilterText.Text = string.Empty;
			txtFilterSpotter.Text = string.Empty;
			txtFilterTag.Text = string.Empty;
			chkFilterOptie.CheckState = CheckState.Unchecked;
			foreach (ListViewItem item in lstFiltersBeeld.Items)
			{
				item.Checked = false;
			}
			foreach (ListViewItem item2 in lstFiltersMuziek.Items)
			{
				item2.Checked = false;
			}
			foreach (ListViewItem item3 in lstFiltersSpellen.Items)
			{
				item3.Checked = false;
			}
			foreach (ListViewItem item4 in lstFiltersSoftware.Items)
			{
				item4.Checked = false;
			}
			foreach (ListViewItem item5 in lstFiltersSeries.Items)
			{
				item5.Checked = false;
			}
			foreach (ListViewItem item6 in lstFiltersBoeken.Items)
			{
				item6.Checked = false;
			}
			foreach (ListViewItem item7 in lstFiltersErotiek.Items)
			{
				item7.Checked = false;
			}
		}

		private void loadCategories()
		{
			clsApplication clsApplication2 = new clsApplication();
			lstFiltersBeeld.Items.Clear();
			int num = 100;
			checked
			{
				do
				{
					ListViewItem value = new ListViewItem(clsApplication2.subCatToName(num).ToString(), imgList.Images.IndexOfKey(num.ToString()));
					lstFiltersBeeld.Items.Add(value).Tag = num.ToString();
					num++;
				}
				while (num <= 110);
				lstFiltersMuziek.Items.Clear();
				int num2 = 200;
				do
				{
					ListViewItem value2 = new ListViewItem(clsApplication2.subCatToName(num2).ToString(), imgList.Images.IndexOfKey(num2.ToString()));
					lstFiltersMuziek.Items.Add(value2).Tag = num2.ToString();
					num2++;
				}
				while (num2 <= 208);
				lstFiltersSpellen.Items.Clear();
				int num3 = 300;
				do
				{
					ListViewItem value3 = new ListViewItem(clsApplication2.subCatToName(num3).ToString(), imgList.Images.IndexOfKey(num3.ToString()));
					lstFiltersSpellen.Items.Add(value3).Tag = num3.ToString();
					num3++;
				}
				while (num3 <= 315);
				lstFiltersSoftware.Items.Clear();
				int num4 = 400;
				do
				{
					ListViewItem value4 = new ListViewItem(clsApplication2.subCatToName(num4).ToString(), imgList.Images.IndexOfKey(num4.ToString()));
					lstFiltersSoftware.Items.Add(value4).Tag = num4.ToString();
					num4++;
				}
				while (num4 <= 407);
				lstFiltersBoeken.Items.Clear();
				int num5 = 500;
				do
				{
					ListViewItem value5 = new ListViewItem(clsApplication2.subCatToName(num5).ToString(), imgList.Images.IndexOfKey(num5.ToString()));
					lstFiltersBoeken.Items.Add(value5).Tag = num5.ToString();
					num5 += 5;
				}
				while (num5 <= 505);
				lstFiltersSeries.Items.Clear();
				int num6 = 600;
				do
				{
					ListViewItem value6 = new ListViewItem(clsApplication2.subCatToName(num6).ToString(), imgList.Images.IndexOfKey(num6.ToString()));
					lstFiltersSeries.Items.Add(value6).Tag = num6.ToString();
					num6++;
				}
				while (num6 <= 610);
				lstFiltersErotiek.Items.Clear();
				int num7 = 900;
				do
				{
					ListViewItem value7 = new ListViewItem(clsApplication2.subCatToName(num7).ToString(), imgList.Images.IndexOfKey(num7.ToString()));
					lstFiltersErotiek.Items.Add(value7).Tag = num7.ToString();
					num7++;
				}
				while (num7 <= 903);
			}
		}

		private bool loadFilterFile(ListView lstView)
		{
			bool result;
			try
			{
				if (File.Exists(appModule.PATH_FILTER_FILE))
				{
					lstView.Items.Clear();
					string[] array = File.ReadAllLines(appModule.PATH_FILTER_FILE);
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i = checked(i + 1))
					{
						string text = array2[i];
						text = text.Trim();
						if (text.StartsWith("[") & text.EndsWith("]"))
						{
							text = text.Replace("[", string.Empty);
							text = text.Replace("]", string.Empty);
							string[] array3 = text.Split('|');
							ListViewItem value = new ListViewItem(array3[0]);
							lstView.Items.Add(value).Tag = text;
						}
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private bool saveFilterFile(ListView lstView)
		{
			bool result;
			try
			{
				StreamWriter streamWriter = new StreamWriter(appModule.PATH_FILTER_FILE);
				foreach (ListViewItem item in lstView.Items)
				{
					streamWriter.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject("[", item.Tag), "]"));
				}
				streamWriter.Close();
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private void UpdateFilter()
		{
			if (lstFilters.SelectedItems.Count <= 0)
			{
				return;
			}
			string text = txtFilterNaam.Text.Trim();
			string text2 = txtFilterText.Text.Trim();
			string text3 = txtFilterSpotter.Text.Trim();
			string text4 = txtFilterTag.Text.Trim();
			string text5 = Conversions.ToString((int)chkFilterOptie.CheckState);
			string text6 = string.Empty;
			foreach (ListViewItem checkedItem in lstFiltersBeeld.CheckedItems)
			{
				text6 = Conversions.ToString(Operators.AddObject(text6, Operators.ConcatenateObject(checkedItem.Tag, ",")));
			}
			foreach (ListViewItem checkedItem2 in lstFiltersMuziek.CheckedItems)
			{
				text6 = Conversions.ToString(Operators.AddObject(text6, Operators.ConcatenateObject(checkedItem2.Tag, ",")));
			}
			foreach (ListViewItem checkedItem3 in lstFiltersSpellen.CheckedItems)
			{
				text6 = Conversions.ToString(Operators.AddObject(text6, Operators.ConcatenateObject(checkedItem3.Tag, ",")));
			}
			foreach (ListViewItem checkedItem4 in lstFiltersSoftware.CheckedItems)
			{
				text6 = Conversions.ToString(Operators.AddObject(text6, Operators.ConcatenateObject(checkedItem4.Tag, ",")));
			}
			foreach (ListViewItem checkedItem5 in lstFiltersSeries.CheckedItems)
			{
				text6 = Conversions.ToString(Operators.AddObject(text6, Operators.ConcatenateObject(checkedItem5.Tag, ",")));
			}
			foreach (ListViewItem checkedItem6 in lstFiltersBoeken.CheckedItems)
			{
				text6 = Conversions.ToString(Operators.AddObject(text6, Operators.ConcatenateObject(checkedItem6.Tag, ",")));
			}
			foreach (ListViewItem checkedItem7 in lstFiltersErotiek.CheckedItems)
			{
				text6 = Conversions.ToString(Operators.AddObject(text6, Operators.ConcatenateObject(checkedItem7.Tag, ",")));
			}
			clsApplication clsApplication2 = new clsApplication();
			lstFilters.Items[lstFilters.FocusedItem.Index].Text = text;
			lstFilters.Items[lstFilters.FocusedItem.Index].Tag = text + "|" + text2 + "|" + text5 + "|" + clsApplication2.kortIN(text6, 1) + "|" + text3 + "|" + text4;
		}

		private void frmEnable()
		{
			txtFilterNaam.Enabled = true;
			txtFilterText.Enabled = true;
			txtFilterSpotter.Enabled = true;
			txtFilterTag.Enabled = true;
			chkFilterOptie.Enabled = true;
			lstFiltersBeeld.Enabled = true;
			lstFiltersMuziek.Enabled = true;
			lstFiltersSoftware.Enabled = true;
			lstFiltersSpellen.Enabled = true;
			lstFiltersBoeken.Enabled = true;
			lstFiltersErotiek.Enabled = true;
			lstFiltersSeries.Enabled = true;
		}

		private void frmDisable()
		{
			txtFilterNaam.Enabled = false;
			txtFilterText.Enabled = false;
			txtFilterSpotter.Enabled = false;
			txtFilterTag.Enabled = false;
			chkFilterOptie.Enabled = false;
			lstFiltersBeeld.Enabled = false;
			lstFiltersMuziek.Enabled = false;
			lstFiltersSoftware.Enabled = false;
			lstFiltersSpellen.Enabled = false;
			lstFiltersBoeken.Enabled = false;
			lstFiltersErotiek.Enabled = false;
			lstFiltersSeries.Enabled = false;
		}

		private void txtFilterNaam_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void txtFilterNaam_Validating(object sender, CancelEventArgs e)
		{
			clsSQL clsSQL2 = new clsSQL();
			if ((Operators.CompareString(txtFilterNaam.Text.Trim(), string.Empty, false) == 0) | clsSQL2.SQLInjection(txtFilterNaam.Text.Trim()))
			{
				MessageBox.Show("De invoer 'Filter naam' is ongeldig. Gebruik alleen letters en getallen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				e.Cancel = true;
				txtFilterNaam.Select(0, txtFilterNaam.Text.Length);
			}
		}

		private void txtFilterText_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void txtFilterText_Validating(object sender, CancelEventArgs e)
		{
			if (Operators.CompareString(txtFilterText.Text.Trim(), string.Empty, false) != 0)
			{
				clsSQL clsSQL2 = new clsSQL();
				if (clsSQL2.SQLInjection(txtFilterText.Text.Trim()))
				{
					MessageBox.Show("De invoer 'Zoek in titel' is ongeldig. Gebruik alleen letters en getallen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					e.Cancel = true;
					txtFilterText.Select(0, txtFilterText.Text.Length);
				}
			}
		}

		private void txtFilterSpotter_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void txtFilterSpotter_Validating(object sender, CancelEventArgs e)
		{
			if (Operators.CompareString(txtFilterSpotter.Text.Trim(), string.Empty, false) != 0)
			{
				clsSQL clsSQL2 = new clsSQL();
				if (clsSQL2.SQLInjection(txtFilterSpotter.Text.Trim()))
				{
					MessageBox.Show("De invoer 'Zoek in afzender' is ongeldig. Gebruik alleen letters en getallen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					e.Cancel = true;
					txtFilterSpotter.Select(0, txtFilterSpotter.Text.Length);
				}
			}
		}

		private void txtFilterTag_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void txtFilterTag_Validating(object sender, CancelEventArgs e)
		{
			if (Operators.CompareString(txtFilterTag.Text.Trim(), string.Empty, false) != 0)
			{
				clsSQL clsSQL2 = new clsSQL();
				if (clsSQL2.SQLInjection(txtFilterTag.Text.Trim()))
				{
					MessageBox.Show("De invoer 'Zoek in tag' is ongeldig. Gebruik alleen letters en getallen.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					e.Cancel = true;
					txtFilterTag.Select(0, txtFilterTag.Text.Length);
				}
			}
		}

		private void chkFilterOptie_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void lstFiltersBeeld_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void lstFiltersSoftware_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void lstFiltersSeries_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void lstFiltersErotiek_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void lstFiltersMuziek_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void lstFiltersBoeken_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}

		private void lstFiltersSpellen_Validated(object sender, EventArgs e)
		{
			UpdateFilter();
		}
	}
}
