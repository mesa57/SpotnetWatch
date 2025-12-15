using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using SpotnetWatch.My;

namespace SpotnetWatch
{
	[DesignerGenerated]
	public partial class frmInstellingen : Form
	{

		private void frmInstellingen_Activated(object sender, EventArgs e)
		{
			TopMost = appModule.APP_ON_TOP;
		}

		private void frmInstellingen_Load(object sender, EventArgs e)
		{
			lblHelpAlgemeen.Text = "Algemene instellingen voor SpotnetWatch. Indien SpotnetWatch niet meer goed functioneert dan kunt u de resetknop gebruiken om de standaard instellingen te herstellen.";
			numMaxDBRegels.Value = Conversions.ToDecimal(appModule.APP_SQL_MAX_ROWS);
			numMaxDagen.Value = Conversions.ToDecimal(appModule.APP_SQL_MAX_DAYS);
			txtGrabNZB.Text = appModule.APP_NZB_SERVER;
			chkStartInSystray.Checked = appModule.APP_START_IN_SYSTRAY;
			chkBoot.Checked = appModule.APP_START_ON_BOOT;
			chkUpdExitFilter.Checked = appModule.APP_SCAN_ON_FILTER_EXIT;
			chkTopMost.Checked = appModule.APP_ON_TOP;
			chkColHAutoSize.Checked = appModule.APP_COLUMN_AUTOSIZE;
			chkGridLines.Checked = appModule.APP_GRID_LINES;
			chkMelding.Checked = appModule.APP_REPORT_ONLY_NEW_SPOTS;
			lblHelpKleuren.Text = "Indien SpotnetWatch nieuwe spots heeft gevonden dan worden deze gekleurd aangegeven. Deze kleuren kunt u hier wijzigen.";
			picCat1.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT1.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT1.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT1.GetValue(2).ToString()));
			picCat2.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT2.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT2.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT2.GetValue(2).ToString()));
			picCat3.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT3.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT3.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT3.GetValue(2).ToString()));
			picCat4.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT4.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT4.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT4.GetValue(2).ToString()));
			picCat5.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT5.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT5.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT5.GetValue(2).ToString()));
			picCat6.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT6.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT6.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT6.GetValue(2).ToString()));
			picCat9.BackColor = Color.FromArgb(Conversions.ToInteger(appModule.COLOR_CAT9.GetValue(0).ToString()), Conversions.ToInteger(appModule.COLOR_CAT9.GetValue(1).ToString()), Conversions.ToInteger(appModule.COLOR_CAT9.GetValue(2).ToString()));
			lblHelpDownload.Text = "Na invullen zal de optie downloaden onder de rechtermuisknop actief zijn. SpotnetWatch kan nu SABnzbd de opdracht geven om een nzb bestand vanaf Spotweb op te halen.";
			txtSABserver.Text = appModule.APP_SABNZBD_SERVER;
			txtSABapikey.Text = appModule.APP_SABNZBD_APIKEY;
			opnNZBnoAPI.Checked = appModule.APP_NZB_SERVER_NO_API;
			opnNZBuseAPI.Checked = appModule.APP_NZB_SERVER_USE_API;
			txtNZBserver.Text = appModule.APP_SPOTWEB_SERVER;
			txtNZBapikey.Text = appModule.APP_SPOTWEB_APIKEY;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void btnOpslaan_Click(object sender, EventArgs e)
		{
			if (Convert.ToDouble(numMaxDagen.Value) != Conversions.ToDouble(appModule.APP_SQL_MAX_DAYS) && File.Exists(appModule.PATH_OLD_SPOT_FILE))
			{
				FileSystem.Kill(appModule.PATH_OLD_SPOT_FILE);
				appModule.APP_OLD_SPOT_ARRAY.Clear();
				StreamWriter streamWriter = new StreamWriter(appModule.PATH_OLD_SPOT_FILE);
				streamWriter.Close();
				DialogResult dialogResult = MessageBox.Show("De optie 'Filters toepassen op spots vanaf aantal dagen terug' is gewijzigd. De oude spots worden bij de volgende database scan nogmaals eenmalig meegenomen.\r\n\r\nWilt u nu de database scannen op spots?", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					appModule.APP_LAST_SCAN = Conversions.ToDate("01-01-1900 00:00:00");
				}
			}
			appModule.APP_SQL_MAX_ROWS = Conversions.ToString(numMaxDBRegels.Value);
			appModule.APP_SQL_MAX_DAYS = Conversions.ToString(numMaxDagen.Value);
			appModule.APP_NZB_SERVER = txtGrabNZB.Text;
			appModule.APP_START_IN_SYSTRAY = chkStartInSystray.Checked;
			appModule.APP_START_ON_BOOT = chkBoot.Checked;
			appModule.APP_SCAN_ON_FILTER_EXIT = chkUpdExitFilter.Checked;
			appModule.APP_ON_TOP = chkTopMost.Checked;
			appModule.APP_COLUMN_AUTOSIZE = chkColHAutoSize.Checked;
			appModule.APP_GRID_LINES = chkGridLines.Checked;
			appModule.APP_REPORT_ONLY_NEW_SPOTS = chkMelding.Checked;
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_SQL_MAX_ROWS", appModule.APP_SQL_MAX_ROWS);
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_SQL_MAX_DAYS", appModule.APP_SQL_MAX_DAYS);
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_NZB_SERVER", appModule.APP_NZB_SERVER);
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_START_IN_SYSTRAY", Conversions.ToString(appModule.APP_START_IN_SYSTRAY));
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_START_ON_BOOT", Conversions.ToString(appModule.APP_START_ON_BOOT));
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_SCAN_ON_FILTER_EXIT", Conversions.ToString(appModule.APP_SCAN_ON_FILTER_EXIT));
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_ON_TOP", Conversions.ToString(appModule.APP_ON_TOP));
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_COLUMN_AUTOSIZE", Conversions.ToString(appModule.APP_COLUMN_AUTOSIZE));
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_GRID_LINES", Conversions.ToString(appModule.APP_GRID_LINES));
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_REPORT_ONLY_NEW_SPOTS", Conversions.ToString(appModule.APP_REPORT_ONLY_NEW_SPOTS));
			appModule.COLOR_CAT1 = Strings.Split(Conversions.ToString(picCat1.BackColor.R) + "," + Conversions.ToString(picCat1.BackColor.G) + "," + Conversions.ToString(picCat1.BackColor.B), ",");
			appModule.COLOR_CAT2 = Strings.Split(Conversions.ToString(picCat2.BackColor.R) + "," + Conversions.ToString(picCat2.BackColor.G) + "," + Conversions.ToString(picCat2.BackColor.B), ",");
			appModule.COLOR_CAT3 = Strings.Split(Conversions.ToString(picCat3.BackColor.R) + "," + Conversions.ToString(picCat3.BackColor.G) + "," + Conversions.ToString(picCat3.BackColor.B), ",");
			appModule.COLOR_CAT4 = Strings.Split(Conversions.ToString(picCat4.BackColor.R) + "," + Conversions.ToString(picCat4.BackColor.G) + "," + Conversions.ToString(picCat4.BackColor.B), ",");
			appModule.COLOR_CAT5 = Strings.Split(Conversions.ToString(picCat5.BackColor.R) + "," + Conversions.ToString(picCat5.BackColor.G) + "," + Conversions.ToString(picCat5.BackColor.B), ",");
			appModule.COLOR_CAT6 = Strings.Split(Conversions.ToString(picCat6.BackColor.R) + "," + Conversions.ToString(picCat6.BackColor.G) + "," + Conversions.ToString(picCat6.BackColor.B), ",");
			appModule.COLOR_CAT9 = Strings.Split(Conversions.ToString(picCat9.BackColor.R) + "," + Conversions.ToString(picCat9.BackColor.G) + "," + Conversions.ToString(picCat9.BackColor.B), ",");
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "COLOR_CAT1", appModule.COLOR_CAT1.GetValue(0).ToString() + "," + appModule.COLOR_CAT1.GetValue(1).ToString() + "," + appModule.COLOR_CAT1.GetValue(2).ToString());
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "COLOR_CAT2", appModule.COLOR_CAT2.GetValue(0).ToString() + "," + appModule.COLOR_CAT2.GetValue(1).ToString() + "," + appModule.COLOR_CAT2.GetValue(2).ToString());
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "COLOR_CAT3", appModule.COLOR_CAT3.GetValue(0).ToString() + "," + appModule.COLOR_CAT3.GetValue(1).ToString() + "," + appModule.COLOR_CAT3.GetValue(2).ToString());
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "COLOR_CAT4", appModule.COLOR_CAT4.GetValue(0).ToString() + "," + appModule.COLOR_CAT4.GetValue(1).ToString() + "," + appModule.COLOR_CAT4.GetValue(2).ToString());
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "COLOR_CAT5", appModule.COLOR_CAT5.GetValue(0).ToString() + "," + appModule.COLOR_CAT5.GetValue(1).ToString() + "," + appModule.COLOR_CAT5.GetValue(2).ToString());
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "COLOR_CAT6", appModule.COLOR_CAT6.GetValue(0).ToString() + "," + appModule.COLOR_CAT6.GetValue(1).ToString() + "," + appModule.COLOR_CAT6.GetValue(2).ToString());
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "COLOR_CAT9", appModule.COLOR_CAT9.GetValue(0).ToString() + "," + appModule.COLOR_CAT9.GetValue(1).ToString() + "," + appModule.COLOR_CAT9.GetValue(2).ToString());
			appModule.APP_SABNZBD_SERVER = Strings.LCase(txtSABserver.Text);
			appModule.APP_SABNZBD_APIKEY = txtSABapikey.Text;
			appModule.APP_NZB_SERVER_NO_API = opnNZBnoAPI.Checked;
			appModule.APP_NZB_SERVER_USE_API = opnNZBuseAPI.Checked;
			appModule.APP_SPOTWEB_SERVER = txtNZBserver.Text;
			appModule.APP_SPOTWEB_APIKEY = txtNZBapikey.Text;
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_SABNZBD_SERVER", appModule.APP_SABNZBD_SERVER);
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_SABNZBD_APIKEY", appModule.APP_SABNZBD_APIKEY);
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_NZB_SERVER_NO_API", Conversions.ToString(appModule.APP_NZB_SERVER_NO_API));
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_NZB_SERVER_USE_API", Conversions.ToString(appModule.APP_NZB_SERVER_USE_API));
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_SPOTWEB_SERVER", appModule.APP_SPOTWEB_SERVER);
			Interaction.SaveSetting(Application.ProductName, "Instellingen", "APP_SPOTWEB_APIKEY", appModule.APP_SPOTWEB_APIKEY);
			if ((Operators.CompareString(appModule.APP_SABNZBD_SERVER, "http://sabnzbd_server", false) != 0) & (appModule.APP_SABNZBD_APIKEY.Length > 0))
			{
				MyProject.Forms.frmMain.rbm_lstSpots_Download.Enabled = true;
			}
			else
			{
				MyProject.Forms.frmMain.rbm_lstSpots_Download.Enabled = false;
			}
			if (appModule.APP_COLUMN_AUTOSIZE)
			{
				MyProject.Forms.frmMain.lstSpots.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			if (appModule.APP_GRID_LINES)
			{
				MyProject.Forms.frmMain.lstSpots.GridLines = true;
			}
			else
			{
				MyProject.Forms.frmMain.lstSpots.GridLines = false;
			}
			if (appModule.APP_START_ON_BOOT)
			{
				RunAtStartup(Application.ProductName, Application.ExecutablePath);
			}
			else
			{
				RemoveValue(Application.ProductName);
			}
			Dispose();
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void btnReset_Click(object sender, EventArgs e)
		{
			MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("Weet u zeker dat alle instellingen verwijderd kunnen worden?", "Vraag", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (msgBoxResult != MsgBoxResult.Yes)
			{
				return;
			}
			try
			{
				Interaction.DeleteSetting(Application.ProductName);
				FileSystem.Kill(appModule.PATH_OLD_SPOT_FILE);
				MessageBox.Show("Het verwijderen van de instellingen is gelukt. De applicatie word nu afgesloten.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Application.Exit();
			}
		}

		private void RunAtStartup(string ApplicationName, string ApplicationPath)
		{
			RegistryKey registryKey = MyProject.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			RegistryKey registryKey2 = registryKey;
			registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			registryKey2.SetValue(ApplicationName, ApplicationPath);
			registryKey2 = null;
		}

		private void RemoveValue(string ApplicationName)
		{
			RegistryKey registryKey = MyProject.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
			RegistryKey registryKey2 = registryKey;
			registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			registryKey2.DeleteValue(ApplicationName, false);
			registryKey2 = null;
		}

		private void txtGrabNZB_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(Strings.Trim(txtGrabNZB.Text), string.Empty, false) == 0)
			{
				txtGrabNZB.Text = "http://www.nzbserver.com/#/?page=getspot&messageid=";
			}
		}

		private void txtSABserver_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(Strings.Trim(txtSABserver.Text), string.Empty, false) == 0)
			{
				txtSABserver.Text = "http://sabnzbd_server";
			}
		}

		private void txtNZBserver_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(Strings.Trim(txtNZBserver.Text), string.Empty, false) == 0)
			{
				txtNZBserver.Text = "http://spotweb_server";
			}
		}

		private void lblSABtest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (Operators.CompareString(Strings.LCase(txtSABserver.Text), "http://sabnzbd_server", false) != 0)
			{
				try
				{
					WebClient webClient = new WebClient();
					string text = webClient.DownloadString(txtSABserver.Text + "/sabnzbd/api?mode=version&output=xml");
					MessageBox.Show("De SABnzbd server is gevonden", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show("De SABnzbd server is niet gevonden", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void lblNZBtest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (Operators.CompareString(Strings.LCase(txtNZBserver.Text), "http://spotweb_server", false) == 0)
			{
				return;
			}
			if (opnNZBnoAPI.Checked)
			{
				try
				{
					WebClient webClient = new WebClient();
					string text = webClient.DownloadString(txtNZBserver.Text);
					MessageBox.Show("De Spotweb server is gevonden", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					MessageBox.Show("De Spotweb server is niet gevonden", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
					return;
				}
			}
			try
			{
				WebClient webClient2 = new WebClient();
				string text2 = webClient2.DownloadString(txtNZBserver.Text + "/api");
				MessageBox.Show("De Spotweb server is gevonden", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show("De Spotweb server is niet gevonden", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private void colorBox(PictureBox picCat, Array CATEGORIE)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = picCat.BackColor;
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				picCat.BackColor = colorDialog.Color;
				CATEGORIE.SetValue(colorDialog.Color.R.ToString(), 0);
				CATEGORIE.SetValue(colorDialog.Color.G.ToString(), 1);
				CATEGORIE.SetValue(colorDialog.Color.B.ToString(), 2);
				colorDialog.Dispose();
			}
		}

		private void picCat1_Click(object sender, EventArgs e)
		{
			colorBox(picCat1, appModule.COLOR_CAT1);
		}

		private void picCat2_Click(object sender, EventArgs e)
		{
			colorBox(picCat2, appModule.COLOR_CAT2);
		}

		private void picCat3_Click(object sender, EventArgs e)
		{
			colorBox(picCat3, appModule.COLOR_CAT3);
		}

		private void picCat4_Click(object sender, EventArgs e)
		{
			colorBox(picCat4, appModule.COLOR_CAT4);
		}

		private void picCat5_Click(object sender, EventArgs e)
		{
			colorBox(picCat5, appModule.COLOR_CAT5);
		}

		private void picCat6_Click(object sender, EventArgs e)
		{
			colorBox(picCat6, appModule.COLOR_CAT6);
		}

		private void picCat9_Click(object sender, EventArgs e)
		{
			colorBox(picCat9, appModule.COLOR_CAT9);
		}
	}
}
