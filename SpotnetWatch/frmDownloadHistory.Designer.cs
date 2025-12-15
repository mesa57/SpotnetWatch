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
	public partial class frmDownloadHistory : Form
	{
		private IContainer components = null;

	[AccessedThroughProperty("txtDownloads")]
		private TextBox _txtDownloads;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("btnWissen")]
		private Button _btnWissen;

		[AccessedThroughProperty("btnSluiten")]
		private Button _btnSluiten;

		internal virtual TextBox txtDownloads
		{
			get
			{
				return _txtDownloads;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txtDownloads = value;
			}
		}

		internal virtual Panel Panel1
		{
			get
			{
				return _Panel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Panel1 = value;
			}
		}

		internal virtual Button btnWissen
		{
			get
			{
				return _btnWissen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnWissen_Click;
				if (_btnWissen != null)
				{
					_btnWissen.Click -= value2;
				}
				_btnWissen = value;
				if (_btnWissen != null)
				{
					_btnWissen.Click += value2;
				}
			}
		}

		internal virtual Button btnSluiten
		{
			get
			{
				return _btnSluiten;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_btnSluiten = value;
			}
		}

		public frmDownloadHistory()
		{
			base.Load += frmDownloadHistory_Load;
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}



		


		
[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this._txtDownloads = new System.Windows.Forms.TextBox();
			this._Panel1 = new System.Windows.Forms.Panel();
			this._btnWissen = new System.Windows.Forms.Button();
			this._btnSluiten = new System.Windows.Forms.Button();
			this._Panel1.SuspendLayout();
			this.SuspendLayout();
			this._txtDownloads.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			
			this._txtDownloads.Location = new System.Drawing.Point(9, 9);
			this._txtDownloads.Multiline = true;
			this._txtDownloads.Name = "txtDownloads";
			this._txtDownloads.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			
			this._txtDownloads.Size = new System.Drawing.Size(516, 406);
			this._txtDownloads.TabIndex = 2;
			this._Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._Panel1.Controls.Add(this._btnWissen);
			this._Panel1.Controls.Add(this._btnSluiten);
			
			this._Panel1.Location = new System.Drawing.Point(9, 421);
			this._Panel1.Name = "Panel1";
			
			this._Panel1.Size = new System.Drawing.Size(516, 32);
			this._Panel1.TabIndex = 5;
			this._btnWissen.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			
			this._btnWissen.Location = new System.Drawing.Point(307, 3);
			this._btnWissen.Name = "btnWissen";
			
			this._btnWissen.Size = new System.Drawing.Size(100, 26);
			this._btnWissen.TabIndex = 1;
			this._btnWissen.Text = "Wissen";
			this._btnWissen.UseVisualStyleBackColor = true;
			this._btnSluiten.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this._btnSluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			
			this._btnSluiten.Location = new System.Drawing.Point(413, 3);
			this._btnSluiten.Name = "btnSluiten";
			
			this._btnSluiten.Size = new System.Drawing.Size(100, 26);
			this._btnSluiten.TabIndex = 0;
			this._btnSluiten.Text = "Sluiten";
			this._btnSluiten.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnSluiten;
			this.ClientSize = new System.Drawing.Size(534, 462);
			this.Controls.Add(this._txtDownloads);
			this.Controls.Add(this._Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 500);
			this.Name = "frmDownloadHistory";
			this.Padding = new System.Windows.Forms.Padding(6);
			this.ShowInTaskbar = false;
			this.Text = "Download geschiedenis";
			this._btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
			this._Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
