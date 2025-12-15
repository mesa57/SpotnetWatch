using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SpotnetWatch.My;

namespace SpotnetWatch
{
	[DesignerGenerated]
	public partial class frmMain : Form
	{

		public frmMain()
		{
			base.Load += frmMain_Load;
			base.Shown += frmMain_Shown;
			base.Activated += frmMain_Activated;
			base.Disposed += frmMain_Disposed;
			base.FormClosing += frmMain_FormClosing;
			base.ResizeEnd += frmMain_ResizeEnd;
			InitializeComponent();
			lvwColumnSorter = new ListViewColumnSorter();
			lstSpots.ListViewItemSorter = lvwColumnSorter;
		}

		private void showForm()
		{
			WindowState = FormWindowState.Normal;
			ShowInTaskbar = true;
			Show();
			Refresh();
			Activate();
		}

		private void hideForm()
		{
			WindowState = FormWindowState.Minimized;
			ShowInTaskbar = false;
			Hide();
		}

		private void frmMain_Activated(object sender, EventArgs e)
		{
			TopMost = appModule.APP_ON_TOP;
		}

		private void frmMain_Disposed(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason != CloseReason.ApplicationExitCall)
			{
				e.Cancel = true;
				hideForm();
			}
		}

		private void frmMain_ResizeEnd(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				appModule.APP_SIZE = Strings.Split(Conversions.ToString(Left) + "," + Conversions.ToString(Top) + "," + Conversions.ToString(Width) + "," + Conversions.ToString(Height), ",");
				Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_SIZE", appModule.APP_SIZE.GetValue(0).ToString() + "," + appModule.APP_SIZE.GetValue(1).ToString() + "," + appModule.APP_SIZE.GetValue(2).ToString() + "," + appModule.APP_SIZE.GetValue(3).ToString());
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			FilterDefaults.EnsureFilterFile();
			Control.CheckForIllegalCrossThreadCalls = false;
			if (appModule.APP_START_IN_SYSTRAY)
			{
				hideForm();
			}
			else
			{
				showForm();
			}
			Left = Conversions.ToInteger(NewLateBinding.LateIndexGet(appModule.APP_SIZE, new object[1] { 0 }, null));
			Top = Conversions.ToInteger(NewLateBinding.LateIndexGet(appModule.APP_SIZE, new object[1] { 1 }, null));
			Width = Conversions.ToInteger(NewLateBinding.LateIndexGet(appModule.APP_SIZE, new object[1] { 2 }, null));
			Height = Conversions.ToInteger(NewLateBinding.LateIndexGet(appModule.APP_SIZE, new object[1] { 3 }, null));
			Text = appModule.APP_TITLE;
			lstSpots.GridLines = appModule.APP_GRID_LINES;
			systrayIcon.Text = appModule.APP_TITLE;
			if ((Operators.CompareString(appModule.APP_SABNZBD_SERVER, "http://sabnzbd_server", false) != 0) & (appModule.APP_SABNZBD_APIKEY.Length > 0))
			{
				rbm_lstSpots_Download.Enabled = true;
			}
			else
			{
				rbm_lstSpots_Download.Enabled = false;
			}
			clsApplication clsApplication2 = new clsApplication();
			if (!clsApplication2.loadOLDSpots())
			{
				StreamWriter streamWriter = new StreamWriter(appModule.PATH_OLD_SPOT_FILE);
				streamWriter.Close();
			}
		}

