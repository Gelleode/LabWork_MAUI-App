using LabWork_MAUI_App.sln.ViewModel;

namespace LabWork_MAUI_App.sln;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();

        BindingContext = new CountryViewModel();
    }
}

