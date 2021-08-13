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
				ItemSelected = (mediaItem) =>
				{
					this.Navigate(new MoviePlayerView(()=> $"http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
				}
			} : new ActivityIndicator();
		}
	}
}

