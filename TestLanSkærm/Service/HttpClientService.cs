namespace TestLanSkærm.Service
{
	public class HttpClientService
	{
		private readonly HttpClient _httpClient;
		public HttpClientService(HttpClient httpClient) 
		{
			_httpClient = httpClient;
		}

		public HttpClient GetHttpClient()
		{
			_httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

			return _httpClient;
		}



		

	}
}
