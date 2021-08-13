using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Comet;

namespace LocalPlex
{
	public partial class MainPage : View
	{

		readonly State<List<Hub>> hubSections = new List<Hub>();
		readonly State<bool> IsLoading = false;
		[Environment("CurrentServer")]
		readonly PlexServer Server;

		[Body]
		View body()
			=> new VStack {
				new Text(""),
				IsLoading ? new ActivityIndicator() : 
				hubSections.Value?.Any() ?? false ?
				new ListView<Hub>(()=>hubSections.Value){
					ViewFor = (hub) => {
						return new VStack{ new Text(hub.Title).Background(Colors.White).Color(Colors.Black) }.Frame(height:44);
					},
					ItemSelected = async (hub) =>
					{
						this.Navigate(new HubListView().SetEnvironment("CurrentHub",hub));
					}
				
				}.Background(Colors.DarkGray) : 
				new Button("Ride the Comet! ☄️", async ()=>{
					try{
						IsLoading.Value = true;
						var hub = await Server.GetHubData();
						hubSections.Value = hub.Hub.ToList();
					}
					finally{
						IsLoading.Value = false;
					}
				})
					.Frame(height:44)
					.Margin(8)
					.Color(Colors.White)
					.Background(Colors.Green)
				.RoundedBorder(color:Colors.Blue)
				.Shadow(Colors.Grey,4,2,2),
				
			};
		
	}
}

