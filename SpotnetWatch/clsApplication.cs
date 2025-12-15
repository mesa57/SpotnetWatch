using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SpotnetWatch
{
	public class clsApplication
	{
		public bool saveOLDSpots()
		{
			bool result;
			try
			{
				StreamWriter streamWriter = new StreamWriter(appModule.PATH_OLD_SPOT_FILE);
				foreach (string item in appModule.APP_OLD_SPOT_ARRAY)
				{
					streamWriter.WriteLine(item.ToString());
				}
				streamWriter.Close();
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public bool loadOLDSpots()
		{
			bool result;
			try
			{
				string[] array = File.ReadAllLines(appModule.PATH_OLD_SPOT_FILE);
				string[] array2 = array;
				foreach (string text in array2)
				{
					appModule.APP_OLD_SPOT_ARRAY.Add(text.ToString());
				}
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public bool saveDOWNLOADSpots(string strText)
		{
			bool result;
			try
			{
				File.AppendAllText(appModule.PATH_DOWNLOAD_HISTORY_FILE, strText.ToString() + "\r\n");
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public bool loadDOWNLOADSpots(TextBox txtBox)
		{
			bool result;
			try
			{
				if (File.Exists(appModule.PATH_DOWNLOAD_HISTORY_FILE))
				{
					txtBox.Clear();
					txtBox.Text = File.ReadAllText(appModule.PATH_DOWNLOAD_HISTORY_FILE);
				}
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public string catToName(int iSelect)
		{
			switch (iSelect)
			{
			case 1:
				return "Beeld";
			case 2:
				return "Geluid";
			case 3:
				return "Spellen";
			case 4:
				return "Software";
			case 5:
				return "Boeken";
			case 6:
				return "Series";
			case 9:
				return "Erotiek";
			default:
				return string.Empty;
			}
		}

		public string subCatToName(int iSelect)
		{
			switch (iSelect)
			{
			case 100:
				return "DivX";
			case 101:
				return "WMV";
			case 102:
				return "MPG";
			case 103:
				return "DVD5";
			case 104:
				return "HD";
			case 105:
				return "IMG";
			case 106:
				return "BRay";
			case 107:
				return "HDDVD";
			case 108:
				return "WMVHD";
			case 109:
				return "X264";
			case 110:
				return "DVD9";
			case 200:
				return "MP3";
			case 201:
				return "WMA";
			case 202:
				return "WAV";
			case 203:
				return "OGG";
			case 204:
				return "1:1";
			case 205:
				return "DTS";
			case 206:
				return "AAC";
			case 207:
				return "APE";
			case 208:
				return "FLAC";
			case 300:
				return "WIN";
			case 301:
				return "MAC";
			case 302:
				return "TUX";
			case 303:
				return "PSX";
			case 304:
				return "PS2";
			case 305:
				return "PSP";
			case 306:
				return "Xbox";
			case 307:
				return "X360";
			case 308:
				return "GBA";
			case 309:
				return "Cube";
			case 310:
				return "NDS";
			case 311:
				return "WII";
			case 312:
				return "PS3";
			case 313:
				return "PDA";
			case 314:
				return "IOS";
			case 315:
				return "Android";
			case 400:
				return "WIN";
			case 401:
				return "MAC";
			case 402:
				return "TUX";
			case 403:
				return "OS2";
			case 404:
				return "PDA";
			case 405:
				return "NAV";
			case 406:
				return "IOS";
			case 407:
				return "Android";
			case 500:
				return "DivX";
			case 505:
				return "ePub";
			case 600:
				return "DivX";
			case 601:
				return "WMV";
			case 602:
				return "MPG";
			case 603:
				return "DVD5";
			case 604:
				return "HD";
			case 605:
				return "IMG";
			case 606:
				return "BRay";
			case 607:
				return "HDDVD";
			case 608:
				return "WMVHD";
			case 609:
				return "X264";
			case 610:
				return "DVD9";
			case 900:
				return "XXX";
			case 901:
				return "Gay";
			case 902:
				return "Lesbo";
			case 903:
				return "BI";
			default:
				return string.Empty;
			}
		}

		public string getSpotDate(int iSeconds)
		{
			string result;
			try
			{
				result = Conversions.ToDate("1970-01-01 00:00:00").AddSeconds(iSeconds).ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = string.Empty;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public object setTimeZone(DateTime DatumTijd)
		{
			TimeZone currentTimeZone = TimeZone.CurrentTimeZone;
			TimeSpan utcOffset = currentTimeZone.GetUtcOffset(DateTime.Now);
			DatumTijd += utcOffset;
			return DatumTijd;
		}

		public string niceDate(DateTime sDate)
		{
			string result;
			try
			{
				string text = "dd-MM-yyyy HH:mm:ss";
				result = sDate.ToString(text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = Conversions.ToString(sDate);
				ProjectData.ClearProjectError();
			}
			return result;
		}

		public string makeDBDate(int iLower)
		{
			DateTime dateTime = Conversions.ToDate("1970-01-01 00:00:00");
			string value = (DateAndTime.Now - dateTime).TotalSeconds.ToString("0");
			return Conversions.ToString(Conversions.ToDouble(value) - (double)iLower);
		}

		public string kortIN(string sTmp, int iLengte)
		{
			if (Strings.Len(sTmp) > 0)
			{
				return Strings.Left(sTmp, checked(Strings.Len(sTmp) - iLengte));
			}
			return string.Empty;
		}

		public bool getSABxml(string xmlUrl, string xmlNode, ComboBox cmbBox)
		{
			bool result;
			try
			{
				WebClient webClient = new WebClient();
				string xml = webClient.DownloadString(xmlUrl);
				clsApplication clsApplication2 = new clsApplication();
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);
				cmbBox.Items.Clear();
				XmlNodeList xmlNodeList = xmlDocument.SelectNodes(xmlNode);
				foreach (XmlNode item in xmlNodeList)
				{
					cmbBox.Items.Add(item.ChildNodes[0].InnerText);
				}
				result = true;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
