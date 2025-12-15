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
	public partial class frmInstellingen : Form
	{
		private IContainer components = null;

	[AccessedThroughProperty("txtGrabNZB")]
		private TextBox _txtGrabNZB;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("chkGridLines")]
		private CheckBox _chkGridLines;

		[AccessedThroughProperty("chkColHAutoSize")]
		private CheckBox _chkColHAutoSize;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("chkTopMost")]
		private CheckBox _chkTopMost;

		[AccessedThroughProperty("chkBoot")]
		private CheckBox _chkBoot;

		[AccessedThroughProperty("chkUpdExitFilter")]
		private CheckBox _chkUpdExitFilter;

		[AccessedThroughProperty("numMaxDBRegels")]
		private NumericUpDown _numMaxDBRegels;

		[AccessedThroughProperty("chkStartInSystray")]
		private CheckBox _chkStartInSystray;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("numMaxDagen")]
		private NumericUpDown _numMaxDagen;

		[AccessedThroughProperty("btnOpslaan")]
		private Button _btnOpslaan;

		[AccessedThroughProperty("btnAnnuleren")]
		private Button _btnAnnuleren;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("TabControl1")]
		private TabControl _TabControl1;

		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		[AccessedThroughProperty("btnReset")]
		private Button _btnReset;

		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		[AccessedThroughProperty("picCat1")]
		private PictureBox _picCat1;

		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		[AccessedThroughProperty("picCat9")]
		private PictureBox _picCat9;

		[AccessedThroughProperty("picCat4")]
		private PictureBox _picCat4;

		[AccessedThroughProperty("picCat3")]
		private PictureBox _picCat3;

		[AccessedThroughProperty("picCat2")]
		private PictureBox _picCat2;

		[AccessedThroughProperty("picCat5")]
		private PictureBox _picCat5;

		[AccessedThroughProperty("picCat6")]
		private PictureBox _picCat6;

		[AccessedThroughProperty("chkMelding")]
		private CheckBox _chkMelding;

		[AccessedThroughProperty("TabPage4")]
		private TabPage _TabPage4;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("opnNZBuseAPI")]
		private RadioButton _opnNZBuseAPI;

		[AccessedThroughProperty("opnNZBnoAPI")]
		private RadioButton _opnNZBnoAPI;

		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[AccessedThroughProperty("txtNZBserver")]
		private TextBox _txtNZBserver;

		[AccessedThroughProperty("lblNZBtest")]
		private LinkLabel _lblNZBtest;

		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		[AccessedThroughProperty("txtNZBapikey")]
		private TextBox _txtNZBapikey;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("txtSABserver")]
		private TextBox _txtSABserver;

		[AccessedThroughProperty("lblSABtest")]
		private LinkLabel _lblSABtest;

		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[AccessedThroughProperty("txtSABapikey")]
		private TextBox _txtSABapikey;

		[AccessedThroughProperty("lblHelpAlgemeen")]
		private Label _lblHelpAlgemeen;

		[AccessedThroughProperty("lblHelpKleuren")]
		private Label _lblHelpKleuren;

		[AccessedThroughProperty("lblHelpDownload")]
		private Label _lblHelpDownload;

		internal virtual TextBox txtGrabNZB
		{
			get
			{
				return _txtGrabNZB;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = txtGrabNZB_LostFocus;
				if (_txtGrabNZB != null)
				{
					_txtGrabNZB.LostFocus -= value2;
				}
				_txtGrabNZB = value;
				if (_txtGrabNZB != null)
				{
					_txtGrabNZB.LostFocus += value2;
				}
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

		internal virtual CheckBox chkGridLines
		{
			get
			{
				return _chkGridLines;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkGridLines = value;
			}
		}

		internal virtual CheckBox chkColHAutoSize
		{
			get
			{
				return _chkColHAutoSize;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkColHAutoSize = value;
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

		internal virtual CheckBox chkTopMost
		{
			get
			{
				return _chkTopMost;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkTopMost = value;
			}
		}

		internal virtual CheckBox chkBoot
		{
			get
			{
				return _chkBoot;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkBoot = value;
			}
		}

		internal virtual CheckBox chkUpdExitFilter
		{
			get
			{
				return _chkUpdExitFilter;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkUpdExitFilter = value;
			}
		}

		internal virtual NumericUpDown numMaxDBRegels
		{
			get
			{
				return _numMaxDBRegels;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_numMaxDBRegels = value;
			}
		}

		internal virtual CheckBox chkStartInSystray
		{
			get
			{
				return _chkStartInSystray;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkStartInSystray = value;
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

		internal virtual NumericUpDown numMaxDagen
		{
			get
			{
				return _numMaxDagen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_numMaxDagen = value;
			}
		}

		internal virtual Button btnOpslaan
		{
			get
			{
				return _btnOpslaan;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnOpslaan_Click;
				if (_btnOpslaan != null)
				{
					_btnOpslaan.Click -= value2;
				}
				_btnOpslaan = value;
				if (_btnOpslaan != null)
				{
					_btnOpslaan.Click += value2;
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

		internal virtual TabControl TabControl1
		{
			get
			{
				return _TabControl1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabControl1 = value;
			}
		}

		internal virtual TabPage TabPage1
		{
			get
			{
				return _TabPage1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabPage1 = value;
			}
		}

		internal virtual Button btnReset
		{
			get
			{
				return _btnReset;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnReset_Click;
				if (_btnReset != null)
				{
					_btnReset.Click -= value2;
				}
				_btnReset = value;
				if (_btnReset != null)
				{
					_btnReset.Click += value2;
				}
			}
		}

		internal virtual TabPage TabPage2
		{
			get
			{
				return _TabPage2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabPage2 = value;
			}
		}

		internal virtual Label Label6
		{
			get
			{
				return _Label6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label6 = value;
			}
		}

		internal virtual Label Label23
		{
			get
			{
				return _Label23;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label23 = value;
			}
		}

		internal virtual Label Label19
		{
			get
			{
				return _Label19;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label19 = value;
			}
		}

		internal virtual Label Label15
		{
			get
			{
				return _Label15;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label15 = value;
			}
		}

		internal virtual Label Label27
		{
			get
			{
				return _Label27;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label27 = value;
			}
		}

		internal virtual PictureBox picCat1
		{
			get
			{
				return _picCat1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = picCat1_Click;
				if (_picCat1 != null)
				{
					_picCat1.Click -= value2;
				}
				_picCat1 = value;
				if (_picCat1 != null)
				{
					_picCat1.Click += value2;
				}
			}
		}

		internal virtual Label Label10
		{
			get
			{
				return _Label10;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label10 = value;
			}
		}

		internal virtual Label Label8
		{
			get
			{
				return _Label8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label8 = value;
			}
		}

		internal virtual PictureBox picCat9
		{
			get
			{
				return _picCat9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = picCat9_Click;
				if (_picCat9 != null)
				{
					_picCat9.Click -= value2;
				}
				_picCat9 = value;
				if (_picCat9 != null)
				{
					_picCat9.Click += value2;
				}
			}
		}

		internal virtual PictureBox picCat4
		{
			get
			{
				return _picCat4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = picCat4_Click;
				if (_picCat4 != null)
				{
					_picCat4.Click -= value2;
				}
				_picCat4 = value;
				if (_picCat4 != null)
				{
					_picCat4.Click += value2;
				}
			}
		}

		internal virtual PictureBox picCat3
		{
			get
			{
				return _picCat3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = picCat3_Click;
				if (_picCat3 != null)
				{
					_picCat3.Click -= value2;
				}
				_picCat3 = value;
				if (_picCat3 != null)
				{
					_picCat3.Click += value2;
				}
			}
		}

		internal virtual PictureBox picCat2
		{
			get
			{
				return _picCat2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = picCat2_Click;
				if (_picCat2 != null)
				{
					_picCat2.Click -= value2;
				}
				_picCat2 = value;
				if (_picCat2 != null)
				{
					_picCat2.Click += value2;
				}
			}
		}

		internal virtual PictureBox picCat5
		{
			get
			{
				return _picCat5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = picCat5_Click;
				if (_picCat5 != null)
				{
					_picCat5.Click -= value2;
				}
				_picCat5 = value;
				if (_picCat5 != null)
				{
					_picCat5.Click += value2;
				}
			}
		}

		internal virtual PictureBox picCat6
		{
			get
			{
				return _picCat6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = picCat6_Click;
				if (_picCat6 != null)
				{
					_picCat6.Click -= value2;
				}
				_picCat6 = value;
				if (_picCat6 != null)
				{
					_picCat6.Click += value2;
				}
			}
		}

		internal virtual CheckBox chkMelding
		{
			get
			{
				return _chkMelding;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_chkMelding = value;
			}
		}

		internal virtual TabPage TabPage4
		{
			get
			{
				return _TabPage4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_TabPage4 = value;
			}
		}

		internal virtual GroupBox GroupBox2
		{
			get
			{
				return _GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_GroupBox2 = value;
			}
		}

		internal virtual RadioButton opnNZBuseAPI
		{
			get
			{
				return _opnNZBuseAPI;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_opnNZBuseAPI = value;
			}
		}

		internal virtual RadioButton opnNZBnoAPI
		{
			get
			{
				return _opnNZBnoAPI;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_opnNZBnoAPI = value;
			}
		}

		internal virtual Label Label7
		{
			get
			{
				return _Label7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label7 = value;
			}
		}

		internal virtual TextBox txtNZBserver
		{
			get
			{
				return _txtNZBserver;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = txtNZBserver_LostFocus;
				if (_txtNZBserver != null)
				{
					_txtNZBserver.LostFocus -= value2;
				}
				_txtNZBserver = value;
				if (_txtNZBserver != null)
				{
					_txtNZBserver.LostFocus += value2;
				}
			}
		}

		internal virtual LinkLabel lblNZBtest
		{
			get
			{
				return _lblNZBtest;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = lblNZBtest_LinkClicked;
				if (_lblNZBtest != null)
				{
					_lblNZBtest.LinkClicked -= value2;
				}
				_lblNZBtest = value;
				if (_lblNZBtest != null)
				{
					_lblNZBtest.LinkClicked += value2;
				}
			}
		}

		internal virtual Label Label9
		{
			get
			{
				return _Label9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label9 = value;
			}
		}

		internal virtual TextBox txtNZBapikey
		{
			get
			{
				return _txtNZBapikey;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txtNZBapikey = value;
			}
		}

		internal virtual GroupBox GroupBox1
		{
			get
			{
				return _GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_GroupBox1 = value;
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

		internal virtual TextBox txtSABserver
		{
			get
			{
				return _txtSABserver;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = txtSABserver_LostFocus;
				if (_txtSABserver != null)
				{
					_txtSABserver.LostFocus -= value2;
				}
				_txtSABserver = value;
				if (_txtSABserver != null)
				{
					_txtSABserver.LostFocus += value2;
				}
			}
		}

		internal virtual LinkLabel lblSABtest
		{
			get
			{
				return _lblSABtest;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = lblSABtest_LinkClicked;
				if (_lblSABtest != null)
				{
					_lblSABtest.LinkClicked -= value2;
				}
				_lblSABtest = value;
				if (_lblSABtest != null)
				{
					_lblSABtest.LinkClicked += value2;
				}
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

		internal virtual TextBox txtSABapikey
		{
			get
			{
				return _txtSABapikey;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_txtSABapikey = value;
			}
		}

		internal virtual Label lblHelpAlgemeen
		{
			get
			{
				return _lblHelpAlgemeen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblHelpAlgemeen = value;
			}
		}

		internal virtual Label lblHelpKleuren
		{
			get
			{
				return _lblHelpKleuren;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblHelpKleuren = value;
			}
		}

		internal virtual Label lblHelpDownload
		{
			get
			{
				return _lblHelpDownload;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_lblHelpDownload = value;
			}
		}

		public frmInstellingen()
		{
			base.Activated += frmInstellingen_Activated;
			base.Load += frmInstellingen_Load;
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
			this._txtGrabNZB = new System.Windows.Forms.TextBox();
			this._Label2 = new System.Windows.Forms.Label();
			this._chkGridLines = new System.Windows.Forms.CheckBox();
			this._chkColHAutoSize = new System.Windows.Forms.CheckBox();
			this._Label3 = new System.Windows.Forms.Label();
			this._chkTopMost = new System.Windows.Forms.CheckBox();
			this._chkBoot = new System.Windows.Forms.CheckBox();
			this._chkUpdExitFilter = new System.Windows.Forms.CheckBox();
			this._numMaxDBRegels = new System.Windows.Forms.NumericUpDown();
			this._chkStartInSystray = new System.Windows.Forms.CheckBox();
			this._Label1 = new System.Windows.Forms.Label();
			this._numMaxDagen = new System.Windows.Forms.NumericUpDown();
			this._btnOpslaan = new System.Windows.Forms.Button();
			this._btnAnnuleren = new System.Windows.Forms.Button();
			this._Panel1 = new System.Windows.Forms.Panel();
			this._btnReset = new System.Windows.Forms.Button();
			this._TabControl1 = new System.Windows.Forms.TabControl();
			this._TabPage1 = new System.Windows.Forms.TabPage();
			this._lblHelpAlgemeen = new System.Windows.Forms.Label();
			this._chkMelding = new System.Windows.Forms.CheckBox();
			this._TabPage2 = new System.Windows.Forms.TabPage();
			this._lblHelpKleuren = new System.Windows.Forms.Label();
			this._picCat9 = new System.Windows.Forms.PictureBox();
			this._picCat4 = new System.Windows.Forms.PictureBox();
			this._picCat3 = new System.Windows.Forms.PictureBox();
			this._picCat2 = new System.Windows.Forms.PictureBox();
			this._picCat5 = new System.Windows.Forms.PictureBox();
			this._picCat6 = new System.Windows.Forms.PictureBox();
			this._picCat1 = new System.Windows.Forms.PictureBox();
			this._Label10 = new System.Windows.Forms.Label();
			this._Label8 = new System.Windows.Forms.Label();
			this._Label27 = new System.Windows.Forms.Label();
			this._Label23 = new System.Windows.Forms.Label();
			this._Label19 = new System.Windows.Forms.Label();
			this._Label15 = new System.Windows.Forms.Label();
			this._Label6 = new System.Windows.Forms.Label();
			this._TabPage4 = new System.Windows.Forms.TabPage();
			this._lblHelpDownload = new System.Windows.Forms.Label();
			this._GroupBox2 = new System.Windows.Forms.GroupBox();
			this._opnNZBuseAPI = new System.Windows.Forms.RadioButton();
			this._opnNZBnoAPI = new System.Windows.Forms.RadioButton();
			this._Label7 = new System.Windows.Forms.Label();
			this._txtNZBserver = new System.Windows.Forms.TextBox();
			this._lblNZBtest = new System.Windows.Forms.LinkLabel();
			this._Label9 = new System.Windows.Forms.Label();
			this._txtNZBapikey = new System.Windows.Forms.TextBox();
			this._GroupBox1 = new System.Windows.Forms.GroupBox();
			this._Label4 = new System.Windows.Forms.Label();
			this._txtSABserver = new System.Windows.Forms.TextBox();
			this._lblSABtest = new System.Windows.Forms.LinkLabel();
			this._Label5 = new System.Windows.Forms.Label();
			this._txtSABapikey = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)this._numMaxDBRegels).BeginInit();
			((System.ComponentModel.ISupportInitialize)this._numMaxDagen).BeginInit();
			this._Panel1.SuspendLayout();
			this._TabControl1.SuspendLayout();
			this._TabPage1.SuspendLayout();
			this._TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this._picCat9).BeginInit();
			((System.ComponentModel.ISupportInitialize)this._picCat4).BeginInit();
			((System.ComponentModel.ISupportInitialize)this._picCat3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this._picCat2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this._picCat5).BeginInit();
			((System.ComponentModel.ISupportInitialize)this._picCat6).BeginInit();
			((System.ComponentModel.ISupportInitialize)this._picCat1).BeginInit();
			this._TabPage4.SuspendLayout();
			this._GroupBox2.SuspendLayout();
			this._GroupBox1.SuspendLayout();
			this.SuspendLayout();
			this._txtGrabNZB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			
			this._txtGrabNZB.Location = new System.Drawing.Point(13, 194);
			this._txtGrabNZB.Name = "txtGrabNZB";
			
			this._txtGrabNZB.Size = new System.Drawing.Size(382, 20);
			this._txtGrabNZB.TabIndex = 6;
			this._Label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._Label2.AutoSize = true;
			
			this._Label2.Location = new System.Drawing.Point(13, 178);
			
			this._Label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label2.Name = "Label2";
			
			this._Label2.Size = new System.Drawing.Size(270, 13);
			this._Label2.TabIndex = 32;
			this._Label2.Text = "De volgende link openen bij dubbel klikken op een spot";
			this._chkGridLines.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._chkGridLines.AutoSize = true;
			
			this._chkGridLines.Location = new System.Drawing.Point(13, 342);
			this._chkGridLines.Name = "chkGridLines";
			
			this._chkGridLines.Size = new System.Drawing.Size(220, 17);
			this._chkGridLines.TabIndex = 12;
			this._chkGridLines.Text = "Raster lijnen weergeven in spot overzicht";
			this._chkGridLines.UseVisualStyleBackColor = true;
			this._chkColHAutoSize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._chkColHAutoSize.AutoSize = true;
			
			this._chkColHAutoSize.Location = new System.Drawing.Point(13, 319);
			this._chkColHAutoSize.Name = "chkColHAutoSize";
			
			this._chkColHAutoSize.Size = new System.Drawing.Size(229, 17);
			this._chkColHAutoSize.TabIndex = 11;
			this._chkColHAutoSize.Text = "Kolombreedte automatisch passend maken";
			this._chkColHAutoSize.UseVisualStyleBackColor = true;
			this._Label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._Label3.AutoSize = true;
			
			this._Label3.Location = new System.Drawing.Point(13, 80);
			
			this._Label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label3.Name = "Label3";
			
			this._Label3.Size = new System.Drawing.Size(211, 13);
			this._Label3.TabIndex = 30;
			this._Label3.Text = "Maximaal aantal spots laden en weergeven";
			this._chkTopMost.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._chkTopMost.AutoSize = true;
			
			this._chkTopMost.Location = new System.Drawing.Point(13, 296);
			this._chkTopMost.Name = "chkTopMost";
			
			this._chkTopMost.Size = new System.Drawing.Size(170, 17);
			this._chkTopMost.TabIndex = 10;
			this._chkTopMost.Text = "Altijd op voorgrond weergeven";
			this._chkTopMost.UseVisualStyleBackColor = true;
			this._chkBoot.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._chkBoot.AutoSize = true;
			
			this._chkBoot.Location = new System.Drawing.Point(13, 227);
			
			this._chkBoot.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this._chkBoot.Name = "chkBoot";
			
			this._chkBoot.Size = new System.Drawing.Size(202, 17);
			this._chkBoot.TabIndex = 7;
			this._chkBoot.Text = "Automatisch starten als windows start";
			this._chkBoot.UseVisualStyleBackColor = true;
			this._chkUpdExitFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._chkUpdExitFilter.AutoSize = true;
			
			this._chkUpdExitFilter.Location = new System.Drawing.Point(13, 273);
			this._chkUpdExitFilter.Name = "chkUpdExitFilter";
			
			this._chkUpdExitFilter.Size = new System.Drawing.Size(223, 17);
			this._chkUpdExitFilter.TabIndex = 9;
			this._chkUpdExitFilter.Text = "Direct spots zoeken na opslaan van filters";
			this._chkUpdExitFilter.UseVisualStyleBackColor = true;
			this._numMaxDBRegels.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			
			this._numMaxDBRegels.Increment = new decimal(new int[4] { 100, 0, 0, 0 });
			this._numMaxDBRegels.Location = new System.Drawing.Point(13, 96);
			this._numMaxDBRegels.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
			this._numMaxDBRegels.Minimum = new decimal(new int[4] { 100, 0, 0, 0 });
			this._numMaxDBRegels.Name = "numMaxDBRegels";
			
			this._numMaxDBRegels.Size = new System.Drawing.Size(72, 20);
			this._numMaxDBRegels.TabIndex = 4;
			this._numMaxDBRegels.Value = new decimal(new int[4] { 2000, 0, 0, 0 });
			this._chkStartInSystray.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._chkStartInSystray.AutoSize = true;
			
			this._chkStartInSystray.Location = new System.Drawing.Point(13, 250);
			this._chkStartInSystray.Name = "chkStartInSystray";
			
			this._chkStartInSystray.Size = new System.Drawing.Size(235, 17);
			this._chkStartInSystray.TabIndex = 8;
			this._chkStartInSystray.Text = "Opstarten in system tray ( icon rechts onder )";
			this._chkStartInSystray.UseVisualStyleBackColor = true;
			this._Label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._Label1.AutoSize = true;
			
			this._Label1.Location = new System.Drawing.Point(13, 129);
			
			this._Label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label1.Name = "Label1";
			
			this._Label1.Size = new System.Drawing.Size(205, 13);
			this._Label1.TabIndex = 31;
			this._Label1.Text = "Zoeken in spots vanaf aantal dagen terug";
			this._numMaxDagen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this._numMaxDagen.Location = new System.Drawing.Point(13, 145);
			this._numMaxDagen.Maximum = new decimal(new int[4] { 365, 0, 0, 0 });
			this._numMaxDagen.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this._numMaxDagen.Name = "numMaxDagen";
			
			this._numMaxDagen.Size = new System.Drawing.Size(72, 20);
			this._numMaxDagen.TabIndex = 5;
			this._numMaxDagen.Value = new decimal(new int[4] { 14, 0, 0, 0 });
			this._btnOpslaan.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			
			this._btnOpslaan.Location = new System.Drawing.Point(207, 3);
			this._btnOpslaan.Name = "btnOpslaan";
			
			this._btnOpslaan.Size = new System.Drawing.Size(100, 26);
			this._btnOpslaan.TabIndex = 1;
			this._btnOpslaan.Text = "Opslaan";
			this._btnOpslaan.UseVisualStyleBackColor = true;
			this._btnAnnuleren.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this._btnAnnuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			
			this._btnAnnuleren.Location = new System.Drawing.Point(313, 3);
			this._btnAnnuleren.Name = "btnAnnuleren";
			
			this._btnAnnuleren.Size = new System.Drawing.Size(100, 26);
			this._btnAnnuleren.TabIndex = 0;
			this._btnAnnuleren.Text = "Annuleren";
			this._btnAnnuleren.UseVisualStyleBackColor = true;
			this._Panel1.Controls.Add(this._btnReset);
			this._Panel1.Controls.Add(this._btnAnnuleren);
			this._Panel1.Controls.Add(this._btnOpslaan);
			
			this._Panel1.Location = new System.Drawing.Point(9, 461);
			this._Panel1.Name = "Panel1";
			
			this._Panel1.Size = new System.Drawing.Size(416, 32);
			this._Panel1.TabIndex = 29;
			this._btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			
			this._btnReset.Location = new System.Drawing.Point(3, 3);
			this._btnReset.Name = "btnReset";
			
			this._btnReset.Size = new System.Drawing.Size(100, 26);
			this._btnReset.TabIndex = 2;
			this._btnReset.Text = "Reset";
			this._btnReset.UseVisualStyleBackColor = true;
			this._TabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._TabControl1.Controls.Add(this._TabPage1);
			this._TabControl1.Controls.Add(this._TabPage2);
			this._TabControl1.Controls.Add(this._TabPage4);
			
			this._TabControl1.Location = new System.Drawing.Point(9, 9);
			this._TabControl1.Name = "TabControl1";
			this._TabControl1.SelectedIndex = 0;
			
			this._TabControl1.Size = new System.Drawing.Size(416, 446);
			this._TabControl1.TabIndex = 3;
			this._TabPage1.Controls.Add(this._lblHelpAlgemeen);
			this._TabPage1.Controls.Add(this._chkMelding);
			this._TabPage1.Controls.Add(this._txtGrabNZB);
			this._TabPage1.Controls.Add(this._Label3);
			this._TabPage1.Controls.Add(this._Label2);
			this._TabPage1.Controls.Add(this._numMaxDagen);
			this._TabPage1.Controls.Add(this._chkGridLines);
			this._TabPage1.Controls.Add(this._Label1);
			this._TabPage1.Controls.Add(this._chkColHAutoSize);
			this._TabPage1.Controls.Add(this._chkStartInSystray);
			this._TabPage1.Controls.Add(this._numMaxDBRegels);
			this._TabPage1.Controls.Add(this._chkTopMost);
			this._TabPage1.Controls.Add(this._chkUpdExitFilter);
			this._TabPage1.Controls.Add(this._chkBoot);
			
			this._TabPage1.Location = new System.Drawing.Point(4, 22);
			this._TabPage1.Name = "TabPage1";
			
			this._TabPage1.Padding = new System.Windows.Forms.Padding(10);
			
			this._TabPage1.Size = new System.Drawing.Size(408, 420);
			this._TabPage1.TabIndex = 0;
			this._TabPage1.Text = "Algemeen";
			this._TabPage1.UseVisualStyleBackColor = true;
			this._lblHelpAlgemeen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._lblHelpAlgemeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			
			this._lblHelpAlgemeen.Location = new System.Drawing.Point(13, 10);
			this._lblHelpAlgemeen.Name = "lblHelpAlgemeen";
			
			this._lblHelpAlgemeen.Size = new System.Drawing.Size(382, 60);
			this._lblHelpAlgemeen.TabIndex = 52;
			this._chkMelding.AutoSize = true;
			
			this._chkMelding.Location = new System.Drawing.Point(13, 365);
			this._chkMelding.Name = "chkMelding";
			
			this._chkMelding.Size = new System.Drawing.Size(197, 17);
			this._chkMelding.TabIndex = 13;
			this._chkMelding.Text = "Geef alleen melding bij nieuwe spots";
			this._chkMelding.UseVisualStyleBackColor = true;
			this._TabPage2.Controls.Add(this._lblHelpKleuren);
			this._TabPage2.Controls.Add(this._picCat9);
			this._TabPage2.Controls.Add(this._picCat4);
			this._TabPage2.Controls.Add(this._picCat3);
			this._TabPage2.Controls.Add(this._picCat2);
			this._TabPage2.Controls.Add(this._picCat5);
			this._TabPage2.Controls.Add(this._picCat6);
			this._TabPage2.Controls.Add(this._picCat1);
			this._TabPage2.Controls.Add(this._Label10);
			this._TabPage2.Controls.Add(this._Label8);
			this._TabPage2.Controls.Add(this._Label27);
			this._TabPage2.Controls.Add(this._Label23);
			this._TabPage2.Controls.Add(this._Label19);
			this._TabPage2.Controls.Add(this._Label15);
			this._TabPage2.Controls.Add(this._Label6);
			
			this._TabPage2.Location = new System.Drawing.Point(4, 22);
			this._TabPage2.Name = "TabPage2";
			
			this._TabPage2.Padding = new System.Windows.Forms.Padding(10);
			
			this._TabPage2.Size = new System.Drawing.Size(408, 420);
			this._TabPage2.TabIndex = 2;
			this._TabPage2.Text = "Kleuren";
			this._TabPage2.UseVisualStyleBackColor = true;
			this._lblHelpKleuren.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._lblHelpKleuren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			
			this._lblHelpKleuren.Location = new System.Drawing.Point(13, 10);
			this._lblHelpKleuren.Name = "lblHelpKleuren";
			
			this._lblHelpKleuren.Size = new System.Drawing.Size(382, 60);
			this._lblHelpKleuren.TabIndex = 55;
			this._picCat9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picCat9.Cursor = System.Windows.Forms.Cursors.Hand;
			
			this._picCat9.Location = new System.Drawing.Point(20, 344);
			
			this._picCat9.Margin = new System.Windows.Forms.Padding(10);
			this._picCat9.Name = "picCat9";
			
			this._picCat9.Size = new System.Drawing.Size(24, 24);
			this._picCat9.TabIndex = 39;
			this._picCat9.TabStop = false;
			this._picCat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picCat4.Cursor = System.Windows.Forms.Cursors.Hand;
			
			this._picCat4.Location = new System.Drawing.Point(20, 300);
			
			this._picCat4.Margin = new System.Windows.Forms.Padding(10);
			this._picCat4.Name = "picCat4";
			
			this._picCat4.Size = new System.Drawing.Size(24, 24);
			this._picCat4.TabIndex = 38;
			this._picCat4.TabStop = false;
			this._picCat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picCat3.Cursor = System.Windows.Forms.Cursors.Hand;
			
			this._picCat3.Location = new System.Drawing.Point(20, 256);
			
			this._picCat3.Margin = new System.Windows.Forms.Padding(10);
			this._picCat3.Name = "picCat3";
			
			this._picCat3.Size = new System.Drawing.Size(24, 24);
			this._picCat3.TabIndex = 37;
			this._picCat3.TabStop = false;
			this._picCat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picCat2.Cursor = System.Windows.Forms.Cursors.Hand;
			
			this._picCat2.Location = new System.Drawing.Point(20, 212);
			
			this._picCat2.Margin = new System.Windows.Forms.Padding(10);
			this._picCat2.Name = "picCat2";
			
			this._picCat2.Size = new System.Drawing.Size(24, 24);
			this._picCat2.TabIndex = 36;
			this._picCat2.TabStop = false;
			this._picCat5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picCat5.Cursor = System.Windows.Forms.Cursors.Hand;
			
			this._picCat5.Location = new System.Drawing.Point(20, 168);
			
			this._picCat5.Margin = new System.Windows.Forms.Padding(10);
			this._picCat5.Name = "picCat5";
			
			this._picCat5.Size = new System.Drawing.Size(24, 24);
			this._picCat5.TabIndex = 35;
			this._picCat5.TabStop = false;
			this._picCat6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picCat6.Cursor = System.Windows.Forms.Cursors.Hand;
			
			this._picCat6.Location = new System.Drawing.Point(20, 124);
			
			this._picCat6.Margin = new System.Windows.Forms.Padding(10);
			this._picCat6.Name = "picCat6";
			
			this._picCat6.Size = new System.Drawing.Size(24, 24);
			this._picCat6.TabIndex = 34;
			this._picCat6.TabStop = false;
			this._picCat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._picCat1.Cursor = System.Windows.Forms.Cursors.Hand;
			
			this._picCat1.Location = new System.Drawing.Point(20, 80);
			
			this._picCat1.Margin = new System.Windows.Forms.Padding(10);
			this._picCat1.Name = "picCat1";
			
			this._picCat1.Size = new System.Drawing.Size(24, 24);
			this._picCat1.TabIndex = 30;
			this._picCat1.TabStop = false;
			
			this._Label10.Location = new System.Drawing.Point(57, 168);
			this._Label10.Name = "Label10";
			
			this._Label10.Size = new System.Drawing.Size(338, 24);
			this._Label10.TabIndex = 33;
			this._Label10.Text = "Achtergrond kleur voor nieuwe spots in de categorie boeken";
			this._Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			
			this._Label8.Location = new System.Drawing.Point(57, 124);
			this._Label8.Name = "Label8";
			
			this._Label8.Size = new System.Drawing.Size(338, 24);
			this._Label8.TabIndex = 32;
			this._Label8.Text = "Achtergrond kleur voor nieuwe spots in de categorie series";
			this._Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			
			this._Label27.Location = new System.Drawing.Point(57, 344);
			this._Label27.Name = "Label27";
			
			this._Label27.Size = new System.Drawing.Size(338, 24);
			this._Label27.TabIndex = 31;
			this._Label27.Text = "Achtergrond kleur voor nieuwe spots in de categorie erotiek";
			this._Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			
			this._Label23.Location = new System.Drawing.Point(57, 300);
			this._Label23.Name = "Label23";
			
			this._Label23.Size = new System.Drawing.Size(338, 24);
			this._Label23.TabIndex = 24;
			this._Label23.Text = "Achtergrond kleur voor nieuwe spots in de categorie software";
			this._Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			
			this._Label19.Location = new System.Drawing.Point(57, 256);
			this._Label19.Name = "Label19";
			
			this._Label19.Size = new System.Drawing.Size(338, 24);
			this._Label19.TabIndex = 17;
			this._Label19.Text = "Achtergrond kleur voor nieuwe spots in de categorie spellen";
			this._Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			
			this._Label15.Location = new System.Drawing.Point(57, 212);
			this._Label15.Name = "Label15";
			
			this._Label15.Size = new System.Drawing.Size(338, 24);
			this._Label15.TabIndex = 10;
			this._Label15.Text = "Achtergrond kleur voor nieuwe spots in de categorie muziek";
			this._Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			
			this._Label6.Location = new System.Drawing.Point(57, 80);
			this._Label6.Name = "Label6";
			
			this._Label6.Size = new System.Drawing.Size(338, 24);
			this._Label6.TabIndex = 0;
			this._Label6.Text = "Achtergrond kleur voor nieuwe spots in de categorie films";
			this._Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._TabPage4.Controls.Add(this._lblHelpDownload);
			this._TabPage4.Controls.Add(this._GroupBox2);
			this._TabPage4.Controls.Add(this._GroupBox1);
			
			this._TabPage4.Location = new System.Drawing.Point(4, 22);
			this._TabPage4.Name = "TabPage4";
			
			this._TabPage4.Padding = new System.Windows.Forms.Padding(10);
			
			this._TabPage4.Size = new System.Drawing.Size(408, 420);
			this._TabPage4.TabIndex = 5;
			this._TabPage4.Text = "Download";
			this._TabPage4.UseVisualStyleBackColor = true;
			this._lblHelpDownload.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._lblHelpDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			
			this._lblHelpDownload.Location = new System.Drawing.Point(13, 10);
			this._lblHelpDownload.Name = "lblHelpDownload";
			
			this._lblHelpDownload.Size = new System.Drawing.Size(382, 60);
			this._lblHelpDownload.TabIndex = 56;
			this._GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._GroupBox2.Controls.Add(this._opnNZBuseAPI);
			this._GroupBox2.Controls.Add(this._opnNZBnoAPI);
			this._GroupBox2.Controls.Add(this._Label7);
			this._GroupBox2.Controls.Add(this._txtNZBserver);
			this._GroupBox2.Controls.Add(this._lblNZBtest);
			this._GroupBox2.Controls.Add(this._Label9);
			this._GroupBox2.Controls.Add(this._txtNZBapikey);
			
			this._GroupBox2.Location = new System.Drawing.Point(13, 215);
			this._GroupBox2.Name = "GroupBox2";
			
			this._GroupBox2.Padding = new System.Windows.Forms.Padding(10);
			
			this._GroupBox2.Size = new System.Drawing.Size(382, 184);
			this._GroupBox2.TabIndex = 18;
			this._GroupBox2.TabStop = false;
			this._GroupBox2.Text = "Spotweb";
			this._opnNZBuseAPI.AutoSize = true;
			
			this._opnNZBuseAPI.Location = new System.Drawing.Point(13, 131);
			
			this._opnNZBuseAPI.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this._opnNZBuseAPI.Name = "opnNZBuseAPI";
			
			this._opnNZBuseAPI.Size = new System.Drawing.Size(125, 17);
			this._opnNZBuseAPI.TabIndex = 22;
			this._opnNZBuseAPI.Text = "API sleutel gebruiken";
			this._opnNZBuseAPI.UseVisualStyleBackColor = true;
			this._opnNZBnoAPI.AutoSize = true;
			
			this._opnNZBnoAPI.Location = new System.Drawing.Point(13, 154);
			this._opnNZBnoAPI.Name = "opnNZBnoAPI";
			
			this._opnNZBnoAPI.Size = new System.Drawing.Size(145, 17);
			this._opnNZBnoAPI.TabIndex = 23;
			this._opnNZBnoAPI.Text = "API sleutel niet gebruiken";
			this._opnNZBnoAPI.UseVisualStyleBackColor = true;
			this._Label7.AutoSize = true;
			
			this._Label7.Location = new System.Drawing.Point(13, 33);
			
			this._Label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label7.Name = "Label7";
			
			this._Label7.Size = new System.Drawing.Size(115, 13);
			this._Label7.TabIndex = 37;
			this._Label7.Text = "Spotweb server locatie";
			this._txtNZBserver.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			
			this._txtNZBserver.Location = new System.Drawing.Point(13, 49);
			this._txtNZBserver.Name = "txtNZBserver";
			
			this._txtNZBserver.Size = new System.Drawing.Size(356, 20);
			this._txtNZBserver.TabIndex = 19;
			this._lblNZBtest.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this._lblNZBtest.AutoSize = true;
			this._lblNZBtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			
			this._lblNZBtest.Location = new System.Drawing.Point(341, 33);
			
			this._lblNZBtest.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._lblNZBtest.Name = "lblNZBtest";
			
			this._lblNZBtest.Size = new System.Drawing.Size(28, 13);
			this._lblNZBtest.TabIndex = 21;
			this._lblNZBtest.TabStop = true;
			this._lblNZBtest.Text = "Test";
			this._lblNZBtest.VisitedLinkColor = System.Drawing.Color.Blue;
			this._Label9.AutoSize = true;
			
			this._Label9.Location = new System.Drawing.Point(13, 82);
			
			this._Label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label9.Name = "Label9";
			
			this._Label9.Size = new System.Drawing.Size(57, 13);
			this._Label9.TabIndex = 41;
			this._Label9.Text = "API sleutel";
			this._txtNZBapikey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			
			this._txtNZBapikey.Location = new System.Drawing.Point(13, 98);
			this._txtNZBapikey.Name = "txtNZBapikey";
			
			this._txtNZBapikey.Size = new System.Drawing.Size(356, 20);
			this._txtNZBapikey.TabIndex = 20;
			this._GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._GroupBox1.Controls.Add(this._Label4);
			this._GroupBox1.Controls.Add(this._txtSABserver);
			this._GroupBox1.Controls.Add(this._lblSABtest);
			this._GroupBox1.Controls.Add(this._Label5);
			this._GroupBox1.Controls.Add(this._txtSABapikey);
			
			this._GroupBox1.Location = new System.Drawing.Point(13, 73);
			this._GroupBox1.Name = "GroupBox1";
			
			this._GroupBox1.Padding = new System.Windows.Forms.Padding(10);
			
			this._GroupBox1.Size = new System.Drawing.Size(382, 136);
			this._GroupBox1.TabIndex = 14;
			this._GroupBox1.TabStop = false;
			this._GroupBox1.Text = "SABnzbd";
			this._Label4.AutoSize = true;
			
			this._Label4.Location = new System.Drawing.Point(13, 33);
			
			this._Label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label4.Name = "Label4";
			
			this._Label4.Size = new System.Drawing.Size(117, 13);
			this._Label4.TabIndex = 31;
			this._Label4.Text = "SABnzbd server locatie";
			this._txtSABserver.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			
			this._txtSABserver.Location = new System.Drawing.Point(13, 49);
			this._txtSABserver.Name = "txtSABserver";
			
			this._txtSABserver.Size = new System.Drawing.Size(356, 20);
			this._txtSABserver.TabIndex = 15;
			this._lblSABtest.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this._lblSABtest.AutoSize = true;
			this._lblSABtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			
			this._lblSABtest.Location = new System.Drawing.Point(341, 33);
			
			this._lblSABtest.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._lblSABtest.Name = "lblSABtest";
			
			this._lblSABtest.Size = new System.Drawing.Size(28, 13);
			this._lblSABtest.TabIndex = 17;
			this._lblSABtest.TabStop = true;
			this._lblSABtest.Text = "Test";
			this._lblSABtest.VisitedLinkColor = System.Drawing.Color.Blue;
			this._Label5.AutoSize = true;
			
			this._Label5.Location = new System.Drawing.Point(13, 82);
			
			this._Label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label5.Name = "Label5";
			
			this._Label5.Size = new System.Drawing.Size(57, 13);
			this._Label5.TabIndex = 33;
			this._Label5.Text = "API sleutel";
			this._txtSABapikey.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			
			this._txtSABapikey.Location = new System.Drawing.Point(13, 98);
			this._txtSABapikey.Name = "txtSABapikey";
			
			this._txtSABapikey.Size = new System.Drawing.Size(356, 20);
			this._txtSABapikey.TabIndex = 16;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._btnAnnuleren;
			this.ClientSize = new System.Drawing.Size(434, 502);
			this.Controls.Add(this._TabControl1);
			this.Controls.Add(this._Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(450, 540);
			this.Name = "frmInstellingen";
			this.Padding = new System.Windows.Forms.Padding(6);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Instellingen";
			this._txtGrabNZB.LostFocus += new System.EventHandler(this.txtGrabNZB_LostFocus);
			this._btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
			this._btnReset.Click += new System.EventHandler(this.btnReset_Click);
			this._picCat1.Click += new System.EventHandler(this.picCat1_Click);
			this._picCat9.Click += new System.EventHandler(this.picCat9_Click);
			this._picCat4.Click += new System.EventHandler(this.picCat4_Click);
			this._picCat3.Click += new System.EventHandler(this.picCat3_Click);
			this._picCat2.Click += new System.EventHandler(this.picCat2_Click);
			this._picCat5.Click += new System.EventHandler(this.picCat5_Click);
			this._picCat6.Click += new System.EventHandler(this.picCat6_Click);
			this._txtNZBserver.LostFocus += new System.EventHandler(this.txtNZBserver_LostFocus);
			this._lblNZBtest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNZBtest_LinkClicked);
			this._txtSABserver.LostFocus += new System.EventHandler(this.txtSABserver_LostFocus);
			this._lblSABtest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSABtest_LinkClicked);
			((System.ComponentModel.ISupportInitialize)this._numMaxDBRegels).EndInit();
			((System.ComponentModel.ISupportInitialize)this._numMaxDagen).EndInit();
			this._Panel1.ResumeLayout(false);
			this._TabControl1.ResumeLayout(false);
			this._TabPage1.ResumeLayout(false);
			this._TabPage1.PerformLayout();
			this._TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this._picCat9).EndInit();
			((System.ComponentModel.ISupportInitialize)this._picCat4).EndInit();
			((System.ComponentModel.ISupportInitialize)this._picCat3).EndInit();
			((System.ComponentModel.ISupportInitialize)this._picCat2).EndInit();
			((System.ComponentModel.ISupportInitialize)this._picCat5).EndInit();
			((System.ComponentModel.ISupportInitialize)this._picCat6).EndInit();
			((System.ComponentModel.ISupportInitialize)this._picCat1).EndInit();
			this._TabPage4.ResumeLayout(false);
			this._GroupBox2.ResumeLayout(false);
			this._GroupBox2.PerformLayout();
			this._GroupBox1.ResumeLayout(false);
			this._GroupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
	}
}
