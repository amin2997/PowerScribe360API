using System.Net.Http;

namespace PowerScribe360Api
{
	public class PowerscribeHttpClient : HttpClient
	{
		private string _url;
		public PowerscribeHttpClient(string url)
		{
			_url = url;
		}
		public bool TryPost(string uri, string param, out string result)
		{
			var response = Post(uri, param);
			result = response.Content.ReadAsStringAsync().Result;
			System.Diagnostics.Debug.WriteLine(result);
			return response.IsSuccessStatusCode;
		}
		public HttpResponseMessage Post(string uri, string param="")
		{

			StringContent content = string.IsNullOrWhiteSpace(param) ? new StringContent("") : new StringContent(param, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
			string fullUrl = _url + uri;
			return PostAsync(fullUrl, content).Result;
		}
	}
}
