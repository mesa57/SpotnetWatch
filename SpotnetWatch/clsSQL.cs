using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SpotnetWatch
{
	public class clsSQL
	{
		public bool SQLInjection(string sString)
		{
			Regex regex = new Regex("^[a-zA-Z0-9 ]+$");
			if (regex.Match(sString).Success)
			{
				return false;
			}
			return true;
		}

		private string SQLItems(string Line, bool First)
		{
			string text = string.Empty;
			try
			{
				string[] array = Line.Split('|');
				string text2 = array[1];
				int num = Conversions.ToInteger(array[2]);
				string text3 = array[4];
				string text4 = array[5];
				List<string> list = new List<string>();
				if (array[3].Contains(","))
				{
					list.AddRange(array[3].Split(','));
				}
				else
				{
					list.Add(array[3]);
				}
				if (num != 1)
				{
					text2 = Strings.Replace(text2, " ", "%%");
					text2 = "%" + text2 + "%";
				}
				else
				{
					text2 = "%" + text2 + "%";
				}
				text3 = ((Operators.CompareString(text3, string.Empty, false) == 0) ? string.Empty : (" AND sender LIKE '%" + text3 + "%'"));
				text4 = ((Operators.CompareString(text4, string.Empty, false) == 0) ? string.Empty : (" AND tag LIKE '%" + text4 + "%'"));
				foreach (string item in list)
				{
					if (First)
					{
						First = false;
						text = text + " AND (subject LIKE '" + text2 + "' AND subcat = '" + item.ToString() + "'" + text3 + text4;
					}
					else
					{
						text = text + " OR subject LIKE '" + text2 + "' AND subcat = '" + item.ToString() + "'" + text3 + text4;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				text = string.Empty;
				ProjectData.ClearProjectError();
			}
			return text;
		}

		public string SQLBuilder()
		{
			string result = string.Empty;
			checked
			{
				int iLower = (int)Math.Round(Conversions.ToDouble(appModule.APP_SQL_MAX_DAYS) * 60.0 * 60.0 * 24.0);
				bool flag = true;
				string text = string.Empty;
				try
				{
					if (File.Exists(appModule.PATH_FILTER_FILE))
					{
						string[] array = File.ReadAllLines(appModule.PATH_FILTER_FILE);
						if (array.Count() > 0)
						{
							string[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								string text2 = array2[i];
								text2 = text2.Trim();
								if (text2.StartsWith("[") & text2.EndsWith("]"))
								{
									text2 = text2.Replace("[", string.Empty);
									text2 = text2.Replace("]", string.Empty);
									if (flag)
									{
										flag = false;
										text += SQLItems(text2.ToString(), true);
									}
									else
									{
										text += SQLItems(text2.ToString(), false);
									}
								}
							}
							if (!flag && Operators.CompareString(text, string.Empty, false) != 0)
							{
								clsApplication clsApplication2 = new clsApplication();
								result = "SELECT rowid, key, cat, subcat, extcat, date, filesize, cats, sender, tag, subject, msgid, modulus FROM spots ";
								result = result + "WHERE date > " + clsApplication2.makeDBDate(iLower);
								result = result + text + ") ORDER BY cat, subject, date DESC LIMIT " + appModule.APP_SQL_MAX_ROWS + ";";
							}
						}
					}
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
		}
	}
}
