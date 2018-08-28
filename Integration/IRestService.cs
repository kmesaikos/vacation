using System.Collections.Generic;

namespace semester.Integration
{
	public interface IRestService
	{
		T Get<T>(string url, IDictionary<string, string> query = null);
		T Post<T>(string url, object content, IDictionary<string, string> query = null);
	}
}