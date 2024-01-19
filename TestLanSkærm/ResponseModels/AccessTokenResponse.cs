using Newtonsoft.Json;

namespace TestLanSkærm.ResponseModels
{
	public class AccessTokenResponse
	{
		[JsonProperty("value")]
		public string? Value { get; set; }

		[JsonProperty("expiresAt")]
		public DateTime ExpiresAt { get; set; }
	}
}
