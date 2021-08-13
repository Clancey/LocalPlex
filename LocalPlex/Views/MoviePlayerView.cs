// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Comet;
using LibVLCSharp.Shared;
using LocalPlex;

[assembly: CometGenerate(typeof(IMoviePlayerView), nameof(IMoviePlayerView.MediaSource))]

namespace LocalPlex
{
	public partial class MoviePlayerView : View
	{
		static MoviePlayerView()
		{
			Core.Initialize();
			LibVLC = new LibVLC(enableDebugLogs: true);
		}
		protected static LibVLC LibVLC { get; set; }

		public override void ViewPropertyChanged(string property, object value)
		{
			base.ViewPropertyChanged(property, value);
			if(property == nameof(IMoviePlayerView.MediaSource))
			{
				var view  = (IMoviePlayerView)this;
				view.MediaPlayer ??= new MediaPlayer(LibVLC);
				view.MediaPlayer.Media = new Media(LibVLC,new Uri(this.MediaSource.CurrentValue));
			}
		}
	}
}

