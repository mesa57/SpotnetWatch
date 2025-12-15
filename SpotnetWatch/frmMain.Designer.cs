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
	public partial class frmMain : Form
	{
		private IContainer components = null;

	[AccessedThroughProperty("lstSpots")]
		private ListView _lstSpots;

		[AccessedThroughProperty("colSpots1")]
		private ColumnHeader _colSpots1;

		[AccessedThroughProperty("colSpots2")]
		private ColumnHeader _colSpots2;

		[AccessedThroughProperty("colSpots3")]
		private ColumnHeader _colSpots3;

		[AccessedThroughProperty("colSpots4")]
		private ColumnHeader _colSpots4;

		[AccessedThroughProperty("colSpots5")]
		private ColumnHeader _colSpots5;

		[AccessedThroughProperty("tsMenu")]
		private MenuStrip _tsMenu;

		[AccessedThroughProperty("tsMenu_Bestand")]
		private ToolStripMenuItem _tsMenu_Bestand;

		[AccessedThroughProperty("tsMenu_Filters")]
		private ToolStripMenuItem _tsMenu_Filters;

		[AccessedThroughProperty("tsMenu_Extra")]
		private ToolStripMenuItem _tsMenu_Extra;

		[AccessedThroughProperty("tsMenu_Help")]
		private ToolStripMenuItem _tsMenu_Help;

		[AccessedThroughProperty("systrayIcon")]
		private NotifyIcon _systrayIcon;

		[AccessedThroughProperty("systrayMenu")]
		private ContextMenuStrip _systrayMenu;

		[AccessedThroughProperty("systrayMenu_Openen")]
		private ToolStripMenuItem _systrayMenu_Openen;

		[AccessedThroughProperty("systrayMenu_Sep1")]
		private ToolStripSeparator _systrayMenu_Sep1;

		[AccessedThroughProperty("systrayMenu_Afsluiten")]
		private ToolStripMenuItem _systrayMenu_Afsluiten;

		[AccessedThroughProperty("tsMenu_Bestand_Monitor")]
		private ToolStripMenuItem _tsMenu_Bestand_Monitor;

		[AccessedThroughProperty("tsMenu_Bestand_Sep1")]
		private ToolStripSeparator _tsMenu_Bestand_Sep1;

		[AccessedThroughProperty("tsMenu_Bestand_Afsluiten")]
		private ToolStripMenuItem _tsMenu_Bestand_Afsluiten;

		[AccessedThroughProperty("tmrDBWatch")]
		private Timer _tmrDBWatch;

		[AccessedThroughProperty("tsMenu_Extra_Instellingen")]
		private ToolStripMenuItem _tsMenu_Extra_Instellingen;

		[AccessedThroughProperty("barStatus")]
		private StatusStrip _barStatus;

		[AccessedThroughProperty("barStatus_lbl1")]
		private ToolStripStatusLabel _barStatus_lbl1;

		[AccessedThroughProperty("tsMenu_Filters_Beheren")]
		private ToolStripMenuItem _tsMenu_Filters_Beheren;

		[AccessedThroughProperty("tsMenu_Help_Info")]
		private ToolStripMenuItem _tsMenu_Help_Info;

		[AccessedThroughProperty("barStatusProg")]
		private ToolStripProgressBar _barStatusProg;

		[AccessedThroughProperty("imgList")]
		private ImageList _imgList;

		[AccessedThroughProperty("rbm_lstSpots")]
		private ContextMenuStrip _rbm_lstSpots;

		[AccessedThroughProperty("rbm_lstSpots_Download")]
		private ToolStripMenuItem _rbm_lstSpots_Download;

		[AccessedThroughProperty("rbm_lstSpots_Openen")]
		private ToolStripMenuItem _rbm_lstSpots_Openen;

		[AccessedThroughProperty("rbm_lstSpots_Sep1")]
		private ToolStripSeparator _rbm_lstSpots_Sep1;

		[AccessedThroughProperty("tsMenu_Spots")]
		private ToolStripMenuItem _tsMenu_Spots;

		[AccessedThroughProperty("tsMenu_Spots_Markeren")]
		private ToolStripMenuItem _tsMenu_Spots_Markeren;

		[AccessedThroughProperty("iconList")]
		private ImageList _iconList;

		[AccessedThroughProperty("bgDBScanner")]
		private BackgroundWorker _bgDBScanner;

		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		[AccessedThroughProperty("tsMenu_Spots_Download_Geschiedenis")]
		private ToolStripMenuItem _tsMenu_Spots_Download_Geschiedenis;

		private ListViewColumnSorter lvwColumnSorter;

		internal virtual ListView lstSpots
		{
			get
			{
				return _lstSpots;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstSpots_DoubleClick;
				ColumnClickEventHandler value3 = lstSpots_ColumnClick;
				if (_lstSpots != null)
				{
					_lstSpots.DoubleClick -= value2;
					_lstSpots.ColumnClick -= value3;
				}
				_lstSpots = value;
				if (_lstSpots != null)
				{
					_lstSpots.DoubleClick += value2;
					_lstSpots.ColumnClick += value3;
				}
			}
		}

		internal virtual ColumnHeader colSpots1
		{
			get
			{
				return _colSpots1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colSpots1 = value;
			}
		}

		internal virtual ColumnHeader colSpots2
		{
			get
			{
				return _colSpots2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colSpots2 = value;
			}
		}

		internal virtual ColumnHeader colSpots3
		{
			get
			{
				return _colSpots3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colSpots3 = value;
			}
		}

		internal virtual ColumnHeader colSpots4
		{
			get
			{
				return _colSpots4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colSpots4 = value;
			}
		}

		internal virtual ColumnHeader colSpots5
		{
			get
			{
				return _colSpots5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colSpots5 = value;
			}
		}

		internal virtual MenuStrip tsMenu
		{
			get
			{
				return _tsMenu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_tsMenu = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Bestand
		{
			get
			{
				return _tsMenu_Bestand;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_tsMenu_Bestand = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Filters
		{
			get
			{
				return _tsMenu_Filters;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_tsMenu_Filters = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Extra
		{
			get
			{
				return _tsMenu_Extra;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_tsMenu_Extra = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Help
		{
			get
			{
				return _tsMenu_Help;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_tsMenu_Help = value;
			}
		}

		internal virtual NotifyIcon systrayIcon
		{
			get
			{
				return _systrayIcon;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = systrayIcon_MouseDoubleClick;
				if (_systrayIcon != null)
				{
					_systrayIcon.MouseDoubleClick -= value2;
				}
				_systrayIcon = value;
				if (_systrayIcon != null)
				{
					_systrayIcon.MouseDoubleClick += value2;
				}
			}
		}

		internal virtual ContextMenuStrip systrayMenu
		{
			get
			{
				return _systrayMenu;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_systrayMenu = value;
			}
		}

		internal virtual ToolStripMenuItem systrayMenu_Openen
		{
			get
			{
				return _systrayMenu_Openen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = systrayMenu_Openen_Click;
				if (_systrayMenu_Openen != null)
				{
					_systrayMenu_Openen.Click -= value2;
				}
				_systrayMenu_Openen = value;
				if (_systrayMenu_Openen != null)
				{
					_systrayMenu_Openen.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator systrayMenu_Sep1
		{
			get
			{
				return _systrayMenu_Sep1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_systrayMenu_Sep1 = value;
			}
		}

		internal virtual ToolStripMenuItem systrayMenu_Afsluiten
		{
			get
			{
				return _systrayMenu_Afsluiten;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = systrayMenu_Afsluiten_Click;
				if (_systrayMenu_Afsluiten != null)
				{
					_systrayMenu_Afsluiten.Click -= value2;
				}
				_systrayMenu_Afsluiten = value;
				if (_systrayMenu_Afsluiten != null)
				{
					_systrayMenu_Afsluiten.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Bestand_Monitor
		{
			get
			{
				return _tsMenu_Bestand_Monitor;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = tsMenu_Bestand_Monitor_Click;
				if (_tsMenu_Bestand_Monitor != null)
				{
					_tsMenu_Bestand_Monitor.Click -= value2;
				}
				_tsMenu_Bestand_Monitor = value;
				if (_tsMenu_Bestand_Monitor != null)
				{
					_tsMenu_Bestand_Monitor.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator tsMenu_Bestand_Sep1
		{
			get
			{
				return _tsMenu_Bestand_Sep1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_tsMenu_Bestand_Sep1 = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Bestand_Afsluiten
		{
			get
			{
				return _tsMenu_Bestand_Afsluiten;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = tsMenu_Bestand_Afsluiten_Click;
				if (_tsMenu_Bestand_Afsluiten != null)
				{
					_tsMenu_Bestand_Afsluiten.Click -= value2;
				}
				_tsMenu_Bestand_Afsluiten = value;
				if (_tsMenu_Bestand_Afsluiten != null)
				{
					_tsMenu_Bestand_Afsluiten.Click += value2;
				}
			}
		}

		internal virtual Timer tmrDBWatch
		{
			get
			{
				return _tmrDBWatch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = tmrDBWatch_Tick;
				if (_tmrDBWatch != null)
				{
					_tmrDBWatch.Tick -= value2;
				}
				_tmrDBWatch = value;
				if (_tmrDBWatch != null)
				{
					_tmrDBWatch.Tick += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Extra_Instellingen
		{
			get
			{
				return _tsMenu_Extra_Instellingen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = tsMenu_Extra_Instellingen_Click;
				if (_tsMenu_Extra_Instellingen != null)
				{
					_tsMenu_Extra_Instellingen.Click -= value2;
				}
				_tsMenu_Extra_Instellingen = value;
				if (_tsMenu_Extra_Instellingen != null)
				{
					_tsMenu_Extra_Instellingen.Click += value2;
				}
			}
		}

		internal virtual StatusStrip barStatus
		{
			get
			{
				return _barStatus;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_barStatus = value;
			}
		}

		internal virtual ToolStripStatusLabel barStatus_lbl1
		{
			get
			{
				return _barStatus_lbl1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_barStatus_lbl1 = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Filters_Beheren
		{
			get
			{
				return _tsMenu_Filters_Beheren;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = tsMenu_Filters_Beheren_Click;
				if (_tsMenu_Filters_Beheren != null)
				{
					_tsMenu_Filters_Beheren.Click -= value2;
				}
				_tsMenu_Filters_Beheren = value;
				if (_tsMenu_Filters_Beheren != null)
				{
					_tsMenu_Filters_Beheren.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Help_Info
		{
			get
			{
				return _tsMenu_Help_Info;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = tsMenu_Help_Info_Click;
				if (_tsMenu_Help_Info != null)
				{
					_tsMenu_Help_Info.Click -= value2;
				}
				_tsMenu_Help_Info = value;
				if (_tsMenu_Help_Info != null)
				{
					_tsMenu_Help_Info.Click += value2;
				}
			}
		}

		internal virtual ToolStripProgressBar barStatusProg
		{
			get
			{
				return _barStatusProg;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_barStatusProg = value;
			}
		}

		internal virtual ImageList imgList
		{
			get
			{
				return _imgList;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_imgList = value;
			}
		}

		internal virtual ContextMenuStrip rbm_lstSpots
		{
			get
			{
				return _rbm_lstSpots;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_rbm_lstSpots = value;
			}
		}

		internal virtual ToolStripMenuItem rbm_lstSpots_Download
		{
			get
			{
				return _rbm_lstSpots_Download;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = rbm_lstSpots_Download_Click;
				if (_rbm_lstSpots_Download != null)
				{
					_rbm_lstSpots_Download.Click -= value2;
				}
				_rbm_lstSpots_Download = value;
				if (_rbm_lstSpots_Download != null)
				{
					_rbm_lstSpots_Download.Click += value2;
				}
			}
		}

		internal virtual ToolStripMenuItem rbm_lstSpots_Openen
		{
			get
			{
				return _rbm_lstSpots_Openen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = rbm_lstSpots_Openen_Click;
				if (_rbm_lstSpots_Openen != null)
				{
					_rbm_lstSpots_Openen.Click -= value2;
				}
				_rbm_lstSpots_Openen = value;
				if (_rbm_lstSpots_Openen != null)
				{
					_rbm_lstSpots_Openen.Click += value2;
				}
			}
		}

		internal virtual ToolStripSeparator rbm_lstSpots_Sep1
		{
			get
			{
				return _rbm_lstSpots_Sep1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_rbm_lstSpots_Sep1 = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Spots
		{
			get
			{
				return _tsMenu_Spots;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_tsMenu_Spots = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Spots_Markeren
		{
			get
			{
				return _tsMenu_Spots_Markeren;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = tsMenu_Spots_Markeren_Click;
				if (_tsMenu_Spots_Markeren != null)
				{
					_tsMenu_Spots_Markeren.Click -= value2;
				}
				_tsMenu_Spots_Markeren = value;
				if (_tsMenu_Spots_Markeren != null)
				{
					_tsMenu_Spots_Markeren.Click += value2;
				}
			}
		}

		internal virtual ImageList iconList
		{
			get
			{
				return _iconList;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_iconList = value;
			}
		}

		internal virtual BackgroundWorker bgDBScanner
		{
			get
			{
				return _bgDBScanner;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				RunWorkerCompletedEventHandler value2 = bgDBScanner_RunWorkerCompleted;
				DoWorkEventHandler value3 = bgDBScanner_DoWork;
				ProgressChangedEventHandler value4 = bgDBScanner_ProgressChanged;
				if (_bgDBScanner != null)
				{
					_bgDBScanner.RunWorkerCompleted -= value2;
					_bgDBScanner.DoWork -= value3;
					_bgDBScanner.ProgressChanged -= value4;
				}
				_bgDBScanner = value;
				if (_bgDBScanner != null)
				{
					_bgDBScanner.RunWorkerCompleted += value2;
					_bgDBScanner.DoWork += value3;
					_bgDBScanner.ProgressChanged += value4;
				}
			}
		}

		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return _ToolStripSeparator1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_ToolStripSeparator1 = value;
			}
		}

		internal virtual ToolStripMenuItem tsMenu_Spots_Download_Geschiedenis
		{
			get
			{
				return _tsMenu_Spots_Download_Geschiedenis;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = tsMenu_Spots_Download_Geschiedenis_Click;
				if (_tsMenu_Spots_Download_Geschiedenis != null)
				{
					_tsMenu_Spots_Download_Geschiedenis.Click -= value2;
				}
				_tsMenu_Spots_Download_Geschiedenis = value;
				if (_tsMenu_Spots_Download_Geschiedenis != null)
				{
					_tsMenu_Spots_Download_Geschiedenis.Click += value2;
				}
			}
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpotnetWatch.frmMain));
			this._lstSpots = new System.Windows.Forms.ListView();
			this._colSpots1 = new System.Windows.Forms.ColumnHeader();
			this._colSpots2 = new System.Windows.Forms.ColumnHeader();
			this._colSpots3 = new System.Windows.Forms.ColumnHeader();
			this._colSpots4 = new System.Windows.Forms.ColumnHeader();
			this._colSpots5 = new System.Windows.Forms.ColumnHeader();
			this._rbm_lstSpots = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._rbm_lstSpots_Openen = new System.Windows.Forms.ToolStripMenuItem();
			this._rbm_lstSpots_Sep1 = new System.Windows.Forms.ToolStripSeparator();
			this._rbm_lstSpots_Download = new System.Windows.Forms.ToolStripMenuItem();
			this._imgList = new System.Windows.Forms.ImageList(this.components);
			this._tsMenu = new System.Windows.Forms.MenuStrip();
			this._tsMenu_Bestand = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Bestand_Monitor = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Bestand_Sep1 = new System.Windows.Forms.ToolStripSeparator();
			this._tsMenu_Bestand_Afsluiten = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Filters = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Filters_Beheren = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Spots = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Spots_Markeren = new System.Windows.Forms.ToolStripMenuItem();
			this._ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._tsMenu_Spots_Download_Geschiedenis = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Extra = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Extra_Instellingen = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
			this._tsMenu_Help_Info = new System.Windows.Forms.ToolStripMenuItem();
			this._systrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this._systrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._systrayMenu_Openen = new System.Windows.Forms.ToolStripMenuItem();
			this._systrayMenu_Sep1 = new System.Windows.Forms.ToolStripSeparator();
			this._systrayMenu_Afsluiten = new System.Windows.Forms.ToolStripMenuItem();
			this._tmrDBWatch = new System.Windows.Forms.Timer(this.components);
			this._barStatus = new System.Windows.Forms.StatusStrip();
			this._barStatusProg = new System.Windows.Forms.ToolStripProgressBar();
			this._barStatus_lbl1 = new System.Windows.Forms.ToolStripStatusLabel();
			this._iconList = new System.Windows.Forms.ImageList(this.components);
			this._bgDBScanner = new System.ComponentModel.BackgroundWorker();
			this._rbm_lstSpots.SuspendLayout();
			this._tsMenu.SuspendLayout();
			this._systrayMenu.SuspendLayout();
			this._barStatus.SuspendLayout();
			this.SuspendLayout();
			this._lstSpots.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lstSpots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5] { this._colSpots1, this._colSpots2, this._colSpots3, this._colSpots4, this._colSpots5 });
			this._lstSpots.ContextMenuStrip = this._rbm_lstSpots;
			this._lstSpots.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lstSpots.FullRowSelect = true;
			this._lstSpots.HideSelection = false;
			

			this._lstSpots.Location = new System.Drawing.Point(0, 24);
			this._lstSpots.MultiSelect = false;
			this._lstSpots.Name = "lstSpots";
			this._lstSpots.ShowItemToolTips = true;
			

			this._lstSpots.Size = new System.Drawing.Size(784, 516);
			this._lstSpots.SmallImageList = this._imgList;
			this._lstSpots.TabIndex = 1;
			this._lstSpots.UseCompatibleStateImageBehavior = false;
			this._lstSpots.View = System.Windows.Forms.View.Details;
			this._colSpots1.Text = "Titel";
			this._colSpots1.Width = 350;
			this._colSpots2.Text = "Afzender";
			this._colSpots2.Width = 100;
			this._colSpots3.Text = "Categorie";
			this._colSpots3.Width = 90;
			this._colSpots4.Text = "Formaat";
			this._colSpots4.Width = 90;
			this._colSpots5.Text = "Datum / Tijd";
			this._colSpots5.Width = 120;
			this._rbm_lstSpots.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this._rbm_lstSpots_Openen, this._rbm_lstSpots_Sep1, this._rbm_lstSpots_Download });
			this._rbm_lstSpots.Name = "mnuSpots";
			

			this._rbm_lstSpots.Size = new System.Drawing.Size(129, 54);
			this._rbm_lstSpots_Openen.Name = "rbm_lstSpots_Openen";
			

			this._rbm_lstSpots_Openen.Size = new System.Drawing.Size(128, 22);
			this._rbm_lstSpots_Openen.Text = "Openen";
			this._rbm_lstSpots_Sep1.Name = "rbm_lstSpots_Sep1";
			

			this._rbm_lstSpots_Sep1.Size = new System.Drawing.Size(125, 6);
			this._rbm_lstSpots_Download.Name = "rbm_lstSpots_Download";
			

			this._rbm_lstSpots_Download.Size = new System.Drawing.Size(128, 22);
			this._rbm_lstSpots_Download.Text = "Download";
			this._imgList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imgList.ImageStream");
			this._imgList.TransparentColor = System.Drawing.Color.Transparent;
			this._imgList.Images.SetKeyName(0, "100");
			this._imgList.Images.SetKeyName(1, "101");
			this._imgList.Images.SetKeyName(2, "102");
			this._imgList.Images.SetKeyName(3, "103");
			this._imgList.Images.SetKeyName(4, "104");
			this._imgList.Images.SetKeyName(5, "105");
			this._imgList.Images.SetKeyName(6, "106");
			this._imgList.Images.SetKeyName(7, "107");
			this._imgList.Images.SetKeyName(8, "108");
			this._imgList.Images.SetKeyName(9, "109");
			this._imgList.Images.SetKeyName(10, "110");
			this._imgList.Images.SetKeyName(11, "200");
			this._imgList.Images.SetKeyName(12, "201");
			this._imgList.Images.SetKeyName(13, "202");
			this._imgList.Images.SetKeyName(14, "203");
			this._imgList.Images.SetKeyName(15, "204");
			this._imgList.Images.SetKeyName(16, "205");
			this._imgList.Images.SetKeyName(17, "206");
			this._imgList.Images.SetKeyName(18, "207");
			this._imgList.Images.SetKeyName(19, "208");
			this._imgList.Images.SetKeyName(20, "300");
			this._imgList.Images.SetKeyName(21, "301");
			this._imgList.Images.SetKeyName(22, "302");
			this._imgList.Images.SetKeyName(23, "303");
			this._imgList.Images.SetKeyName(24, "304");
			this._imgList.Images.SetKeyName(25, "305");
			this._imgList.Images.SetKeyName(26, "306");
			this._imgList.Images.SetKeyName(27, "307");
			this._imgList.Images.SetKeyName(28, "308");
			this._imgList.Images.SetKeyName(29, "309");
			this._imgList.Images.SetKeyName(30, "310");
			this._imgList.Images.SetKeyName(31, "311");
			this._imgList.Images.SetKeyName(32, "312");
			this._imgList.Images.SetKeyName(33, "313");
			this._imgList.Images.SetKeyName(34, "314");
			this._imgList.Images.SetKeyName(35, "315");
			this._imgList.Images.SetKeyName(36, "400");
			this._imgList.Images.SetKeyName(37, "401");
			this._imgList.Images.SetKeyName(38, "402");
			this._imgList.Images.SetKeyName(39, "403");
			this._imgList.Images.SetKeyName(40, "404");
			this._imgList.Images.SetKeyName(41, "405");
			this._imgList.Images.SetKeyName(42, "406");
			this._imgList.Images.SetKeyName(43, "407");
			this._imgList.Images.SetKeyName(44, "500");
			this._imgList.Images.SetKeyName(45, "505");
			this._imgList.Images.SetKeyName(46, "600");
			this._imgList.Images.SetKeyName(47, "601");
			this._imgList.Images.SetKeyName(48, "602");
			this._imgList.Images.SetKeyName(49, "603");
			this._imgList.Images.SetKeyName(50, "604");
			this._imgList.Images.SetKeyName(51, "605");
			this._imgList.Images.SetKeyName(52, "606");
			this._imgList.Images.SetKeyName(53, "607");
			this._imgList.Images.SetKeyName(54, "608");
			this._imgList.Images.SetKeyName(55, "609");
			this._imgList.Images.SetKeyName(56, "610");
			this._imgList.Images.SetKeyName(57, "900");
			this._imgList.Images.SetKeyName(58, "901");
			this._imgList.Images.SetKeyName(59, "902");
			this._imgList.Images.SetKeyName(60, "903");
			this._tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { this._tsMenu_Bestand, this._tsMenu_Filters, this._tsMenu_Spots, this._tsMenu_Extra, this._tsMenu_Help });
			

			this._tsMenu.Location = new System.Drawing.Point(0, 0);
			this._tsMenu.Name = "tsMenu";
			

			this._tsMenu.Size = new System.Drawing.Size(784, 24);
			this._tsMenu.TabIndex = 10;
			this._tsMenu_Bestand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this._tsMenu_Bestand_Monitor, this._tsMenu_Bestand_Sep1, this._tsMenu_Bestand_Afsluiten });
			this._tsMenu_Bestand.Name = "tsMenu_Bestand";
			

			this._tsMenu_Bestand.Size = new System.Drawing.Size(61, 20);
			this._tsMenu_Bestand.Text = "Bestand";
			this._tsMenu_Bestand_Monitor.Name = "tsMenu_Bestand_Monitor";
			

			this._tsMenu_Bestand_Monitor.Size = new System.Drawing.Size(167, 22);
			this._tsMenu_Bestand_Monitor.Text = "Monitor database";
			this._tsMenu_Bestand_Sep1.Name = "tsMenu_Bestand_Sep1";
			

			this._tsMenu_Bestand_Sep1.Size = new System.Drawing.Size(164, 6);
			this._tsMenu_Bestand_Afsluiten.Name = "tsMenu_Bestand_Afsluiten";
			

			this._tsMenu_Bestand_Afsluiten.Size = new System.Drawing.Size(167, 22);
			this._tsMenu_Bestand_Afsluiten.Text = "Afsluiten";
			this._tsMenu_Filters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this._tsMenu_Filters_Beheren });
			this._tsMenu_Filters.Name = "tsMenu_Filters";
			

			this._tsMenu_Filters.Size = new System.Drawing.Size(50, 20);
			this._tsMenu_Filters.Text = "Filters";
			this._tsMenu_Filters_Beheren.Name = "tsMenu_Filters_Beheren";
			

			this._tsMenu_Filters_Beheren.Size = new System.Drawing.Size(117, 22);
			this._tsMenu_Filters_Beheren.Text = "Beheren";
			this._tsMenu_Spots.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this._tsMenu_Spots_Markeren, this._ToolStripSeparator1, this._tsMenu_Spots_Download_Geschiedenis });
			this._tsMenu_Spots.Name = "tsMenu_Spots";
			

			this._tsMenu_Spots.Size = new System.Drawing.Size(48, 20);
			this._tsMenu_Spots.Text = "Spots";
			this._tsMenu_Spots_Markeren.Name = "tsMenu_Spots_Markeren";
			

			this._tsMenu_Spots_Markeren.Size = new System.Drawing.Size(199, 22);
			this._tsMenu_Spots_Markeren.Text = "Markeren als gezien";
			this._ToolStripSeparator1.Name = "ToolStripSeparator1";
			

			this._ToolStripSeparator1.Size = new System.Drawing.Size(196, 6);
			this._tsMenu_Spots_Download_Geschiedenis.Name = "tsMenu_Spots_Download_Geschiedenis";
			

			this._tsMenu_Spots_Download_Geschiedenis.Size = new System.Drawing.Size(199, 22);
			this._tsMenu_Spots_Download_Geschiedenis.Text = "Download geschiedenis";
			this._tsMenu_Extra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this._tsMenu_Extra_Instellingen });
			this._tsMenu_Extra.Name = "tsMenu_Extra";
			

			this._tsMenu_Extra.Size = new System.Drawing.Size(44, 20);
			this._tsMenu_Extra.Text = "Extra";
			this._tsMenu_Extra_Instellingen.Name = "tsMenu_Extra_Instellingen";
			

			this._tsMenu_Extra_Instellingen.Size = new System.Drawing.Size(135, 22);
			this._tsMenu_Extra_Instellingen.Text = "Instellingen";
			this._tsMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this._tsMenu_Help_Info });
			this._tsMenu_Help.Name = "tsMenu_Help";
			

			this._tsMenu_Help.Size = new System.Drawing.Size(44, 20);
			this._tsMenu_Help.Text = "Help";
			this._tsMenu_Help_Info.Name = "tsMenu_Help_Info";
			

			this._tsMenu_Help_Info.Size = new System.Drawing.Size(95, 22);
			this._tsMenu_Help_Info.Text = "Info";
			this._systrayIcon.ContextMenuStrip = this._systrayMenu;
			this._systrayIcon.Icon = (System.Drawing.Icon)resources.GetObject("systrayIcon.Icon");
			this._systrayIcon.Visible = true;
			this._systrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this._systrayMenu_Openen, this._systrayMenu_Sep1, this._systrayMenu_Afsluiten });
			this._systrayMenu.Name = "mnuIcon";
			

			this._systrayMenu.Size = new System.Drawing.Size(122, 54);
			this._systrayMenu_Openen.Name = "systrayMenu_Openen";
			

			this._systrayMenu_Openen.Size = new System.Drawing.Size(121, 22);
			this._systrayMenu_Openen.Text = "Openen";
			this._systrayMenu_Sep1.Name = "systrayMenu_Sep1";
			

			this._systrayMenu_Sep1.Size = new System.Drawing.Size(118, 6);
			this._systrayMenu_Afsluiten.Name = "systrayMenu_Afsluiten";
			

			this._systrayMenu_Afsluiten.Size = new System.Drawing.Size(121, 22);
			this._systrayMenu_Afsluiten.Text = "Afsluiten";
			this._tmrDBWatch.Interval = 3000;
			this._barStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this._barStatusProg, this._barStatus_lbl1 });
			

			this._barStatus.Location = new System.Drawing.Point(0, 540);
			this._barStatus.Name = "barStatus";
			

			this._barStatus.Size = new System.Drawing.Size(784, 22);
			this._barStatus.TabIndex = 11;
			this._barStatusProg.AutoSize = false;
			this._barStatusProg.Name = "barStatusProg";
			

			this._barStatusProg.Size = new System.Drawing.Size(100, 16);
			this._barStatusProg.Step = 25;
			this._barStatusProg.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this._barStatus_lbl1.Name = "barStatus_lbl1";
			

			this._barStatus_lbl1.Size = new System.Drawing.Size(53, 17);
			this._barStatus_lbl1.Text = "Gereed...";
			this._iconList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("iconList.ImageStream");
			this._iconList.TransparentColor = System.Drawing.Color.Transparent;
			this._iconList.Images.SetKeyName(0, "0");
			this._iconList.Images.SetKeyName(1, "1");
			this._bgDBScanner.WorkerReportsProgress = true;

			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this._lstSpots);
			this.Controls.Add(this._tsMenu);
			this.Controls.Add(this._barStatus);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MainMenuStrip = this._tsMenu;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this._lstSpots.DoubleClick += new System.EventHandler(this.lstSpots_DoubleClick);
			this._lstSpots.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstSpots_ColumnClick);
			this._rbm_lstSpots_Openen.Click += new System.EventHandler(this.rbm_lstSpots_Openen_Click);
			this._rbm_lstSpots_Download.Click += new System.EventHandler(this.rbm_lstSpots_Download_Click);
			this._tsMenu_Bestand_Monitor.Click += new System.EventHandler(this.tsMenu_Bestand_Monitor_Click);
			this._tsMenu_Bestand_Afsluiten.Click += new System.EventHandler(this.tsMenu_Bestand_Afsluiten_Click);
			this._tsMenu_Filters_Beheren.Click += new System.EventHandler(this.tsMenu_Filters_Beheren_Click);
			this._tsMenu_Spots_Markeren.Click += new System.EventHandler(this.tsMenu_Spots_Markeren_Click);
			this._tsMenu_Spots_Download_Geschiedenis.Click += new System.EventHandler(this.tsMenu_Spots_Download_Geschiedenis_Click);
			this._tsMenu_Extra_Instellingen.Click += new System.EventHandler(this.tsMenu_Extra_Instellingen_Click);
			this._tsMenu_Help_Info.Click += new System.EventHandler(this.tsMenu_Help_Info_Click);
			this._systrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.systrayIcon_MouseDoubleClick);
			this._systrayMenu_Openen.Click += new System.EventHandler(this.systrayMenu_Openen_Click);
			this._systrayMenu_Afsluiten.Click += new System.EventHandler(this.systrayMenu_Afsluiten_Click);
			this._tmrDBWatch.Tick += new System.EventHandler(this.tmrDBWatch_Tick);
			this._bgDBScanner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDBScanner_DoWork);
			this._bgDBScanner.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgDBScanner_ProgressChanged);
			this._bgDBScanner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgDBScanner_RunWorkerCompleted);
			this._rbm_lstSpots.ResumeLayout(false);
			this._tsMenu.ResumeLayout(false);
			this._tsMenu.PerformLayout();
			this._systrayMenu.ResumeLayout(false);
			this._barStatus.ResumeLayout(false);
			this._barStatus.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
