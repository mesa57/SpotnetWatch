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
	public partial class frmFilters : Form
	{
		private IContainer components = null;

	[AccessedThroughProperty("lstFiltersErotiek")]
		private ListView _lstFiltersErotiek;

		[AccessedThroughProperty("colFilterErotiek")]
		private ColumnHeader _colFilterErotiek;

		[AccessedThroughProperty("lstFiltersSoftware")]
		private ListView _lstFiltersSoftware;

		[AccessedThroughProperty("colFilterSoftware")]
		private ColumnHeader _colFilterSoftware;

		[AccessedThroughProperty("lstFiltersSpellen")]
		private ListView _lstFiltersSpellen;

		[AccessedThroughProperty("colFilterSpellen")]
		private ColumnHeader _colFilterSpellen;

		[AccessedThroughProperty("lstFiltersMuziek")]
		private ListView _lstFiltersMuziek;

		[AccessedThroughProperty("colFilterMuziek")]
		private ColumnHeader _colFilterMuziek;

		[AccessedThroughProperty("lstFiltersBeeld")]
		private ListView _lstFiltersBeeld;

		[AccessedThroughProperty("colFilterBeeld")]
		private ColumnHeader _colFilterBeeld;

		[AccessedThroughProperty("lstFilters")]
		private ListView _lstFilters;

		[AccessedThroughProperty("colFilter1")]
		private ColumnHeader _colFilter1;

		[AccessedThroughProperty("imgList")]
		private ImageList _imgList;

		[AccessedThroughProperty("lstFiltersBoeken")]
		private ListView _lstFiltersBoeken;

		[AccessedThroughProperty("colFiltersBoeken")]
		private ColumnHeader _colFiltersBoeken;

		[AccessedThroughProperty("lstFiltersSeries")]
		private ListView _lstFiltersSeries;

		[AccessedThroughProperty("colFiltersSeries")]
		private ColumnHeader _colFiltersSeries;

		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[AccessedThroughProperty("btnAnnuleren")]
		private Button _btnAnnuleren;

		[AccessedThroughProperty("btnVerwijderen")]
		private Button _btnVerwijderen;

		[AccessedThroughProperty("btnToevoegen")]
		private Button _btnToevoegen;

		[AccessedThroughProperty("btnOpslaan")]
		private Button _btnOpslaan;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("txtFilterTag")]
		private TextBox _txtFilterTag;

		[AccessedThroughProperty("chkFilterOptie")]
		private CheckBox _chkFilterOptie;

		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[AccessedThroughProperty("txtFilterSpotter")]
		private TextBox _txtFilterSpotter;

		[AccessedThroughProperty("txtFilterText")]
		private TextBox _txtFilterText;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("txtFilterNaam")]
		private TextBox _txtFilterNaam;

		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		private ListViewColumnSorter lvwColumnSorter;

		internal virtual ListView lstFiltersErotiek
		{
			get
			{
				return _lstFiltersErotiek;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstFiltersErotiek_Validated;
				if (_lstFiltersErotiek != null)
				{
					_lstFiltersErotiek.Validated -= value2;
				}
				_lstFiltersErotiek = value;
				if (_lstFiltersErotiek != null)
				{
					_lstFiltersErotiek.Validated += value2;
				}
			}
		}

		internal virtual ColumnHeader colFilterErotiek
		{
			get
			{
				return _colFilterErotiek;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colFilterErotiek = value;
			}
		}

		internal virtual ListView lstFiltersSoftware
		{
			get
			{
				return _lstFiltersSoftware;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstFiltersSoftware_Validated;
				if (_lstFiltersSoftware != null)
				{
					_lstFiltersSoftware.Validated -= value2;
				}
				_lstFiltersSoftware = value;
				if (_lstFiltersSoftware != null)
				{
					_lstFiltersSoftware.Validated += value2;
				}
			}
		}

		internal virtual ColumnHeader colFilterSoftware
		{
			get
			{
				return _colFilterSoftware;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colFilterSoftware = value;
			}
		}

		internal virtual ListView lstFiltersSpellen
		{
			get
			{
				return _lstFiltersSpellen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstFiltersSpellen_Validated;
				if (_lstFiltersSpellen != null)
				{
					_lstFiltersSpellen.Validated -= value2;
				}
				_lstFiltersSpellen = value;
				if (_lstFiltersSpellen != null)
				{
					_lstFiltersSpellen.Validated += value2;
				}
			}
		}

		internal virtual ColumnHeader colFilterSpellen
		{
			get
			{
				return _colFilterSpellen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colFilterSpellen = value;
			}
		}

		internal virtual ListView lstFiltersMuziek
		{
			get
			{
				return _lstFiltersMuziek;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstFiltersMuziek_Validated;
				if (_lstFiltersMuziek != null)
				{
					_lstFiltersMuziek.Validated -= value2;
				}
				_lstFiltersMuziek = value;
				if (_lstFiltersMuziek != null)
				{
					_lstFiltersMuziek.Validated += value2;
				}
			}
		}

		internal virtual ColumnHeader colFilterMuziek
		{
			get
			{
				return _colFilterMuziek;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colFilterMuziek = value;
			}
		}

		internal virtual ListView lstFiltersBeeld
		{
			get
			{
				return _lstFiltersBeeld;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstFiltersBeeld_Validated;
				if (_lstFiltersBeeld != null)
				{
					_lstFiltersBeeld.Validated -= value2;
				}
				_lstFiltersBeeld = value;
				if (_lstFiltersBeeld != null)
				{
					_lstFiltersBeeld.Validated += value2;
				}
			}
		}

		internal virtual ColumnHeader colFilterBeeld
		{
			get
			{
				return _colFilterBeeld;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colFilterBeeld = value;
			}
		}

		internal virtual ListView lstFilters
		{
			get
			{
				return _lstFilters;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstFilters_SelectedIndexChanged;
				KeyEventHandler value3 = lstFilters_KeyDown;
				ColumnClickEventHandler value4 = lstFilters_ColumnClick;
				if (_lstFilters != null)
				{
					_lstFilters.SelectedIndexChanged -= value2;
					_lstFilters.KeyDown -= value3;
					_lstFilters.ColumnClick -= value4;
				}
				_lstFilters = value;
				if (_lstFilters != null)
				{
					_lstFilters.SelectedIndexChanged += value2;
					_lstFilters.KeyDown += value3;
					_lstFilters.ColumnClick += value4;
				}
			}
		}

		internal virtual ColumnHeader colFilter1
		{
			get
			{
				return _colFilter1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colFilter1 = value;
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

		internal virtual ListView lstFiltersBoeken
		{
			get
			{
				return _lstFiltersBoeken;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstFiltersBoeken_Validated;
				if (_lstFiltersBoeken != null)
				{
					_lstFiltersBoeken.Validated -= value2;
				}
				_lstFiltersBoeken = value;
				if (_lstFiltersBoeken != null)
				{
					_lstFiltersBoeken.Validated += value2;
				}
			}
		}

		internal virtual ColumnHeader colFiltersBoeken
		{
			get
			{
				return _colFiltersBoeken;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colFiltersBoeken = value;
			}
		}

		internal virtual ListView lstFiltersSeries
		{
			get
			{
				return _lstFiltersSeries;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = lstFiltersSeries_Validated;
				if (_lstFiltersSeries != null)
				{
					_lstFiltersSeries.Validated -= value2;
				}
				_lstFiltersSeries = value;
				if (_lstFiltersSeries != null)
				{
					_lstFiltersSeries.Validated += value2;
				}
			}
		}

		internal virtual ColumnHeader colFiltersSeries
		{
			get
			{
				return _colFiltersSeries;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_colFiltersSeries = value;
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

		internal virtual Button btnAnnuleren
		{
			get
			{
				return _btnAnnuleren;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnAnnuleren_Click;
				if (_btnAnnuleren != null)
				{
					_btnAnnuleren.Click -= value2;
				}
				_btnAnnuleren = value;
				if (_btnAnnuleren != null)
				{
					_btnAnnuleren.Click += value2;
				}
			}
		}

		internal virtual Button btnVerwijderen
		{
			get
			{
				return _btnVerwijderen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnVerwijderen_Click;
				if (_btnVerwijderen != null)
				{
					_btnVerwijderen.Click -= value2;
				}
				_btnVerwijderen = value;
				if (_btnVerwijderen != null)
				{
					_btnVerwijderen.Click += value2;
				}
			}
		}

		internal virtual Button btnToevoegen
		{
			get
			{
				return _btnToevoegen;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = btnToevoegen_Click;
				if (_btnToevoegen != null)
				{
					_btnToevoegen.Click -= value2;
				}
				_btnToevoegen = value;
				if (_btnToevoegen != null)
				{
					_btnToevoegen.Click += value2;
				}
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

		internal virtual TextBox txtFilterTag
		{
			get
			{
				return _txtFilterTag;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = txtFilterTag_Validating;
				EventHandler value3 = txtFilterTag_Validated;
				if (_txtFilterTag != null)
				{
					_txtFilterTag.Validating -= value2;
					_txtFilterTag.Validated -= value3;
				}
				_txtFilterTag = value;
				if (_txtFilterTag != null)
				{
					_txtFilterTag.Validating += value2;
					_txtFilterTag.Validated += value3;
				}
			}
		}

		internal virtual CheckBox chkFilterOptie
		{
			get
			{
				return _chkFilterOptie;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = chkFilterOptie_Validated;
				if (_chkFilterOptie != null)
				{
					_chkFilterOptie.Validated -= value2;
				}
				_chkFilterOptie = value;
				if (_chkFilterOptie != null)
				{
					_chkFilterOptie.Validated += value2;
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

		internal virtual TextBox txtFilterSpotter
		{
			get
			{
				return _txtFilterSpotter;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = txtFilterSpotter_Validating;
				EventHandler value3 = txtFilterSpotter_Validated;
				if (_txtFilterSpotter != null)
				{
					_txtFilterSpotter.Validating -= value2;
					_txtFilterSpotter.Validated -= value3;
				}
				_txtFilterSpotter = value;
				if (_txtFilterSpotter != null)
				{
					_txtFilterSpotter.Validating += value2;
					_txtFilterSpotter.Validated += value3;
				}
			}
		}

		internal virtual TextBox txtFilterText
		{
			get
			{
				return _txtFilterText;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = txtFilterText_Validating;
				EventHandler value3 = txtFilterText_Validated;
				if (_txtFilterText != null)
				{
					_txtFilterText.Validating -= value2;
					_txtFilterText.Validated -= value3;
				}
				_txtFilterText = value;
				if (_txtFilterText != null)
				{
					_txtFilterText.Validating += value2;
					_txtFilterText.Validated += value3;
				}
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

		internal virtual TextBox txtFilterNaam
		{
			get
			{
				return _txtFilterNaam;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = txtFilterNaam_Validating;
				EventHandler value3 = txtFilterNaam_Validated;
				if (_txtFilterNaam != null)
				{
					_txtFilterNaam.Validating -= value2;
					_txtFilterNaam.Validated -= value3;
				}
				_txtFilterNaam = value;
				if (_txtFilterNaam != null)
				{
					_txtFilterNaam.Validating += value2;
					_txtFilterNaam.Validated += value3;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpotnetWatch.frmFilters));
			this._lstFiltersBoeken = new System.Windows.Forms.ListView();
			this._colFiltersBoeken = new System.Windows.Forms.ColumnHeader();
			this._imgList = new System.Windows.Forms.ImageList(this.components);
			this._lstFiltersSeries = new System.Windows.Forms.ListView();
			this._colFiltersSeries = new System.Windows.Forms.ColumnHeader();
			this._lstFiltersErotiek = new System.Windows.Forms.ListView();
			this._colFilterErotiek = new System.Windows.Forms.ColumnHeader();
			this._lstFiltersSoftware = new System.Windows.Forms.ListView();
			this._colFilterSoftware = new System.Windows.Forms.ColumnHeader();
			this._lstFiltersSpellen = new System.Windows.Forms.ListView();
			this._colFilterSpellen = new System.Windows.Forms.ColumnHeader();
			this._lstFiltersMuziek = new System.Windows.Forms.ListView();
			this._colFilterMuziek = new System.Windows.Forms.ColumnHeader();
			this._lstFiltersBeeld = new System.Windows.Forms.ListView();
			this._colFilterBeeld = new System.Windows.Forms.ColumnHeader();
			this._lstFilters = new System.Windows.Forms.ListView();
			this._colFilter1 = new System.Windows.Forms.ColumnHeader();
			this._Panel1 = new System.Windows.Forms.Panel();
			this._chkFilterOptie = new System.Windows.Forms.CheckBox();
			this._btnAnnuleren = new System.Windows.Forms.Button();
			this._btnVerwijderen = new System.Windows.Forms.Button();
			this._btnToevoegen = new System.Windows.Forms.Button();
			this._btnOpslaan = new System.Windows.Forms.Button();
			this._GroupBox1 = new System.Windows.Forms.GroupBox();
			this._Label4 = new System.Windows.Forms.Label();
			this._Label2 = new System.Windows.Forms.Label();
			this._txtFilterTag = new System.Windows.Forms.TextBox();
			this._Label3 = new System.Windows.Forms.Label();
			this._txtFilterSpotter = new System.Windows.Forms.TextBox();
			this._txtFilterText = new System.Windows.Forms.TextBox();
			this._Label1 = new System.Windows.Forms.Label();
			this._txtFilterNaam = new System.Windows.Forms.TextBox();
			this._Panel2 = new System.Windows.Forms.Panel();
			this._Panel1.SuspendLayout();
			this._GroupBox1.SuspendLayout();
			this._Panel2.SuspendLayout();
			this.SuspendLayout();
			this._lstFiltersBoeken.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this._lstFiltersBoeken.CheckBoxes = true;
			this._lstFiltersBoeken.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this._colFiltersBoeken });
			this._lstFiltersBoeken.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			
			this._lstFiltersBoeken.Location = new System.Drawing.Point(622, 234);
			this._lstFiltersBoeken.MultiSelect = false;
			this._lstFiltersBoeken.Name = "lstFiltersBoeken";
			
			this._lstFiltersBoeken.Size = new System.Drawing.Size(121, 199);
			this._lstFiltersBoeken.SmallImageList = this._imgList;
			this._lstFiltersBoeken.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this._lstFiltersBoeken.TabIndex = 16;
			this._lstFiltersBoeken.UseCompatibleStateImageBehavior = false;
			this._lstFiltersBoeken.View = System.Windows.Forms.View.Details;
			this._colFiltersBoeken.Text = "Boeken";
			this._colFiltersBoeken.Width = 100;
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
			this._lstFiltersSeries.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this._lstFiltersSeries.CheckBoxes = true;
			this._lstFiltersSeries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this._colFiltersSeries });
			this._lstFiltersSeries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			
			this._lstFiltersSeries.Location = new System.Drawing.Point(495, 3);
			this._lstFiltersSeries.MultiSelect = false;
			this._lstFiltersSeries.Name = "lstFiltersSeries";
			
			this._lstFiltersSeries.Size = new System.Drawing.Size(121, 225);
			this._lstFiltersSeries.SmallImageList = this._imgList;
			this._lstFiltersSeries.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this._lstFiltersSeries.TabIndex = 13;
			this._lstFiltersSeries.UseCompatibleStateImageBehavior = false;
			this._lstFiltersSeries.View = System.Windows.Forms.View.Details;
			this._colFiltersSeries.Text = "Series";
			this._colFiltersSeries.Width = 100;
			this._lstFiltersErotiek.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this._lstFiltersErotiek.CheckBoxes = true;
			this._lstFiltersErotiek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this._colFilterErotiek });
			this._lstFiltersErotiek.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			
			this._lstFiltersErotiek.Location = new System.Drawing.Point(495, 234);
			this._lstFiltersErotiek.MultiSelect = false;
			this._lstFiltersErotiek.Name = "lstFiltersErotiek";
			
			this._lstFiltersErotiek.Size = new System.Drawing.Size(121, 199);
			this._lstFiltersErotiek.SmallImageList = this._imgList;
			this._lstFiltersErotiek.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this._lstFiltersErotiek.TabIndex = 14;
			this._lstFiltersErotiek.UseCompatibleStateImageBehavior = false;
			this._lstFiltersErotiek.View = System.Windows.Forms.View.Details;
			this._colFilterErotiek.Text = "Erotiek";
			this._colFilterErotiek.Width = 100;
			this._lstFiltersSoftware.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this._lstFiltersSoftware.CheckBoxes = true;
			this._lstFiltersSoftware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this._colFilterSoftware });
			this._lstFiltersSoftware.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			
			this._lstFiltersSoftware.Location = new System.Drawing.Point(368, 234);
			this._lstFiltersSoftware.MultiSelect = false;
			this._lstFiltersSoftware.Name = "lstFiltersSoftware";
			
			this._lstFiltersSoftware.Size = new System.Drawing.Size(121, 199);
			this._lstFiltersSoftware.SmallImageList = this._imgList;
			this._lstFiltersSoftware.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this._lstFiltersSoftware.TabIndex = 12;
			this._lstFiltersSoftware.UseCompatibleStateImageBehavior = false;
			this._lstFiltersSoftware.View = System.Windows.Forms.View.Details;
			this._colFilterSoftware.Text = "Software";
			this._colFilterSoftware.Width = 100;
			this._lstFiltersSpellen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this._lstFiltersSpellen.CheckBoxes = true;
			this._lstFiltersSpellen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this._colFilterSpellen });
			this._lstFiltersSpellen.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			
			this._lstFiltersSpellen.Location = new System.Drawing.Point(749, 3);
			this._lstFiltersSpellen.MultiSelect = false;
			this._lstFiltersSpellen.Name = "lstFiltersSpellen";
			
			this._lstFiltersSpellen.Size = new System.Drawing.Size(121, 430);
			this._lstFiltersSpellen.SmallImageList = this._imgList;
			this._lstFiltersSpellen.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this._lstFiltersSpellen.TabIndex = 17;
			this._lstFiltersSpellen.UseCompatibleStateImageBehavior = false;
			this._lstFiltersSpellen.View = System.Windows.Forms.View.Details;
			this._colFilterSpellen.Text = "Spellen";
			this._colFilterSpellen.Width = 100;
			this._lstFiltersMuziek.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this._lstFiltersMuziek.CheckBoxes = true;
			this._lstFiltersMuziek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this._colFilterMuziek });
			this._lstFiltersMuziek.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			
			this._lstFiltersMuziek.Location = new System.Drawing.Point(622, 3);
			this._lstFiltersMuziek.MultiSelect = false;
			this._lstFiltersMuziek.Name = "lstFiltersMuziek";
			
			this._lstFiltersMuziek.Size = new System.Drawing.Size(121, 225);
			this._lstFiltersMuziek.SmallImageList = this._imgList;
			this._lstFiltersMuziek.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this._lstFiltersMuziek.TabIndex = 15;
			this._lstFiltersMuziek.UseCompatibleStateImageBehavior = false;
			this._lstFiltersMuziek.View = System.Windows.Forms.View.Details;
			this._colFilterMuziek.Text = "Muziek";
			this._colFilterMuziek.Width = 100;
			this._lstFiltersBeeld.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this._lstFiltersBeeld.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this._lstFiltersBeeld.CheckBoxes = true;
			this._lstFiltersBeeld.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this._colFilterBeeld });
			this._lstFiltersBeeld.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			
			this._lstFiltersBeeld.Location = new System.Drawing.Point(368, 3);
			this._lstFiltersBeeld.MultiSelect = false;
			this._lstFiltersBeeld.Name = "lstFiltersBeeld";
			
			this._lstFiltersBeeld.Size = new System.Drawing.Size(121, 225);
			this._lstFiltersBeeld.SmallImageList = this._imgList;
			this._lstFiltersBeeld.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this._lstFiltersBeeld.TabIndex = 11;
			this._lstFiltersBeeld.UseCompatibleStateImageBehavior = false;
			this._lstFiltersBeeld.View = System.Windows.Forms.View.Details;
			this._colFilterBeeld.Text = "Films";
			this._colFilterBeeld.Width = 100;
			this._lstFilters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._lstFilters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this._colFilter1 });
			this._lstFilters.FullRowSelect = true;
			this._lstFilters.HideSelection = false;
			
			this._lstFilters.Location = new System.Drawing.Point(3, 3);
			this._lstFilters.MultiSelect = false;
			this._lstFilters.Name = "lstFilters";
			
			this._lstFilters.Size = new System.Drawing.Size(179, 430);
			this._lstFilters.TabIndex = 4;
			this._lstFilters.UseCompatibleStateImageBehavior = false;
			this._lstFilters.View = System.Windows.Forms.View.Details;
			this._colFilter1.Text = "Filter naam";
			this._colFilter1.Width = 150;
			this._Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._Panel1.Controls.Add(this._btnAnnuleren);
			this._Panel1.Controls.Add(this._btnVerwijderen);
			this._Panel1.Controls.Add(this._btnToevoegen);
			this._Panel1.Controls.Add(this._btnOpslaan);
			
			this._Panel1.Location = new System.Drawing.Point(9, 451);
			this._Panel1.Name = "Panel1";
			
			this._Panel1.Size = new System.Drawing.Size(873, 32);
			this._Panel1.TabIndex = 25;
			this._chkFilterOptie.AutoSize = true;
			
			this._chkFilterOptie.Location = new System.Drawing.Point(13, 219);
			
			this._chkFilterOptie.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this._chkFilterOptie.Name = "chkFilterOptie";
			
			this._chkFilterOptie.Size = new System.Drawing.Size(128, 17);
			this._chkFilterOptie.TabIndex = 10;
			this._chkFilterOptie.Text = "Zoek zonder wildcard";
			this._chkFilterOptie.UseVisualStyleBackColor = true;
			this._btnAnnuleren.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			
			this._btnAnnuleren.Location = new System.Drawing.Point(770, 3);
			this._btnAnnuleren.Name = "btnAnnuleren";
			
			this._btnAnnuleren.Size = new System.Drawing.Size(100, 26);
			this._btnAnnuleren.TabIndex = 0;
			this._btnAnnuleren.Text = "Annuleren";
			this._btnAnnuleren.UseVisualStyleBackColor = true;
			this._btnVerwijderen.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			
			this._btnVerwijderen.Location = new System.Drawing.Point(3, 3);
			this._btnVerwijderen.Name = "btnVerwijderen";
			
			this._btnVerwijderen.Size = new System.Drawing.Size(100, 26);
			this._btnVerwijderen.TabIndex = 3;
			this._btnVerwijderen.Text = "Verwijderen";
			this._btnVerwijderen.UseVisualStyleBackColor = true;
			this._btnToevoegen.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			
			this._btnToevoegen.Location = new System.Drawing.Point(109, 3);
			this._btnToevoegen.Name = "btnToevoegen";
			
			this._btnToevoegen.Size = new System.Drawing.Size(100, 26);
			this._btnToevoegen.TabIndex = 2;
			this._btnToevoegen.Text = "Nieuw";
			this._btnToevoegen.UseVisualStyleBackColor = true;
			this._btnOpslaan.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			
			this._btnOpslaan.Location = new System.Drawing.Point(664, 3);
			this._btnOpslaan.Name = "btnOpslaan";
			
			this._btnOpslaan.Size = new System.Drawing.Size(100, 26);
			this._btnOpslaan.TabIndex = 1;
			this._btnOpslaan.Text = "Opslaan";
			this._btnOpslaan.UseVisualStyleBackColor = true;
			this._GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this._GroupBox1.Controls.Add(this._chkFilterOptie);
			this._GroupBox1.Controls.Add(this._Label4);
			this._GroupBox1.Controls.Add(this._Label2);
			this._GroupBox1.Controls.Add(this._txtFilterTag);
			this._GroupBox1.Controls.Add(this._Label3);
			this._GroupBox1.Controls.Add(this._txtFilterSpotter);
			this._GroupBox1.Controls.Add(this._txtFilterText);
			this._GroupBox1.Controls.Add(this._Label1);
			this._GroupBox1.Controls.Add(this._txtFilterNaam);
			
			this._GroupBox1.Location = new System.Drawing.Point(188, 3);
			this._GroupBox1.Name = "GroupBox1";
			
			this._GroupBox1.Padding = new System.Windows.Forms.Padding(10);
			
			this._GroupBox1.Size = new System.Drawing.Size(174, 430);
			this._GroupBox1.TabIndex = 5;
			this._GroupBox1.TabStop = false;
			this._Label4.AutoSize = true;
			
			this._Label4.Location = new System.Drawing.Point(13, 170);
			
			this._Label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label4.Name = "Label4";
			
			this._Label4.Size = new System.Drawing.Size(61, 13);
			this._Label4.TabIndex = 16;
			this._Label4.Text = "Zoek in tag";
			this._Label2.AutoSize = true;
			
			this._Label2.Location = new System.Drawing.Point(13, 72);
			
			this._Label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label2.Name = "Label2";
			
			this._Label2.Size = new System.Drawing.Size(62, 13);
			this._Label2.TabIndex = 13;
			this._Label2.Text = "Zoek in titel";
			
			this._txtFilterTag.Location = new System.Drawing.Point(13, 186);
			this._txtFilterTag.Name = "txtFilterTag";
			
			this._txtFilterTag.Size = new System.Drawing.Size(148, 20);
			this._txtFilterTag.TabIndex = 9;
			this._Label3.AutoSize = true;
			
			this._Label3.Location = new System.Drawing.Point(13, 121);
			
			this._Label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this._Label3.Name = "Label3";
			
			this._Label3.Size = new System.Drawing.Size(87, 13);
			this._Label3.TabIndex = 14;
			this._Label3.Text = "Zoek in afzender";
			
			this._txtFilterSpotter.Location = new System.Drawing.Point(13, 137);
			this._txtFilterSpotter.Name = "txtFilterSpotter";
			
			this._txtFilterSpotter.Size = new System.Drawing.Size(148, 20);
			this._txtFilterSpotter.TabIndex = 8;
			
			this._txtFilterText.Location = new System.Drawing.Point(13, 88);
			this._txtFilterText.Name = "txtFilterText";
			
			this._txtFilterText.Size = new System.Drawing.Size(148, 20);
			this._txtFilterText.TabIndex = 7;
			this._Label1.AutoSize = true;
			
			this._Label1.Location = new System.Drawing.Point(13, 23);
			this._Label1.Name = "Label1";
			
			this._Label1.Size = new System.Drawing.Size(58, 13);
			this._Label1.TabIndex = 12;
			this._Label1.Text = "Filter naam";
			
			this._txtFilterNaam.Location = new System.Drawing.Point(13, 39);
			this._txtFilterNaam.Name = "txtFilterNaam";
			
			this._txtFilterNaam.Size = new System.Drawing.Size(148, 20);
			this._txtFilterNaam.TabIndex = 6;
			this._Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this._Panel2.Controls.Add(this._lstFilters);
			this._Panel2.Controls.Add(this._GroupBox1);
			this._Panel2.Controls.Add(this._lstFiltersBeeld);
			this._Panel2.Controls.Add(this._lstFiltersSoftware);
			this._Panel2.Controls.Add(this._lstFiltersSpellen);
			this._Panel2.Controls.Add(this._lstFiltersSeries);
			this._Panel2.Controls.Add(this._lstFiltersBoeken);
			this._Panel2.Controls.Add(this._lstFiltersErotiek);
			this._Panel2.Controls.Add(this._lstFiltersMuziek);
			
			this._Panel2.Location = new System.Drawing.Point(9, 9);
			this._Panel2.Name = "Panel2";
			
			this._Panel2.Size = new System.Drawing.Size(873, 436);
			this._Panel2.TabIndex = 26;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 492);
			this.Controls.Add(this._Panel2);
			this.Controls.Add(this._Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(907, 530);
			this.Name = "frmFilters";
			this.Padding = new System.Windows.Forms.Padding(6);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Filter beheer";
			this._lstFiltersErotiek.Validated += new System.EventHandler(this.lstFiltersErotiek_Validated);
			this._lstFiltersSoftware.Validated += new System.EventHandler(this.lstFiltersSoftware_Validated);
			this._lstFiltersSpellen.Validated += new System.EventHandler(this.lstFiltersSpellen_Validated);
			this._lstFiltersMuziek.Validated += new System.EventHandler(this.lstFiltersMuziek_Validated);
			this._lstFiltersBeeld.Validated += new System.EventHandler(this.lstFiltersBeeld_Validated);
			this._lstFiltersBoeken.Validated += new System.EventHandler(this.lstFiltersBoeken_Validated);
			this._lstFiltersSeries.Validated += new System.EventHandler(this.lstFiltersSeries_Validated);
			this._lstFilters.SelectedIndexChanged += new System.EventHandler(this.lstFilters_SelectedIndexChanged);
			this._lstFilters.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFilters_KeyDown);
			this._lstFilters.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstFilters_ColumnClick);
			this._btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
			this._btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
			this._btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
			this._btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
			this._txtFilterTag.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterTag_Validating);
			this._txtFilterTag.Validated += new System.EventHandler(this.txtFilterTag_Validated);
			this._chkFilterOptie.Validated += new System.EventHandler(this.chkFilterOptie_Validated);
			this._txtFilterSpotter.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterSpotter_Validating);
			this._txtFilterSpotter.Validated += new System.EventHandler(this.txtFilterSpotter_Validated);
			this._txtFilterText.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterText_Validating);
			this._txtFilterText.Validated += new System.EventHandler(this.txtFilterText_Validated);
			this._txtFilterNaam.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterNaam_Validating);
			this._txtFilterNaam.Validated += new System.EventHandler(this.txtFilterNaam_Validated);
			this._Panel1.ResumeLayout(false);
			this._GroupBox1.ResumeLayout(false);
			this._GroupBox1.PerformLayout();
			this._Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
