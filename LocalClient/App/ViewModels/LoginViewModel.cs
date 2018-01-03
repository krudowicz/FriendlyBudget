using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.Commands;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;

namespace FriendlyBudget.LocalClient.App.ViewModels
{
    public class LoginViewModel : ViewModel
    {


        public string LoginOrEmail { get; set; }
        public string Password { get; set; }
 
        public RelayCommand LoginCommand { get; set; } 

        public LoginViewModel()
        {

        }
    }
}
