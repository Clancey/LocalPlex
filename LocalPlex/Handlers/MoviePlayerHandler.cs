using System;
using Microsoft.Maui;
using Microsoft.Maui.Handlers;
#if __IOS__ || MACCATALYST
using VideoView = LibVLCSharp.Platforms.iOS.VideoView;
#elif __ANDROID__
using VideoView = LibVLCSharp.Platforms.Android.VideoView;
#elif __WINDOWS__
using VideoView = LibVLCSharp.Platforms.Windows.VideoView;
#else
using VideoView = object;
#endif



namespace LocalPlex.Handlers
{
	public partial class MoviePlayerHandler :  ViewHandler<IMoviePlayerView,VideoView>
	{

		public MoviePlayerHandler() : base(Mapper)
		{

		}
		public static PropertyMapper<IMoviePlayerView,MoviePlayerHandler> Mapper = new(ViewHandler.ViewMapper){
			#if !NETSTANDARD
			["MediaPlayer"] = (h,v) => h.NativeView.MediaPlayer = v.MediaPlayer,
			#endif	
		};

#if __ANDROID__
		protected override VideoView CreateNativeView() => new (Context);
#else
		protected override VideoView CreateNativeView() => new ();
#endif
	}
	
}

