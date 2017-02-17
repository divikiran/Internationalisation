using System;
using System.Collections.Generic;
using System.IO;

namespace FormsInternationlization
{
	public static class Multilanguage
	{
		static Dictionary<string, string> dictionary;

		public static void LoadDictionary(Stream stream)
		{
			dictionary = new Dictionary<string, string>();
			using (var streamReader = new StreamReader(stream))
			{
				while (!streamReader.EndOfStream)
				{
					var columns = streamReader.ReadLine().Split(':');
					dictionary.Add(columns[0].Trim(), columns[1].Trim());
				}
				//streamReader.Close();
			}
		}

		public static string Translate(this string key)
		{
			return dictionary.ContainsKey(key) ? dictionary[key] : "%" + key + "%";
		}
	}
}
