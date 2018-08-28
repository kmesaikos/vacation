using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace semester.Integration
{
	public class RestService : IRestService
	{
		private readonly HttpClient _client;

		public RestService(HttpClient client)
		{
			_client = client;
		}

		public T Get<T>(string url, IDictionary<string, string> query = null)
		{
			var response = _client.GetAsync($"{url}{GetQueryParameters(query)}").GetAwaiter().GetResult();
			return ReadResponse<T>(response);
		}

		private static T ReadResponse<T>(HttpResponseMessage response)
		{
			return response.IsSuccessStatusCode
				? response.Content.ReadAsAsync<T>().GetAwaiter().GetResult()
				: default(T);
		}

		public T Post<T>(string url, object content, IDictionary<string, string> query = null)
		{
			var response = _client.PostAsJsonAsync($"{url}{GetQueryParameters(query)}", content).GetAwaiter().GetResult();
			return ReadResponse<T>(response);
		}

		private static string GetQueryParameters(IDictionary<string, string> query) => query?.Count > 0 ? $"?{string.Join("&", GetKeyValuePairs(query))}" : string.Empty;
		private static IEnumerable<string> GetKeyValuePairs(IDictionary<string, string> query) => query.Select(pair => $"{pair.Key}={pair.Value}");

	}
}
