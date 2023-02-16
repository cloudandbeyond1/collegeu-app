using Syncfusion.Maui.TabView;
using MauiApp1.Pages;

namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private void OnCounterClicked(object sender, EventArgs e)
    {

        Application.Current.MainPage = new AppShell();
    }

}