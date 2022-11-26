using GYM_APP.Entities;
using GYM_APP.Services;
using GYM_APP.Store;
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

    
        public TokenStore tokenStore;   
        public LoginViewModel(TokenStore tokenStore)
        {
            this.tokenStore = tokenStore;   
        }

        [ICommand]
        public async Task Login()
        {

            LoginService loginService = new LoginService();
            LoginData data = new();
            data.email = Username;
            data.password = Password;
            string token = await LoginService.Login(data);

            if(token != null) {
                this.tokenStore.Token = token;  
                await Shell.Current.GoToAsync($"{nameof(LandingPage)}?role=admin");
                var nav = Shell.Current.Navigation;
                nav.RemovePage(nav.NavigationStack[0]);
            }

        }
       
    }
}
