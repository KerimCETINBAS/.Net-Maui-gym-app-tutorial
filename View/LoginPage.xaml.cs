using GYM_APP.ViewModel;

namespace GYM_APP.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginVM)
	{
		InitializeComponent();

		BindingContext = loginVM;
	}
}