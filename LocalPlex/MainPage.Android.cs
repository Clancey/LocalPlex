// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Comet.Handlers;
using Comet;
using Comet.Android;
using Comet.Android.Controls;

namespace LocalPlex
{
	public partial class MainPage
	{
		static MainPage()
		{
			ListViewHandler.ActionMapper[nameof(ListView.ReloadData)] = (handler, view,arg) =>
			{
				Console.WriteLine("We are reloading!");
				handler.NativeView.ReloadData();
			};

			ListViewHandler.Mapper["ListView"] = (handler, virtualView) =>{
				var nativeView = (CometRecyclerView)handler.NativeView;
				nativeView.ListView = virtualView;
			};
			ListViewHandler.Mapper["Items"] = (handler, virtualView) => {
				var nativeView = (CometRecyclerView)handler.NativeView;
				nativeView.ListView = virtualView;
				nativeView.ReloadData();
			};
		}
	}
}

