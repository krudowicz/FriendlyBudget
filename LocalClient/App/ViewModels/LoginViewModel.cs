using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.Commands;

namespace FriendlyBudget.LocalClient.App.ViewModels
{
    class LoginViewModel
    {
        private User user;

        public string LoginOrEmail { get; set; }
        public string Password { get; set; }
        public string LoginButtonCaption {get;set;}
        public RelayCommand LoginCommand { get; set; } 

        public LoginViewModel()
        {

        }

        public void LogIn()
        {

        }
    }
}
