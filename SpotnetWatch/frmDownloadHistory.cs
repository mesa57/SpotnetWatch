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
	public partial class frmDownloadHistory : Form
	{

		private void frmDownloadHistory_Load(object sender, EventArgs e)
		{
			clsApplication clsApplication2 = new clsApplication();
			clsApplication2.loadDOWNLOADSpots(txtDownloads);
		}

		private void btnWissen_Click(object sender, EventArgs e)
		{
			txtDownloads.Clear();
			File.Delete(appModule.PATH_DOWNLOAD_HISTORY_FILE);
		}
	}
}