		private void frmMain_Shown(object sender, EventArgs e)
		{
			if (File.Exists(appModule.PATH_SPOT_DATABASE))
			{
				if (appModule.APP_MONITOR_DATABASE)
				{
					tsMenu_Bestand_Monitor.Checked = true;
					tmrDBWatch.Enabled = true;
				}
				else
				{
					tsMenu_Bestand_Monitor.Checked = false;
					tmrDBWatch.Enabled = false;
				}
				return;
			}
			showForm();
			switch (MessageBox.Show("De Spotnet database is nog niet ingesteld. Wilt u deze automatisch opzoeken? Kies Nee om de Spotnet database handmatig op te zoeken.", "Vraag", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
			{
			case DialogResult.Yes:
				if (getDBAuto())
				{
					Interaction.SaveSetting(Application.ProductName, "Instellingen", "PATH_SPOT_DATABASE", appModule.PATH_SPOT_DATABASE);
					MessageBox.Show("De Spotnet database is gevonden en ingesteld.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					appModule.PATH_SPOT_DATABASE = string.Empty;
					MessageBox.Show("De Spotnet database kon niet worden ingesteld.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Application.Exit();
				}
				break;
			case DialogResult.No:
				if (getDBHandmatig())
				{
					Interaction.SaveSetting(Application.ProductName, "Instellingen", "PATH_SPOT_DATABASE", appModule.PATH_SPOT_DATABASE);
					MessageBox.Show("De Spotnet database is gevonden en ingesteld.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					appModule.PATH_SPOT_DATABASE = string.Empty;
					MessageBox.Show("De Spotnet database kon niet worden ingesteld.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Application.Exit();
				}
				break;
			case DialogResult.Cancel:
				Application.Exit();
				break;
			}
		}

		private void lstSpots_ColumnClick(object sender, ColumnClickEventArgs e)
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
			lstSpots.Sort();
		}

		private void lstSpots_DoubleClick(object sender, EventArgs e)
		{
			if (lstSpots.SelectedItems.Count > 0)
			{
				string fileName = Conversions.ToString(Operators.ConcatenateObject(appModule.APP_NZB_SERVER, lstSpots.Items[lstSpots.FocusedItem.Index].Tag));
				Process.Start(fileName);
			}
		}

		private void bgDBScanner_DoWork(object sender, DoWorkEventArgs e)
		{
			bgDBScanner.ReportProgress(25, "Bezig met zoeken naar spots... even geduld a.u.b.");
			clsSQL clsSQL2 = new clsSQL();
			string text = clsSQL2.SQLBuilder();
			if (Operators.CompareString(text, string.Empty, false) == 0)
			{
				lstSpots.Items.Clear();
				bgDBScanner.ReportProgress(0, "Ongeldige database aanvraag... controleer de filters");
				return;
			}
            string input = appModule.PATH_SPOT_DATABASE;

            // Check if the input starts with a double backslash
            if (input.StartsWith("\\\\"))
            {
                // Prefix with an extra backslash
                input = "\\" + input;
            }

            string connectionString = "Data Source=" + input + ";Version=3;";
			SQLiteConnection sQLiteConnection = new SQLiteConnection(connectionString);
			try
			{
				if (sQLiteConnection.State == ConnectionState.Closed)
				{
					sQLiteConnection.Open();
				}
				SQLiteCommand sQLiteCommand = new SQLiteCommand(text, sQLiteConnection);
				SQLiteDataReader sQLiteDataReader = sQLiteCommand.ExecuteReader();
				bgDBScanner.ReportProgress(50, "Bezig met zoeken naar spots... even geduld a.u.b.");
				if (sQLiteDataReader.HasRows)
				{
					List<ListViewItem> list = new List<ListViewItem>();
					appModule.APP_NEW_SPOT_ARRAY.Clear();
					clsApplication clsApplication2 = new clsApplication();
					while (sQLiteDataReader.Read())
					{
						ListViewItem listViewItem = new ListViewItem();
						listViewItem.Text = sQLiteDataReader["subject"].ToString();
						listViewItem.ImageKey = sQLiteDataReader["subcat"].ToString();
						listViewItem.Tag = sQLiteDataReader["msgid"].ToString();
						listViewItem.ToolTipText = "Dubbel klikken om te openen";
						listViewItem.SubItems.Add(sQLiteDataReader["sender"].ToString());
						listViewItem.SubItems.Add(clsApplication2.catToName(Conversions.ToInteger(sQLiteDataReader["cat"].ToString())));
						listViewItem.SubItems.Add(clsApplication2.subCatToName(Conversions.ToInteger(sQLiteDataReader["subcat"].ToString())));
						listViewItem.SubItems.Add(clsApplication2.niceDate(Conversions.ToDate(clsApplication2.setTimeZone(Conversions.ToDate(clsApplication2.getSpotDate(Conversions.ToInteger(sQLiteDataReader["date"].ToString())))))));
						if (appModule.APP_OLD_SPOT_ARRAY.Contains(sQLiteDataReader["rowid"].ToString()))
						{
							list.Add(listViewItem);
							continue;
						}
						string left = sQLiteDataReader["cat"].ToString();
						if (Operators.CompareString(left, Conversions.ToString(1), false) == 0)
						{
							listViewItem.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT1.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT1.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT1.GetValue(2).ToString()));
						}
						else if (Operators.CompareString(left, Conversions.ToString(2), false) == 0)
						{
							listViewItem.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT2.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT2.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT2.GetValue(2).ToString()));
						}
						else if (Operators.CompareString(left, Conversions.ToString(3), false) == 0)
						{
							listViewItem.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT3.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT3.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT3.GetValue(2).ToString()));
						}
						else if (Operators.CompareString(left, Conversions.ToString(4), false) == 0)
						{
							listViewItem.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT4.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT4.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT4.GetValue(2).ToString()));
						}
						else if (Operators.CompareString(left, Conversions.ToString(5), false) == 0)
						{
							listViewItem.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT5.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT5.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT5.GetValue(2).ToString()));
						}
						else if (Operators.CompareString(left, Conversions.ToString(6), false) == 0)
						{
							listViewItem.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT6.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT6.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT6.GetValue(2).ToString()));
						}
						else if (Operators.CompareString(left, Conversions.ToString(9), false) == 0)
						{
							listViewItem.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT9.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT9.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT9.GetValue(2).ToString()));
						}
						list.Add(listViewItem);
						appModule.APP_NEW_SPOT_ARRAY.Add(sQLiteDataReader["rowid"].ToString());
					}
					sQLiteDataReader.Close();
					lstSpots.Items.Clear();
					bgDBScanner.ReportProgress(75, "Bezig met laden van spots... even geduld a.u.b.");
					lstSpots.Items.AddRange(list.ToArray());
					bgDBScanner.ReportProgress(100, "Bezig met laden van spots... even geduld a.u.b.");
					if (appModule.APP_COLUMN_AUTOSIZE)
					{
						lstSpots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
					}
					if (appModule.APP_REPORT_ONLY_NEW_SPOTS)
					{
						if (appModule.APP_NEW_SPOT_ARRAY.Count > 0)
						{
							systrayIcon.Icon = Icon.FromHandle(((Bitmap)iconList.Images[1]).GetHicon());
							systrayIcon.BalloonTipTitle = appModule.APP_TITLE;
							systrayIcon.BalloonTipText = appModule.APP_NEW_SPOT_ARRAY.Count + " nieuwe spots gevonden";
							systrayIcon.BalloonTipIcon = ToolTipIcon.Info;
							systrayIcon.Visible = true;
							systrayIcon.ShowBalloonTip(50000);
						}
					}
					else
					{
						systrayIcon.Icon = Icon.FromHandle(((Bitmap)iconList.Images[0]).GetHicon());
						systrayIcon.BalloonTipTitle = appModule.APP_TITLE;
						systrayIcon.BalloonTipText = appModule.APP_NEW_SPOT_ARRAY.Count + " nieuwe spots gevonden";
						systrayIcon.BalloonTipIcon = ToolTipIcon.Info;
						systrayIcon.Visible = true;
						systrayIcon.ShowBalloonTip(50000);
					}
					bgDBScanner.ReportProgress(0, "Gereed... " + Conversions.ToString(lstSpots.Items.Count) + " spots geladen waarvan " + appModule.APP_NEW_SPOT_ARRAY.Count + " nieuw");
				}
				else
				{
					lstSpots.Items.Clear();
					bgDBScanner.ReportProgress(0, "Gereed... geen gegevens gevonden in de database");
				}
			}
			catch (SQLiteException projectError) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(projectError);
				return Information.Err().Number == 5;
			}).Invoke())
			{
				bgDBScanner.ReportProgress(0, "Bezig met wachten op vrijgeven van database... sluit Spotnet af om dit mogelijk te maken");
				ProjectData.ClearProjectError();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				bgDBScanner.ReportProgress(0, "Er is een fout opgetreden");
				ProjectData.ClearProjectError();
			}
			finally
			{
				if (sQLiteConnection.State == ConnectionState.Open)
				{
					sQLiteConnection.Close();
				}
			}
		}

		private void bgDBScanner_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			barStatus_lbl1.Text = Conversions.ToString(e.UserState);
			barStatusProg.Value = e.ProgressPercentage;
		}

		private void bgDBScanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
		}

		private void tmrDBWatch_Tick(object sender, EventArgs e)
		{
			tmrDBWatch.Enabled = false;
			if (!bgDBScanner.IsBusy && File.Exists(appModule.PATH_SPOT_DATABASE))
			{
				DateTime lastWriteTime = File.GetLastWriteTime(appModule.PATH_SPOT_DATABASE);
				if (DateTime.Compare(lastWriteTime, appModule.APP_LAST_SCAN) != 0)
				{
					appModule.APP_LAST_SCAN = lastWriteTime;
					Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_LAST_SCAN", Conversions.ToString(appModule.APP_LAST_SCAN));
					bgDBScanner.RunWorkerAsync();
				}
			}
			tmrDBWatch.Enabled = true;
		}

		private void rbm_lstSpots_Openen_Click(object sender, EventArgs e)
		{
			if (lstSpots.SelectedItems.Count > 0)
			{
				string fileName = Conversions.ToString(Operators.ConcatenateObject(appModule.APP_NZB_SERVER, lstSpots.Items[lstSpots.FocusedItem.Index].Tag));
				Process.Start(fileName);
			}
		}

		private void rbm_lstSpots_Download_Click(object sender, EventArgs e)
		{
			if (lstSpots.SelectedItems.Count > 0)
			{
				MyProject.Forms.frmDownload.StartPosition = FormStartPosition.CenterParent;
				MyProject.Forms.frmDownload.ShowDialog();
			}
		}

		private void tsMenu_Bestand_Monitor_Click(object sender, EventArgs e)
		{
			if (tsMenu_Bestand_Monitor.Checked)
			{
				tmrDBWatch.Enabled = false;
				tsMenu_Bestand_Monitor.Checked = false;
				Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_MONITOR_DATABASE", Conversions.ToString(tsMenu_Bestand_Monitor.Checked));
			}
			else
			{
				tmrDBWatch.Enabled = true;
				tsMenu_Bestand_Monitor.Checked = true;
				Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_MONITOR_DATABASE", Conversions.ToString(tsMenu_Bestand_Monitor.Checked));
				appModule.APP_LAST_SCAN = Conversions.ToDate("01-01-1900 00:00:00");
			}
		}

		private void tsMenu_Bestand_Afsluiten_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void tsMenu_Filters_Beheren_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmFilters.StartPosition = FormStartPosition.CenterParent;
			MyProject.Forms.frmFilters.ShowDialog();
		}

		private void tsMenu_Spots_Markeren_Click(object sender, EventArgs e)
		{
			appModule.APP_OLD_SPOT_ARRAY.AddRange(appModule.APP_NEW_SPOT_ARRAY);
			appModule.APP_NEW_SPOT_ARRAY.Clear();
			clsApplication clsApplication2 = new clsApplication();
			if (!clsApplication2.saveOLDSpots())
			{
				MessageBox.Show("De oude spots konden niet worden opgeslagen", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			Color backColor = default(Color);
			foreach (ListViewItem item in lstSpots.Items)
			{
				item.BackColor = backColor;
			}
			systrayIcon.Icon = Icon.FromHandle(((Bitmap)iconList.Images[0]).GetHicon());
			barStatus_lbl1.Text = "Gereed... " + Conversions.ToString(lstSpots.Items.Count) + " spots geladen waarvan " + appModule.APP_NEW_SPOT_ARRAY.Count + " nieuw";
		}

		private void tsMenu_Extra_Instellingen_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmInstellingen.StartPosition = FormStartPosition.CenterParent;
			MyProject.Forms.frmInstellingen.ShowDialog();
		}

		private void tsMenu_Help_Info_Click(object sender, EventArgs e)
		{
			string text = appModule.APP_TITLE + "\r\n\r\n";
			text = text + "Versie " + appModule.APP_VERSION + "\r\n\r\n";
			text += "by DeVAZ\r\n\r\n";
			text += "Programma om automatisch de Spotnet database te monitoren naar spots die overeenkomen met de door jouw ingestelde zoek criteria.";
			MessageBox.Show(text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void systrayMenu_Afsluiten_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void systrayMenu_Openen_Click(object sender, EventArgs e)
		{
			showForm();
		}

		private void systrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			showForm();
		}

		private bool getDBAuto()
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Spotnet"))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Spotnet");
				FileInfo[] files = directoryInfo.GetFiles("*.dbs");
				if (files.Count() > 1)
				{
					MyProject.Forms.frmFindServer.StartPosition = FormStartPosition.CenterParent;
					MyProject.Forms.frmFindServer.ShowDialog();
					if (MyProject.Forms.frmFindServer.cmbServer.SelectedIndex >= 0)
					{
						appModule.PATH_SPOT_DATABASE = files[MyProject.Forms.frmFindServer.cmbServer.SelectedIndex].FullName.ToString();
						return true;
					}
					return false;
				}
				if (File.Exists(files.First().FullName.ToString()))
				{
					appModule.PATH_SPOT_DATABASE = files.First().FullName.ToString();
					return true;
				}
				return false;
			}
			return false;
		}

		private bool getDBHandmatig()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Open Database Bestand";
			openFileDialog.Filter = "Spotnet Database Bestand|*.dbs";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				appModule.PATH_SPOT_DATABASE = openFileDialog.FileName;
				return true;
			}
			return false;
		}

		private void tsMenu_Spots_Download_Geschiedenis_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmDownloadHistory.StartPosition = FormStartPosition.CenterParent;
			MyProject.Forms.frmDownloadHistory.ShowDialog();
		}
	}
}
