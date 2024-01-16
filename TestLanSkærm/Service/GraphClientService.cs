using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
namespace TestLanSkærm.Service
{
	public class GraphClientService
	{
		private readonly GraphQLHttpClient _client;

		public GraphClientService(string apiUrl)
		{
			_client = new GraphQLHttpClient(apiUrl, new NewtonsoftJsonSerializer());
		}

		public async Task<T> SendQueryAsync<T>(string query)
		{
			var request = new GraphQLRequest { Query = query };
			var response = await _client.SendQueryAsync<T>(request);
			return response.Data;
		}
	}
}
