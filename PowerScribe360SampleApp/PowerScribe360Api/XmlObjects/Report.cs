using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace PowerScribe360Api.XmlObjects
{
	public class Report
	{
		public string ReportID { get; set; }
		public List<string> Accessions { get; set; }
		public string ReportStatus { get; set; }
		public string TransferStatus { get; set; }
		public string CreateDate { get; set; }
		public string LastModifiedDate { get; set; }
		public string ContentText { get; set; }
		public string ContentRTF { get; set; }
		public string IsAddendum { get; set; }
		public string IsStat { get; set; }
		public Signer Signer { get; set; }
		public Person Person { get; set; }
		public override string ToString() => ContentText;


		private static string _extractPattern = "(mergename=\")\\w+(\")><name>(\\w+)</name><value>(\\w+)</value></field>";
		private static Regex _regex = new Regex(_extractPattern, RegexOptions.Multiline | RegexOptions.IgnoreCase);
		public List<Tuple<string, string>> GetCustomFeilds()
		{
			List<Tuple<string, string>> result = new List<Tuple<string, string>>();
			if (string.IsNullOrWhiteSpace(ContentRTF)) return result;

			try
			{
				var matches = _regex.Matches(ContentRTF);
				foreach (Match match in matches)
				{
					if (match.Success == false) continue;
					Debug.WriteLine($"Value:{match.Value}, Group:{match.Groups}");
					if (match.Groups.Count == 5)
					{
						string feildName = match.Groups[3].Value;
						string feildValue = match.Groups[4].Value;

						Tuple<string, string> feild = new Tuple<string, string>(feildName, feildValue);
						result.Add(feild);						
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}


			return result;
		}
	}
	public class Signer
	{
		public string AccountID { get; set; }
		public string Site { get; set; }
		public string Identifier { get; set; }
	}
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Country { get; set; }
		public override string ToString() => $"{FirstName} {LastName}";
	}
}
