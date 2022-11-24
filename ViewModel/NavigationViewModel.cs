using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using GYM_APP.View;
using System.Security.AccessControl;

namespace GYM_APP.ViewModel
{
    public partial class NavigationViewModel: ObservableObject
    {
        [ObservableProperty]
        private bool isLoggedIn = false;
        public NavigationViewModel()
        {
         
        }

        [ICommand]
        public async Task GoToLoginPage() => await Shell.Current.GoToAsync(nameof(LoginPage), false);
    
    }
}
