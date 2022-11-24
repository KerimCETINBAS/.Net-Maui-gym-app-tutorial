using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYM_APP.View;
namespace GYM_APP.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private NavigationViewModel navigationVM;

        [ObservableProperty]
        private string hello = "hello world";

        [ObservableProperty]
        private bool isLoggedIn = false;

        public MainViewModel(NavigationViewModel navigationVM)
        {
            this.navigationVM = navigationVM;

          
        }


       

     
    }
}
