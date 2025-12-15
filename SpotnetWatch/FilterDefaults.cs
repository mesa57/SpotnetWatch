using System;
using System.Collections.Generic;
using System.IO;

namespace SpotnetWatch
{
	internal static class FilterDefaults
	{
		private static readonly List<string> DefaultFilters = new List<string>
		{
			"Films - Alle||0|100,101,102,103,104,105,106,107,108,109,110||",
			"Series - Alle||0|600,601,602,603,604,605,606,607,608,609,610||",
			"Muziek - Alles||0|200,201,202,203,204,205,206,207,208||",
			"Spellen - Alles||0|300,301,302,303,304,305,306,307,308,309,310,311,312,313,314,315||",
			"Software - Alles||0|400,401,402,403,404,405,406,407||",
			"Boeken||0|500,505||",
			"Erotiek||0|900,901,902,903||",
			"24|24|0|600,601,602,603,604,605,606,607,608,609,610||",
			"Arrow|Arrow|0|600,601,602,603,604,605,606,607,608,609,610||",
			"Breaking Bad|Breaking Bad|0|600,601,602,603,604,605,606,607,608,609,610||",
			"CSI|CSI|0|600,601,602,603,604,605,606,607,608,609,610||",
			"Game of Thrones|Game of Thrones|0|600,601,602,603,604,605,606,607,608,609,610||",
			"Prison Break|Prison Break|0|600,601,602,603,604,605,606,607,608,609,610||"
		};

		internal static void EnsureFilterFile()
		{
			try
			{
				string path = appModule.PATH_FILTER_FILE;
				if (File.Exists(path))
				{
					string[] existing = File.ReadAllLines(path);
					foreach (string line in existing)
					{
						if (!string.IsNullOrWhiteSpace(line))
						{
							return;
						}
					}
				}

				string directoryName = Path.GetDirectoryName(path);
				if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}

				using (StreamWriter streamWriter = new StreamWriter(path, false))
				{
					foreach (string filter in DefaultFilters)
					{
						streamWriter.WriteLine("[" + filter + "]");
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
