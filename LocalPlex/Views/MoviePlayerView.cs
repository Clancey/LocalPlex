// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Comet;
using LibVLCSharp.Shared;
using LocalPlex;

[assembly: CometGenerate(typeof(IMoviePlayerView))]

namespace LocalPlex
{
	public partial class MoviePlayerView : View
	{

		public MoviePlayerView(string source)
		{
			if (!string.IsNullOrWhiteSpace(source))
			{
				var view = (IMoviePlayerView)this;
				view.MediaPlayer ??= new(LibVLC);
				view.MediaPlayer.Media = new Media(LibVLC, new Uri(source));
				view.MediaPlayer.Play();
			}
		}
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
				view.MediaPlayer ??= new (LibVLC);
				//view.MediaPlayer.Media = new Media(LibVLC,new Uri(this.MediaSource.CurrentValue));
			}
		}
	}
}

