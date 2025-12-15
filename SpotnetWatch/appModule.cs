using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SpotnetWatch
{
	[StandardModule]
	internal sealed class appModule
	{
		public const string APP_DEFAULT_NZB_SERVER = "http://www.nzbserver.com/#/?page=getspot&messageid=";

		public static string APP_TITLE = Application.ProductName;

		public static string APP_VERSION = Application.ProductVersion;

		public static string PATH_FILTER_FILE = Application.StartupPath.ToString() + "\\filters.db";

		public static string PATH_OLD_SPOT_FILE = Application.StartupPath.ToString() + "\\oldspots.db";

		public static string PATH_DOWNLOAD_HISTORY_FILE = Application.StartupPath.ToString() + "\\downloads.db";

		public static List<string> APP_OLD_SPOT_ARRAY = new List<string>();

		public static List<string> APP_NEW_SPOT_ARRAY = new List<string>();

		public static string PATH_SPOT_DATABASE = Interaction.GetSetting(Application.ProductName, "Instellingen", "PATH_SPOT_DATABASE", string.Empty);

		public static Array APP_SIZE = Strings.Split(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_SIZE", "100,100,800,600"), ",");

		public static bool APP_MONITOR_DATABASE = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_MONITOR_DATABASE", Conversions.ToString(false)));

		public static DateTime APP_LAST_SCAN = Conversions.ToDate(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_LAST_SCAN", "01-01-1900 00:00:00"));

		public static string APP_SQL_MAX_ROWS = Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_SQL_MAX_ROWS", "2000");

		public static string APP_SQL_MAX_DAYS = Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_SQL_MAX_DAYS", "14");

		public static string APP_NZB_SERVER = Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_NZB_SERVER", "http://www.nzbserver.com/#/?page=getspot&messageid=");

		public static bool APP_START_IN_SYSTRAY = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_START_IN_SYSTRAY", Conversions.ToString(false)));

		public static bool APP_START_ON_BOOT = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_START_ON_BOOT", Conversions.ToString(false)));

		public static bool APP_SCAN_ON_FILTER_EXIT = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_SCAN_ON_FILTER_EXIT", Conversions.ToString(false)));

		public static bool APP_ON_TOP = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_ON_TOP", Conversions.ToString(false)));

		public static bool APP_COLUMN_AUTOSIZE = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_COLUMN_AUTOSIZE", Conversions.ToString(false)));

		public static bool APP_GRID_LINES = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_GRID_LINES", Conversions.ToString(false)));

		public static bool APP_REPORT_ONLY_NEW_SPOTS = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_REPORT_ONLY_NEW_SPOTS", Conversions.ToString(false)));

		public static Array COLOR_CAT1 = Strings.Split(Interaction.GetSetting(Application.ProductName, "Instellingen", "COLOR_CAT1", "138,177,210"), ",");

		public static Array COLOR_CAT2 = Strings.Split(Interaction.GetSetting(Application.ProductName, "Instellingen", "COLOR_CAT2", "255,209,72"), ",");

		public static Array COLOR_CAT3 = Strings.Split(Interaction.GetSetting(Application.ProductName, "Instellingen", "COLOR_CAT3", "144,238,144"), ",");

		public static Array COLOR_CAT4 = Strings.Split(Interaction.GetSetting(Application.ProductName, "Instellingen", "COLOR_CAT4", "255,111,111"), ",");

		public static Array COLOR_CAT5 = Strings.Split(Interaction.GetSetting(Application.ProductName, "Instellingen", "COLOR_CAT5", "138,177,210"), ",");

		public static Array COLOR_CAT6 = Strings.Split(Interaction.GetSetting(Application.ProductName, "Instellingen", "COLOR_CAT6", "138,177,210"), ",");

		public static Array COLOR_CAT9 = Strings.Split(Interaction.GetSetting(Application.ProductName, "Instellingen", "COLOR_CAT9", "255,174,215"), ",");

		public static bool APP_NZB_SERVER_NO_API = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_NZB_SERVER_NO_API", Conversions.ToString(false)));

		public static bool APP_NZB_SERVER_USE_API = Conversions.ToBoolean(Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_NZB_SERVER_USE_API", Conversions.ToString(true)));

		public static string APP_SABNZBD_SERVER = Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_SABNZBD_SERVER", "http://sabnzbd_server");

		public static string APP_SABNZBD_APIKEY = Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_SABNZBD_APIKEY", string.Empty);

		public static string APP_SPOTWEB_SERVER = Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_SPOTWEB_SERVER", "http://spotweb_server");

		public static string APP_SPOTWEB_APIKEY = Interaction.GetSetting(Application.ProductName, "Instellingen", "APP_SPOTWEB_APIKEY", string.Empty);
	}
}
