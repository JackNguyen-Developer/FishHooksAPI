using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FishHooksAPI.Models;
using FishHooksAPI.ViewModels;

namespace FishHooksAPI.Views
{
	public class FishHookPage : ContentPage
	{
		public FishHookPage ()
		{
			Title = "Fish Hooks";
			var list = new ListView ();
			var viewModel = new FishHookViewModel ();
			list.ItemsSource = viewModel.FishHooks;
			var cell = new DataTemplate(typeof(TextCell));
			cell.SetBinding (TextCell.TextProperty, "HookName");
			list.ItemTemplate = cell;
			list.ItemTapped += (sender, e) => {
				var fishhook = e.Item as FishHook;
				if (fishhook == null) {
					return;
				}
				Navigation.PushAsync (new FishHookDetails (fishhook));
				list.SelectedItem = null;
			};
			Content = list;
		}
	}
}

