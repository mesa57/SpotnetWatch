using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SpotnetWatch.My;

namespace SpotnetWatch
{
	[DesignerGenerated]
	public partial class frmDownload : Form
	{

		private void frmDownload_Activated(object sender, EventArgs e)
		{
			TopMost = appModule.APP_ON_TOP;
		}

		private void frmDownload_Load(object sender, EventArgs e)
		{
			txtSABnzbname.Text = MyProject.Forms.frmMain.lstSpots.Items[MyProject.Forms.frmMain.lstSpots.FocusedItem.Index].Text;
			cmbSABprio.Items.Clear();
			cmbSABprio.Items.Add(new GenericListItem<int>("Standaard", -100));
			cmbSABprio.Items.Add(new GenericListItem<int>("Gepauzeerd", -2));
			cmbSABprio.Items.Add(new GenericListItem<int>("Laag", -1));
			cmbSABprio.Items.Add(new GenericListItem<int>("Normaal", 0));
			cmbSABprio.Items.Add(new GenericListItem<int>("Hoog", 1));
			cmbSABprio.SelectedIndex = 0;
			cmbSABmodus.Items.Clear();
			cmbSABmodus.Items.Add(new GenericListItem<int>("Standaard", -1));
			cmbSABmodus.Items.Add(new GenericListItem<int>("Downloaden", 0));
			cmbSABmodus.Items.Add(new GenericListItem<int>("Downloaden en Repareren", 1));
			cmbSABmodus.Items.Add(new GenericListItem<int>("Downloaden en Repareren en Uitpakken", 2));
			cmbSABmodus.Items.Add(new GenericListItem<int>("Downloaden en Repareren en Uitpakken en Opschonen", 3));
			cmbSABmodus.SelectedIndex = 0;
			clsApplication clsApplication2 = new clsApplication();
			if (clsApplication2.getSABxml(appModule.APP_SABNZBD_SERVER + "/api?apikey=" + appModule.APP_SABNZBD_APIKEY + "&mode=get_cats&output=xml", "//categories/category", cmbSABcat) && cmbSABcat.Items.Count > 0)
			{
				cmbSABcat.SelectedIndex = 0;
			}
			if (clsApplication2.getSABxml(appModule.APP_SABNZBD_SERVER + "/api?apikey=" + appModule.APP_SABNZBD_APIKEY + "&mode=get_scripts&output=xml", "//scripts/script", cmbSABscript) && cmbSABscript.Items.Count > 0)
			{
				cmbSABscript.SelectedIndex = 0;
			}
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			try
			{
				clsApplication clsApplication2 = new clsApplication();
				string text = Conversions.ToString(MyProject.Forms.frmMain.lstSpots.Items[MyProject.Forms.frmMain.lstSpots.FocusedItem.Index].Tag);
				string text2 = txtSABnzbname.Text;
				GenericListItem<int> genericListItem = (GenericListItem<int>)cmbSABprio.SelectedItem;
				GenericListItem<int> genericListItem2 = (GenericListItem<int>)cmbSABmodus.SelectedItem;
				string text3 = "/api?mode=addid";
				if (appModule.APP_NZB_SERVER_USE_API)
				{
					text3 = text3 + "&name=" + HttpUtility.UrlEncode(appModule.APP_SPOTWEB_SERVER + "/api?t=g&id=" + text + "&apikey=" + appModule.APP_SPOTWEB_APIKEY);
				}
				else if (appModule.APP_NZB_SERVER_NO_API)
				{
					text3 = text3 + "&name=" + HttpUtility.UrlEncode(appModule.APP_SPOTWEB_SERVER + text);
				}
				text3 = text3 + "&pp=" + genericListItem2.Value;
				text3 = text3 + "&script=" + cmbSABscript.Text;
				text3 = text3 + "&cat=" + cmbSABcat.Text;
				text3 = text3 + "&priority=" + genericListItem.Value;
				text3 = text3 + "&nzbname=" + text2;
				text3 = text3 + "&apikey=" + appModule.APP_SABNZBD_APIKEY;
				string address = appModule.APP_SABNZBD_SERVER + text3;
				WebClient webClient = new WebClient();
				webClient.UploadString(address, string.Empty);
				webClient = null;
				if (!clsApplication2.saveDOWNLOADSpots(text2))
				{
					MessageBox.Show("De download history kon niet worden bijgewerkt?", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				Dispose();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private void txtSABnzbname_LostFocus(object sender, EventArgs e)
		{
			if (Operators.CompareString(Strings.Trim(txtSABnzbname.Text), string.Empty, false) == 0)
			{
				txtSABnzbname.Text = "Kies een naam";
			}
		}

		private void btnHistory_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmDownloadHistory.StartPosition = FormStartPosition.CenterParent;
			MyProject.Forms.frmDownloadHistory.ShowDialog();
		}
	}
}
