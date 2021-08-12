using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;
using Comet;

namespace LocalPlex
{
	public partial class CometRide 
	{
		[AutoNotify]
		int rides;

		public string CometTrain => "☄️".Repeat(Rides);
	}

	public class MainPage : View
	{

		[State]
		readonly CometRide comet = new();

		[Body]
		View body()
			=> new VStack {
				new Text(()=> $"{comet.CometTrain}")   
					.Frame(width:300)
					.LineBreakMode(LineBreakMode.CharacterWrap),

				new Button("Ride the Comet! ☄️", ()=>{
					comet.Rides++;
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

