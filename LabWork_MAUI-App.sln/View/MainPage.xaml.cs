using LabWork_MAUI_App.sln.ViewModel;

namespace LabWork_MAUI_App.sln;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        try
        {
            var barberViewModel = new BarberViewModel();
        }
        catch (Exception ex)
        {
            Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}

