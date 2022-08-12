using System.ComponentModel;
using Xamarin.Forms;

namespace DrawerPOC
{
	internal class MainViewModel : INotifyPropertyChanged
	{
		public MainViewModel()
		{
			ToggleDrawerCommand = new Command(UpdateDrawerStatus);
		}

		public Command ToggleDrawerCommand { get; set; }
		
		public bool IsDrawerOpen { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void UpdateDrawerStatus()
		{
			if (IsDrawerOpen)
			{
				IsDrawerOpen = false;
			}
			else
			{
				IsDrawerOpen = true;
			}

			PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsDrawerOpen)));
		}
	}
}
