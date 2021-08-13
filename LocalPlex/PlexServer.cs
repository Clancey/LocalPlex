using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalPlex
{
	public class PlexServer
	{
		PlexApi Api;
		public PlexServer(string ip, int port = 32400)
		{
			Api = new PlexApi(ip, port);
		}

		//public Task<Plex.ServerApi.PlexModels.Server.PlexServer> ServerData() => Api.GetFromContainer<Plex.ServerApi.PlexModels.Server.PlexServer>("/");

		public Task<string> Search(string search) => Api.Get("/search", queryParameters: new()
		{
			["query"] = search
		});




		//public Task<Sections> GetAllSection()
		//	=> Api.GetFromContainer<Sections>("/library/sections");

		public async Task<Sections> GetDirectoryData(Directory directory = null, int maxResults = 50, int offset = 0)
		{
			var data = await Api.GetFromContainer<Sections>($"/library/sections/{directory?.GetFullKeyPath}", headers: new ()
			{
				["X-Plex-Container-Size"] = $"{maxResults}",
				["X-Plex-Container-Start"] = $"{offset}"
			});
			if(data.Directory != null && directory != null)
				foreach (var d in data.Directory)
					d.ParentKey = directory?.GetFullKeyPath;
			return data;
		}
		public async Task<HubSection> GetHubData(Hub hub = null)
		{
			var data = await Api.GetFromContainer<HubSection>($"hubs/{hub?.HubKey}", headers: new Dictionary<string, string>
			{
				["X-Plex-Container-Size"] = "5",
				["X-Plex-Container-Start"] = "0"
			});


			return data;
		}


	}
}
