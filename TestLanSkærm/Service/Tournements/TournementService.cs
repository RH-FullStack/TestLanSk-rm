using Newtonsoft.Json;
using System.Text;
using TestLanSkærm.Models.Tournement;

namespace TestLanSkærm.Service.Tournements
{
	
	public class TournementService
	{
		
		public static async Task<List<Tournement>> GetAllTournements(string authKey, List<string>? TournementIDs)
		{
            List<Tournement> tournements = new List<Tournement>();
			var client = new HttpClient();
			var request = new HttpRequestMessage(HttpMethod.Post, "https://publicapi.challengermode.com/graphql");
			request.Headers.Add("Authorization", "bearer " + authKey);
            foreach (var tournemnt in TournementIDs)
			{
                var variables = new
                {
                    tournamentId = tournemnt
                };
                var query = @"
            query tournament ($tournamentId: UUID!) {
                tournament (tournamentId: $tournamentId) {
                    description
                    id
                    name
                    state
                }
            }
        ";
                var content = new StringContent(JsonConvert.SerializeObject(new { query, variables }), Encoding.UTF8, "application/json");
                request.Content = content;
                var response = await client.SendAsync(request);
                string data = await response.Content.ReadAsStringAsync();

                TournamentData tournamentData = JsonConvert.DeserializeObject<TournamentData>(data);


                tournements.Add(tournamentData.Data.Tournement);
            }
			
			return tournements;
		}
	}
}
