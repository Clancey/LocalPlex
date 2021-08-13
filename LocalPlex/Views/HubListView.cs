using System;
namespace LocalPlex
{
	public class HubListView : View
	{

		[Environment]
		readonly Hub CurrentHub; 

		readonly State<List<Metadata>> MediaList = new List<Metadata>(); 
		
		[Environment]
		readonly PlexServer CurrentServer;

		[Body]
		View body()
		{

			MediaList.Value = CurrentHub?.Metadata?.ToList();
			return MediaList.Value?.Any() ?? false ?
			new ListView<Metadata>(()=>MediaList.Value)
			{
				ViewFor = (item) => new HStack{
					new Image(()=>item.Thumb),
					new Text(()=>item.Title),
				}.Frame(height:66),
				ItemSelected = (o) =>
				{
					var mediaItem = o as Metadata;
					var part = mediaItem.Media.FirstOrDefault()?.Part.First();
					this.Navigate(new MoviePlayerView( $"http://192.168.1.14:32400{part.Key}"));
				}
			} : new ActivityIndicator();
		}
	}
}

