using System;
using System.Linq;
using Comet.Graphics;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Hosting;
using System.Collections.Generic;
using Comet;
using System.IO;
using LocalPlex.Handlers;

namespace LocalPlex
{
	public class App : CometApp
	{
		public App()
		{
			this.SetEnvironment("CurrentServer",new PlexServer("192.168.1.14"));
		}
		[Body]
		View view() => new NavigationView { new MainPage() };

		public override void Configure(IAppHostBuilder appBuilder)
		{
			base.Configure(appBuilder);
			appBuilder.ConfigureMauiHandlers((handlers) =>
			{
				handlers.AddHandler<MoviePlayerView, MoviePlayerHandler>();
			});
//-:cnd
#if DEBUG
			appBuilder.EnableHotReload();
#endif
//+:cnd
		}
	}
}
