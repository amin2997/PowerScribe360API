using PowerScribe360Api.XmlObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PowerScribe360Api
{
	public class Powerscribe : IDisposable
	{
		private PowerscribeHttpClient _client;
		public bool IsSignIn { get; private set; } = false;

		public Powerscribe(string url)
		{
			 url = url.TrimEnd('/') + '/';
			_client = new PowerscribeHttpClient(url);
		}
		public bool SignIn(string serviceUser, string servicePassword)
		{
			if (string.IsNullOrWhiteSpace(serviceUser) || string.IsNullOrWhiteSpace(servicePassword)) return false;

			try
			{
				string uri = "services/auth.asmx/SignIn";
				serviceUser = Uri.EscapeDataString(serviceUser);
				servicePassword = Uri.EscapeDataString(servicePassword);
				string param = $"systemID=0&accessCode=&username={serviceUser}&password={servicePassword}";

				IsSignIn =_client.Post(uri, param).IsSuccessStatusCode;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}
			return IsSignIn;
		}

		//If this method is not called, the session will automatically expire after some period of inactivity (default 30 minutes).
		public bool SignOut ()
		{
			bool signOut = false;
			try
			{
				if (IsSignIn)
				{
					string uri = "services/auth.asmx/SignOut";
					signOut = _client.Post(uri, "").IsSuccessStatusCode;
					IsSignIn = !signOut;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}
			return signOut;
		}

		public bool SetCustomField(string accession, string fieldName, string fieldValue)
		{
			if (string.IsNullOrWhiteSpace(accession) || string.IsNullOrWhiteSpace(fieldName))
			{
				return false;
			}
			else if (fieldValue == null)
			{
				fieldValue = "";
			}
			//remove unicode characters.
			fieldValue = System.Text.RegularExpressions.Regex.Replace(fieldValue, @"[^\u0000-\u007F]+", string.Empty); 


			try
			{
				if (TryGetOrder(accession, out OrderData order))
				{
					string uri =  "services/customfield.asmx/SetOrderCustomFieldByName";
					string param = $"orderID={order.OrderID}&name={fieldName}&value={fieldValue}";
					return _client.TryPost(uri, param, out string result);
				}
				else
				{
					return false; // order does not exist.
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}
			return false;
		}
		public bool TryGetOrder(string accession, out OrderData orderData)
		{
			orderData = null;
			try
			{
				string uri =  "services/explorer.asmx/SearchByAccession";
				string param = $"site=&accessions={accession}&sort=";

				if (_client.TryPost(uri, param, out string xmlContent))
				{
					//TODO: figure out how to ignore xml namespaces.
					xmlContent = xmlContent.Replace("xmlns=\"http://nuance.com/commissure/webservices/explorer/2010/06\"", "");					
					orderData = XmlDeserialize<List<OrderData>>.Deserialize(xmlContent).FirstOrDefault();
					return orderData != null;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}
			return false;
		}
		public bool TryGetReport(string accession, out Report report)
		{
			report = null;
			if (string.IsNullOrWhiteSpace(accession))
			{
				return false;
			}

			try
			{
				if (TryGetOrder(accession, out OrderData order))
				{
					string uri = "services/report.asmx/GetReport";
					string param = $"reportID={order.ReportID}";
					if(_client.TryPost(uri, param, out string xmlReport))
					{
						//TODO: figure out how to ignore xml namespaces.
						xmlReport = xmlReport.Replace("xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns=\"http://nuance.com/commissure/webservices/report/2010/06\"", "");
						report = XmlDeserialize<Report>.Deserialize(xmlReport);
						return report != null;
					}
				}
				else
				{
					return false; // order does not exist.
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message + "\n" + ex.StackTrace);
			}
			return false;
		}

		#region IDisposable Support
		private bool _disposed = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					SignOut();
					_client?.Dispose();
				}
				_disposed = true;
			}
		}
		public void Dispose()
		{			
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion



	}
}
