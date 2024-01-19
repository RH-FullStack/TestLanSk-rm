using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using TestLanSkærm.ResponseModels;
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

		public async Task<AccessTokenResponse> GetAuthTokenAsync()
		{
			string apiUrl = "https://publicapi.challengermode.com/mk1/v1/auth/access_keys";
			string accessToken = "YOUR_ACCESS_TOKEN";  // Replace with your actual access token

			using (HttpClient client = new HttpClient())
			{
				client.DefaultRequestHeaders.Add("Accept", "*/*");
				client.DefaultRequestHeaders.Add("Origin", "https://www.challengermode.com");
				client.DefaultRequestHeaders.Add("Referer", "https://www.challengermode.com/");

				// Request body
				string requestBody = "{\"refreshKey\": \"MmUyM2RlODZjYTI4NDAzNTg1NzUwOGRjMTA3NzFhZTByQURTVkViUFBXWU9xbHlDSHBza2NhY3BITHBPTEFMUg==\"}";  // Replace with your actual JSON request body

				var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

				HttpResponseMessage response = await client.PostAsync(apiUrl, content);

				if (response.IsSuccessStatusCode)
				{
					string result = await response.Content.ReadAsStringAsync();
					if (result != null)
					{
						AccessTokenResponse? tokenResponse = JsonConvert.DeserializeObject<AccessTokenResponse>(result);

						if (tokenResponse != null)
						{
							return tokenResponse;
						}
						else
						{
							return new AccessTokenResponse { Value= null };
						}
					}

					return new AccessTokenResponse { Value = null };
				}
				else
				{
					Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
				}
				return new AccessTokenResponse { Value = null };
			}

		}
	}
}
