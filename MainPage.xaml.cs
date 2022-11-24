using GYM_APP.ViewModel;

namespace GYM_APP;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel mainVM)
	{

		this.BindingContext = mainVM;
    }



   
}

