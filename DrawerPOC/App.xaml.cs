using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrawerPOC
{
    public partial class App : Application
    {
        private MainPage _mainPage = null;
        private MainViewModel _viewModel = null;
        public App()
        {
            _viewModel = new MainViewModel();
            _mainPage = new MainPage();
            _mainPage.BindingContext = _viewModel;
            
            InitializeComponent();
            
            MainPage = _mainPage;
        }

        protected override void OnStart()
        {   
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
