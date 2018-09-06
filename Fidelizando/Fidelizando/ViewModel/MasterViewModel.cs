using Fidelizando.Helpers;
using Fidelizando.Models;
using Fidelizando.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fidelizando.ViewModel
{
    public class MasterViewModel : BaseViewModel
    {
        public ICommand LogoutCommand { get; set; }
        public ICommand PhotoCommand { get; set; }

        private Usuario _usuario;
        public Usuario usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
                NotifyPropertyChanged("User");
            }
        }

        public MasterViewModel()
        {
            this.LogoutCommand = new Command(Logout);
            GetUser();
        }

        private void GetUser()
        {
            usuario = new Usuario()
            {
                Email = Settings.Email,
                Nome = Settings.Name,
            };
        }

        private void Logout()
        {
            Settings.Email = string.Empty;
            Settings.Name = string.Empty;
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }

    }
}
