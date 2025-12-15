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
	public partial class frmFindServer : Form
	{

		private void frmFindServer_Activated(object sender, EventArgs e)
		{
			TopMost = appModule.APP_ON_TOP;
		}

		private void frmFindServer_Load(object sender, EventArgs e)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Spotnet");
			FileInfo[] files = directoryInfo.GetFiles("*.dbs");
			FileInfo[] array = files;
			foreach (FileInfo item in array)
			{
				cmbServer.Items.Add(item);
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
