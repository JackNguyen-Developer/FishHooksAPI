using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.ObjectModel;
using FishHooksAPI.Models;

namespace FishHooksAPI.ViewModels
{
	public class FishHookViewModel
	{
		public ObservableCollection<FishHook> FishHooks{ get; set; }

		public FishHookViewModel ()
		{
			FishHooks = new ObservableCollection<FishHook> ();
			FishHooks.Add (new FishHook { 
				HookName = "Hook name 1",
				BestSpecies = "Step1, Step2, Step3",
				HookDetails = "This is details"
			});


			FishHooks.Add (new FishHook { 
				HookName = "Hook name 2",
				BestSpecies = "Step1, Step2, Step3",
				HookDetails = "This is details"
			});

			FishHooks.Add (new FishHook { 
				HookName = "Hook name 3",
				BestSpecies = "Step1, Step2, Step3",
				HookDetails = "This is details"
			});

			FishHooks.Add (new FishHook { 
				HookName = "Hook name 4",
				BestSpecies = "Step1, Step2, Step3",
				HookDetails = "This is details"
			});

		}
	}
}

