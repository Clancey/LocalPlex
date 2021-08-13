using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SimpleAuth;

namespace LocalPlex
{
	public class PlexApi : AuthenticatedApi
	{
		private readonly string serverUrl;
		private readonly int serverPort;
		ClientOptions ClientOptions;
		public PlexApi(string serverIp,int serverPort = 32400, ClientOptions clientOptions = null, string encryptionKey = "", HttpMessageHandler handler = null) : base("plex", encryptionKey, handler)
		{
			this.serverUrl = serverIp;
			this.serverPort = serverPort;
			ClientOptions = clientOptions ?? new();
			BaseAddress = new Uri($"http://{serverIp}:{serverPort}");
			PrepareClient(Client);
		}

		public override Task PrepareClient(HttpClient client)
		{
			client.DefaultRequestHeaders.Add("X-Plex-Client-Identifier", ClientOptions.ClientId);
			client.DefaultRequestHeaders.Add("X-Plex-Provides", "player");
			client.DefaultRequestHeaders.Add("Accept", "application/json");
			return base.PrepareClient(client);
		}

		public async Task<T> GetFromContainer<T>(string path, Dictionary<string, string> headers = null, params (string key, string query)[] queryParams)
			=> (await Get<GenericWrapper<T>>(path, queryParameters: queryParams?.ToDictionary(x => x.key, x => x.query), headers)).Container;
		protected override Task<Account> PerformAuthenticate() => Task.FromResult<Account>(null);

		protected override Task<bool> RefreshAccount(Account account) => Task.FromResult(true);
	}
}
