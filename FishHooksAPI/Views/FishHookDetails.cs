using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FishHooksAPI.Models;

namespace FishHooksAPI.Views
{
	public class FishHookDetails : ContentPage
	{
		
		public FishHookDetails (FishHook fishHook)
		{
			this.Title = fishHook.HookName;
			StringBuilder sb = new StringBuilder ();
			sb.Append ("Best used for:").AppendLine ().Append (fishHook.BestSpecies).AppendLine ().AppendLine ();
			sb.Append ("Hook details:").AppendLine ().Append (fishHook.HookDetails).AppendLine ().AppendLine ();
			var details = new Label{
				Text = sb.ToString()
			};
			Content = new ScrollView {
				Padding = 20,
				Content = details
			};
		}
	}
}

