using System.Text;
using TestLanSkærm.Service;
namespace TestLanSkærm.Service
{
	public class GetAuthTokenGraphQL
	{
		private readonly HttpClientService _httpClientService;
		public GetAuthTokenGraphQL( HttpClientService httpClientService) 
		{
			_httpClientService = httpClientService;
		}

		public HttpResponseMessage GetAuthToken()
		{
			var refreshKey = "NmQ2OGNmODFjYTgzNDk5MjMyYjMwOGRjMTFmYTJlNTNqYWl6S0RFTmJ5cHlzTldoR2thTE1DcFVzZnNtT2dZRQ==";
			var testClient = _httpClientService.GetHttpClient();
			var baseUrl = "https://publicapi.challengermode.com/mk1/v1/auth/access_keys";
			testClient.DefaultRequestHeaders.Add("refreshKey", refreshKey);
			var response = testClient.PostAsync(baseUrl, null);

			return response.Result;
		}
	}
}
