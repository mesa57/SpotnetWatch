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
	public partial class frmDownload : Form
	{
		private IContainer components = null;

	[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("cmbSABscript")]
		private ComboBox _cmbSABscript;

		[AccessedThroughProperty("cmbSABmodus")]
		private ComboBox _cmbSABmodus;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("txtSABnzbname")]
		private TextBox _txtSABnzbname;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("cmbSABcat")]
		private ComboBox _cmbSABcat;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("cmbSABprio")]
		private ComboBox _cmbSABprio;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("btnHistory")]
		private Button _btnHistory;

		[AccessedThroughProperty("btnAnnuleren")]
		private Button _btnAnnuleren;

		[AccessedThroughProperty("btnDownload")]
		private Button _btnDownload;

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

		internal virtual Label Label1
		{
			get
			{
				return _Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label1 = value;
			}
		}

		internal virtual ComboBox cmbSABscript
		{
			get
			{
				return _cmbSABscript;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_cmbSABscript = value;
			}
		}

		internal virtual ComboBox cmbSABmodus
		{
			get
			{
				return _cmbSABmodus;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_cmbSABmodus = value;
			}
		}

		internal virtual Label Label4
		{
			get
			{
				return _Label4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label4 = value;
			}
		}

		internal virtual Label Label5
		{
			get
			{
				return _Label5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label5 = value;
			}
		}

		internal virtual TextBox txtSABnzbname
		{
			get
			{
				return _txtSABnzbname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = txtSABnzbname_LostFocus;
				if (_txtSABnzbname != null)
				{
					_txtSABnzbname.LostFocus -= value2;
				}
				_txtSABnzbname = value;
				if (_txtSABnzbname != null)
				{
					_txtSABnzbname.LostFocus += value2;
				}
			}
		}

		internal virtual Label Label3
		{
			get
			{
				return _Label3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label3 = value;
			}
		}

		internal virtual ComboBox cmbSABcat
		{
			get
			{
				return _cmbSABcat;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_cmbSABcat = value;
			}
		}

		internal virtual Label Label2
		{
			get
			{
				return _Label2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label2 = value;
			}
		}

		internal virtual ComboBox cmbSABprio
		{
			get
			{
				return _cmbSABprio;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_cmbSABprio = value;
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

		internal virtual Button btnHistory
		{
			get
			{
				return _btnHistory;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnHistory_Click;
				if (_btnHistory != null)
				{
					_btnHistory.Click -= value2;
				}
				_btnHistory = value;
				if (_btnHistory != null)
				{
					_btnHistory.Click += value2;
				}
			}
		}

		internal virtual Button btnAnnuleren
		{
			get
			{
				return _btnAnnuleren;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_btnAnnuleren = value;
			}
		}

		internal virtual Button btnDownload
		{
			get
			{
				return _btnDownload;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnDownload_Click;
				if (_btnDownload != null)
				{
					_btnDownload.Click -= value2;
				}
				_btnDownload = value;
				if (_btnDownload != null)
				{
					_btnDownload.Click += value2;
				}
			}
		}

		public frmDownload()
		{
			base.Activated += frmDownload_Activated;
			base.Load += frmDownload_Load;
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
			this._Panel2 = new System.Windows.Forms.Panel();
			this._Label1 = new System.Windows.Forms.Label();
			this._cmbSABscript = new System.Windows.Forms.ComboBox();
			this._cmbSABmodus = new System.Windows.Forms.ComboBox();
			this._Label4 = new System.Windows.Forms.Label();
			this._Label5 = new System.Windows.Forms.Label();
			this._txtSABnzbname = new System.Windows.Forms.TextBox();
			this._Label3 = new System.Windows.Forms.Label();
			this._cmbSABcat = new System.Windows.Forms.ComboBox();
			this._Label2 = new System.Windows.Forms.Label();
			this._cmbSABprio = new System.Windows.Forms.ComboBox();
			this._Panel1 = new System.Windows.Forms.Panel();
			this._btnHistory = new System.Windows.Forms.Button();
			this._btnAnnuleren = new System.Windows.Forms.Button();
			this._btnDownload = new System.Windows.Forms.Button();
			this._Panel2.SuspendLayout();
			this._Panel1.SuspendLayout();
			this.SuspendLayout();
			this._Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._Panel2.Controls.Add(this._Label1);
			this._Panel2.Controls.Add(this._cmbSABscript);
			this._Panel2.Controls.Add(this._cmbSABmodus);
			this._Panel2.Controls.Add(this._Label4);
			this._Panel2.Controls.Add(this._Label5);
			this._Panel2.Controls.Add(this._txtSABnzbname);
			this._Panel2.Controls.Add(this._Label3);
			this._Panel2.Controls.Add(this._cmbSABcat);
			this._Panel2.Controls.Add(this._Label2);
			this._Panel2.Controls.Add(this._cmbSABprio);
			
			this._Panel2.Location = new System.Drawing.Point(9, 9);
			this._Panel2.Name = "Panel2";
			
			this._Panel2.Size = new System.Drawing.Size(366, 306);
			this._Panel2.TabIndex = 52;
			this._Label1.AutoSize = true;
			
			this._Label1.Location = new System.Drawing.Point(3, 10);
			
			this._Label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label1.Name = "Label1";
			
			this._Label1.Size = new System.Drawing.Size(35, 13);
			this._Label1.TabIndex = 46;
			this._Label1.Text = "Naam";
			this._cmbSABscript.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._cmbSABscript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbSABscript.FormattingEnabled = true;
			
			this._cmbSABscript.Location = new System.Drawing.Point(3, 225);
			this._cmbSABscript.Name = "cmbSABscript";
			
			this._cmbSABscript.Size = new System.Drawing.Size(360, 21);
			this._cmbSABscript.TabIndex = 7;
			this._cmbSABmodus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._cmbSABmodus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbSABmodus.FormattingEnabled = true;
			
			this._cmbSABmodus.Location = new System.Drawing.Point(3, 175);
			this._cmbSABmodus.Name = "cmbSABmodus";
			
			this._cmbSABmodus.Size = new System.Drawing.Size(360, 21);
			this._cmbSABmodus.TabIndex = 6;
			this._Label4.AutoSize = true;
			
			this._Label4.Location = new System.Drawing.Point(3, 209);
			
			this._Label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label4.Name = "Label4";
			
			this._Label4.Size = new System.Drawing.Size(34, 13);
			this._Label4.TabIndex = 48;
			this._Label4.Text = "Script";
			this._Label5.AutoSize = true;
			
			this._Label5.Location = new System.Drawing.Point(3, 159);
			
			this._Label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label5.Name = "Label5";
			
			this._Label5.Size = new System.Drawing.Size(39, 13);
			this._Label5.TabIndex = 49;
			this._Label5.Text = "Modus";
			this._txtSABnzbname.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			
			this._txtSABnzbname.Location = new System.Drawing.Point(3, 26);
			this._txtSABnzbname.Name = "txtSABnzbname";
			
			this._txtSABnzbname.Size = new System.Drawing.Size(360, 20);
			this._txtSABnzbname.TabIndex = 3;
			this._Label3.AutoSize = true;
			
			this._Label3.Location = new System.Drawing.Point(3, 59);
			
			this._Label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label3.Name = "Label3";
			
			this._Label3.Size = new System.Drawing.Size(52, 13);
			this._Label3.TabIndex = 45;
			this._Label3.Text = "Categorie";
			this._cmbSABcat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._cmbSABcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbSABcat.FormattingEnabled = true;
			
			this._cmbSABcat.Location = new System.Drawing.Point(3, 75);
			this._cmbSABcat.Name = "cmbSABcat";
			
			this._cmbSABcat.Size = new System.Drawing.Size(360, 21);
			this._cmbSABcat.TabIndex = 4;
			this._Label2.AutoSize = true;
			
			this._Label2.Location = new System.Drawing.Point(3, 109);
			
			this._Label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label2.Name = "Label2";
			
			this._Label2.Size = new System.Drawing.Size(44, 13);
			this._Label2.TabIndex = 47;
			this._Label2.Text = "Prioriteit";
			this._cmbSABprio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._cmbSABprio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbSABprio.FormattingEnabled = true;
			
			this._cmbSABprio.Location = new System.Drawing.Point(3, 125);
			this._cmbSABprio.Name = "cmbSABprio";
			
			this._cmbSABprio.Size = new System.Drawing.Size(360, 21);
			this._cmbSABprio.TabIndex = 5;
			this._Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._Panel1.Controls.Add(this._btnHistory);
			this._Panel1.Controls.Add(this._btnAnnuleren);
			this._Panel1.Controls.Add(this._btnDownload);
			
			this._Panel1.Location = new System.Drawing.Point(9, 321);
			this._Panel1.Name = "Panel1";
			
			this._Panel1.Size = new System.Drawing.Size(366, 32);
			this._Panel1.TabIndex = 51;
			this._btnHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			
			this._btnHistory.Location = new System.Drawing.Point(3, 3);
			this._btnHistory.Name = "btnHistory";
			
			this._btnHistory.Size = new System.Drawing.Size(100, 26);
			this._btnHistory.TabIndex = 2;
			this._btnHistory.Text = "Geschiedenis";
			this._btnHistory.UseVisualStyleBackColor = true;
			this._btnAnnuleren.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this._btnAnnuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			
			this._btnAnnuleren.Location = new System.Drawing.Point(263, 3);
			this._btnAnnuleren.Name = "btnAnnuleren";
			
			this._btnAnnuleren.Size = new System.Drawing.Size(100, 26);
			this._btnAnnuleren.TabIndex = 0;
			this._btnAnnuleren.Text = "Annuleren";
			this._btnAnnuleren.UseVisualStyleBackColor = true;
			this._btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			
			this._btnDownload.Location = new System.Drawing.Point(157, 3);
			this._btnDownload.Name = "btnDownload";
			
			this._btnDownload.Size = new System.Drawing.Size(100, 26);
			this._btnDownload.TabIndex = 1;
			this._btnDownload.Text = "Download";
			this._btnDownload.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 362);
			this.Controls.Add(this._Panel2);
			this.Controls.Add(this._Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "frmDownload";
			this.Padding = new System.Windows.Forms.Padding(6);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Downloaden via SABnzbd";
			this._btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
			this._btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			this._txtSABnzbname.LostFocus += new System.EventHandler(this.txtSABnzbname_LostFocus);
			this._Panel2.ResumeLayout(false);
			this._Panel2.PerformLayout();
			this._Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
