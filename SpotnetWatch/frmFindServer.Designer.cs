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
	public partial class frmFindServer : Form
	{
		private IContainer components = null;

	[AccessedThroughProperty("lbl1")]
		private Label _lbl1;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("cmbServer")]
		private ComboBox _cmbServer;

		[AccessedThroughProperty("btnOk")]
		private Button _btnOk;

		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		internal virtual Label lbl1
		{
			get
			{
				return _lbl1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lbl1 = value;
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

		internal virtual ComboBox cmbServer
		{
			get
			{
				return _cmbServer;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_cmbServer = value;
			}
		}

		internal virtual Button btnOk
		{
			get
			{
				return _btnOk;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnOk_Click;
				if (_btnOk != null)
				{
					_btnOk.Click -= value2;
				}
				_btnOk = value;
				if (_btnOk != null)
				{
					_btnOk.Click += value2;
				}
			}
		}

		internal virtual Panel Panel2
		{
			get
			{
				return _Panel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Panel2 = value;
			}
		}

		public frmFindServer()
		{
			base.Activated += frmFindServer_Activated;
			base.Load += frmFindServer_Load;
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
			this._lbl1 = new System.Windows.Forms.Label();
			this._Panel1 = new System.Windows.Forms.Panel();
			this._cmbServer = new System.Windows.Forms.ComboBox();
			this._btnOk = new System.Windows.Forms.Button();
			this._Panel2 = new System.Windows.Forms.Panel();
			this._Panel1.SuspendLayout();
			this._Panel2.SuspendLayout();
			this.SuspendLayout();
			this._lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			
			this._lbl1.Location = new System.Drawing.Point(13, 13);
			
			this._lbl1.Margin = new System.Windows.Forms.Padding(3);
			this._lbl1.Name = "lbl1";
			
			this._lbl1.Size = new System.Drawing.Size(440, 53);
			this._lbl1.TabIndex = 1;
			this._lbl1.Text = "Er zijn meerdere databases gevonden. Selecteer de database die gebruikt word door Spotnet. In de meeste gevallen is deze gelijk aan de naam van uw nieuws server.";
			this._Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._Panel1.Controls.Add(this._cmbServer);
			this._Panel1.Controls.Add(this._lbl1);
			
			this._Panel1.Location = new System.Drawing.Point(9, 9);
			this._Panel1.Name = "Panel1";
			
			this._Panel1.Padding = new System.Windows.Forms.Padding(10);
			
			this._Panel1.Size = new System.Drawing.Size(466, 106);
			this._Panel1.TabIndex = 2;
			this._cmbServer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbServer.FormattingEnabled = true;
			
			this._cmbServer.Location = new System.Drawing.Point(13, 72);
			this._cmbServer.Name = "cmbServer";
			
			this._cmbServer.Size = new System.Drawing.Size(440, 21);
			this._cmbServer.TabIndex = 1;
			this._btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			
			this._btnOk.Location = new System.Drawing.Point(363, 3);
			this._btnOk.Name = "btnOk";
			
			this._btnOk.Size = new System.Drawing.Size(100, 26);
			this._btnOk.TabIndex = 0;
			this._btnOk.Text = "Ok";
			this._btnOk.UseVisualStyleBackColor = true;
			this._Panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._Panel2.Controls.Add(this._btnOk);
			
			this._Panel2.Location = new System.Drawing.Point(9, 121);
			this._Panel2.Name = "Panel2";
			
			this._Panel2.Size = new System.Drawing.Size(466, 32);
			this._Panel2.TabIndex = 3;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 162);
			this.ControlBox = false;
			this.Controls.Add(this._Panel2);
			this.Controls.Add(this._Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmFindServer";
			this.Padding = new System.Windows.Forms.Padding(6);
			this.Text = "Database instellen";
			this._btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this._Panel1.ResumeLayout(false);
			this._Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
