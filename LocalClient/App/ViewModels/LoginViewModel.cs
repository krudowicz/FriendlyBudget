using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget.LocalClient.Components.DAL.DTO;
using FriendlyBudget.LocalClient.Components.Commands;
using FriendlyBudget.LocalClient.Components.Core.Abstraction;

namespace FriendlyBudget.LocalClient.App.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        private string _textBoxLabel;
        private string _passwordBoxLabel;

        public string LoginOrEmail { get; set; }
        public string Password { get; set; }
        public string LoginButtonCaption {get;set;}
        public string TextBoxLabel
        {
            get { return _textBoxLabel; }
            private set
            {
                _textBoxLabel = value;
                NotifyPropertyChanged(TextBoxLabel);
            }
        }

        public string PasswordBoxLabel
        {
            get { return _passwordBoxLabel; }
            private set
            {
                _passwordBoxLabel = value;
                NotifyPropertyChanged(PasswordBoxLabel);
            }
        }

        public RelayCommand LoginCommand { get; set; } 

        public LoginViewModel()
        {
            TextBoxLabel = "Login/Email";
            PasswordBoxLabel = "Password";
        }

        public void LogIn()
        {

        }
    }
}
