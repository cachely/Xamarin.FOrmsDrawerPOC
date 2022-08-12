using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrawerPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomDrawerView : ContentView
    {
        public BottomDrawerView()
        {
            InitializeComponent();
			Task.Run(async () =>	await this.TranslateTo(0, 60, 600, Easing.SinInOut));
		}

		public static readonly BindableProperty IsSlideOpenProperty =
			BindableProperty.Create(
				nameof(IsSlideOpen),
				typeof(bool),
				typeof(BottomDrawerView),
				false,
				propertyChanged: SlideOpenClose);

		public bool IsSlideOpen
		{
			get => (bool)GetValue(IsSlideOpenProperty); 
			set =>  SetValue(IsSlideOpenProperty, value); 
		}
		
		private static async void SlideOpenClose(BindableObject bindable, object oldValue, object newValue)
		{
				if ((bool)newValue)
				{
					await (bindable as BottomDrawerView).TranslateTo(0, 0, 250, Easing.SinInOut);
					await (bindable as BottomDrawerView).drawerIcon.RotateTo(180);
			    }
				else
				{
					await (bindable as BottomDrawerView).TranslateTo(0, 60, 600, Easing.SinInOut);
					await (bindable as BottomDrawerView).drawerIcon.RotateTo(0);
				}
		}
	}
}