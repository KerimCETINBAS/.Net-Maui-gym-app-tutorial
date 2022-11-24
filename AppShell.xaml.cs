using GYM_APP.View;
using GYM_APP.ViewModel;

namespace GYM_APP;

public partial class AppShell : Shell 
{ 

    public  AppShell()
	{

    
        InitializeComponent();
        Routing.RegisterRoute(nameof(LandingPage), typeof(LandingPage));


    }
}
