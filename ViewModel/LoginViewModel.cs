using GYM_APP.View;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_APP.ViewModel
{
   
    public partial class LoginViewModel: ObservableObject
    {

        [ObservableProperty]
        private string username;

        [ObservableProperty] 
        private string password;

        [ICommand]
        public async Task Login()
        {

            if (Username != "admin") return;
            if (Password != "1234") return;

            await Shell.Current.GoToAsync($"{nameof(LandingPage)}?role=admin");
            var nav = Shell.Current.Navigation;
            nav.RemovePage(nav.NavigationStack[0]);
        }
       
    }
}
